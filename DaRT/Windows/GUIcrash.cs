using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace DaRT
{
    public partial class GUIcrash : Form
    {
        GUImain gui;

        public GUIcrash(Exception e, String version, GUImain gui)
        {
            InitializeComponent();

            this.gui = gui;

            Process p = Process.GetCurrentProcess();
            PerformanceCounter memUsage = new PerformanceCounter("memory", "Available MBytes");

            exception.Text += "---------- Info ----------\r\n";
            exception.Text += "DaRT " + version + "\r\n";
            exception.Text += "Time of crash: " + System.DateTime.Now + "\r\n";
            exception.Text += "Total used memory: " + p.PrivateMemorySize64 / 1024 / 1024 + " MB / " + memUsage.NextValue() + " MB\r\n";
            exception.Text += "Threads: " + p.Threads.Count + "\r\n";
            exception.Text += "---------- Error ----------\r\n";
            exception.Text += e.Message + "\r\n";
            exception.Text += "---------- StackTrace ----------\r\n";
            exception.Text += e.StackTrace;
        }

        private void GUIcrash_FormClosing(object sender, FormClosingEventArgs e)
        {
            gui.Close();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            exception.Text += "\r\n---------- Description ----------\r\n";
            if (description.Text != "Problem! Please describe what you did to cause this crash.")
                exception.Text += description.Text;
            else
                exception.Text += "(No description)";

            String log = exception.Text;
            String data = String.Format("key={0}&log={1}", "d2kso2laoxp2ld8fmy4qk2js8rl5kf7r", log);

            ServicePointManager.ServerCertificateValidationCallback += new System.Net.Security.RemoteCertificateValidationCallback(certCheck);
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("https://forum.swisscraft.eu/DaRT Crash/crash.php");
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
            request.GetResponse().Close();

            this.Close();
        }

        bool certCheck(object sender, X509Certificate cert, X509Chain chain, System.Net.Security.SslPolicyErrors error) { return true; }
    }
}
