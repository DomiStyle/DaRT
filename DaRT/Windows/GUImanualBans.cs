using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace DaRT
{
    public partial class GUImanualBans : Form
    {
        private RCon _rcon;

        public GUImanualBans(RCon rcon)
        {
            InitializeComponent();

            _rcon = rcon;
            this.Text = "Manually add ban(s)";
            this.input.Text = "Add bans like this:\r\ndartdartdartdartdartdartdartdart -1 Reason\r\ndartdartdartdartdartdartdartdart\r\nBoth formats are valid.";
        }

        private void ban_Click(object sender, EventArgs e)
        {
            List<Ban> bans = new List<Ban>();

            using (StringReader reader = new StringReader(input.Text))
            {
                String line;
                while ((line = reader.ReadLine()) != null)
                {
                    String[] items = line.Split(new char[] { ' ' }, 3, StringSplitOptions.RemoveEmptyEntries);
                    if (items.Length == 1)
                        bans.Add(new Ban(items[0], 0, "Banned by DaRT!"));
                    else if (items.Length == 3)
                    {
                        if (items[1] == "-1")
                            bans.Add(new Ban(items[0], 0, items[2]));
                        else
                        {
                            try
                            {
                                bans.Add(new Ban(items[0], int.Parse(items[1]), items[2]));
                            }
                            catch
                            {
                            }
                        }
                    }
                }
            }
            foreach (Ban ban in bans)
            {
                _rcon.Ban(ban);
            }

            this.Close();
        }

        private void abort_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void input_Enter(object sender, EventArgs e)
        {
            if (input.Text.StartsWith("Add bans like this:"))
                input.Clear();
        }
    }
}
