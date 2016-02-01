using System;
using System.IO;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Diagnostics;

namespace DaRT
{
    public partial class GUIreport : Form
    {
        private GUImain gui;
        private String reporter = "";
        private String ip = "";
        private String port = "";
        private String guid = "";
        private String name = "";

        public GUIreport(GUImain gui, String reporter, String ip, String port, String guid, String name)
        {
            InitializeComponent();

            this.gui = gui;
            this.reporter = reporter;
            this.ip = ip;
            this.port = port;
            this.guid = guid;
            this.name = name;
            this.Text = "Reporting " + name + " to DaRTBans";
        }

        bool certCheck(object sender, X509Certificate cert, X509Chain chain, System.Net.Security.SslPolicyErrors error) { return true; }

        private void report_Click(object sender, EventArgs e)
        {
            if (agree.Checked && reason.Text != "")
            {
                WebRequest.DefaultWebProxy = gui.proxy;
                HtmlWeb htmlWeb = new HtmlWeb();
                htmlWeb.UserAgent = "DaRT 0.6";
                HtmlAgilityPack.HtmlDocument doc = htmlWeb.Load("http://www.gametracker.com/server_info/" + reporter + ":" + port + "/server_variables/");

                HtmlNode rootNode = doc.DocumentNode;
                HtmlNodeCollection table = rootNode.SelectNodes("//table[@class='table_lst table_lst_gse']//tr//td[@class='c02']");

                String servername = null;
                String signature = null;

                if (table != null)
                {
                    foreach (HtmlNode node in table)
                    {
                        if (node.InnerHtml.Contains("hostname"))
                        {
                            servername = node.InnerText.Trim();
                        }
                        else if (node.InnerHtml.Contains("signatures"))
                        {
                            signature = node.InnerText.Trim();
                        }
                    }
                }

                if (servername == null)
                {
                    servername = "N/A";
                }
                if (signature == null)
                {
                    signature = "N/A";
                }
                
                String data = String.Format("key={0}&reporter={1}&port={2}&ip={3}&guid={4}&name={5}&reason={6}&url={7}&servername={8}&signature={9}", "d2kso2laoxp2ld8fmy4qk2js8rl5kf7r", reporter, port, ip, guid, name, reason.Text, "", servername, signature);
                
                ServicePointManager.ServerCertificateValidationCallback += new System.Net.Security.RemoteCertificateValidationCallback(certCheck);
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("https://forum.swisscraft.eu/DaRT report.php");
                request.Proxy = gui.proxy;
                request.KeepAlive = false;
                request.ProtocolVersion = HttpVersion.Version10;
                request.Method = "POST";
                request.UserAgent = "DaRT " + gui.version;

                byte[] postBytes = Encoding.ASCII.GetBytes(data);

                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = postBytes.Length;
                Stream requestStream = request.GetRequestStream();

                requestStream.Write(postBytes, 0, postBytes.Length);
                requestStream.Close();

                HttpWebResponse responseStream = (HttpWebResponse)request.GetResponse();
                String response = new StreamReader(responseStream.GetResponseStream()).ReadToEnd();
                responseStream.Close();

                if (response.Equals("OK"))
                {
                    gui.Invoke((MethodInvoker)delegate
                    {
                        gui.Log("Player has been reported.", LogType.Console, false);
                    });
                }
                else if (response.Equals("Already reported"))
                {
                    gui.Invoke((MethodInvoker)delegate
                    {
                        gui.Log("You can not report a player two times.", LogType.Console, false);
                    });
                }
                else if (response.Equals("Blacklisted"))
                {
                    gui.Invoke((MethodInvoker)delegate
                    {
                        gui.Log("It appears you are blacklisted, you can not report players.", LogType.Console, false);
                    });
                }
                else if (response.Equals("No valid server"))
                {
                    gui.Invoke((MethodInvoker)delegate
                    {
                        gui.Log("It appears that your server is not a valid, whitelisted DayZ server or is not listed on GameTracker.", LogType.Console, false);
                        gui.Log("Please register your server at GameTracker in order to use this feature. http://www.gametracker.com/server_info/" + reporter + ":" + port + "/", LogType.Console, false);
                    });
                }
                else
                {
                    gui.Invoke((MethodInvoker)delegate
                    {
                        gui.Log("An error occurred. Please report this to me:", LogType.Console, false);
                        gui.Log(response, LogType.Console, false);
                    });
                }
                this.Close();
            }
        }

        private void abort_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GUIreport_FormClosing(object sender, FormClosingEventArgs e)
        {
            gui.Invoke((MethodInvoker)delegate
            {
                gui.Enabled = true;
            });
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Process.Start("http://forum.swisscraft.eu/DaRT Bans/bans.txt");
        }
    }
}
