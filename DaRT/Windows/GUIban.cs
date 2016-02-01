using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using DaRT.Properties;

namespace DaRT
{
    public partial class GUIban : Form
    {
        private RCon _rcon;
        private Ban _ban;

        public GUIban(RCon rcon, int id, string name, string guid, string ip, bool online)
        {
            InitializeComponent();

            _rcon = rcon;
            _rcon.Pending = name;

            _ban = new Ban(id, name, guid, ip, online);

            if (_ban.Online)
                this.Text = "Ban " + _ban.Name;
            else
                this.Text = "Ban " + _ban.Name + " (Offline)";

            try
            {
                span.SelectedIndex = Settings.Default.span;
            }
            catch
            {
                Settings.Default.span = 0;
            }

            if (_ban.Online)
            {
                if (Settings.Default.banGUID && Settings.Default.banIP)
                    mode.SelectedIndex = 2;
                if (Settings.Default.banGUID)
                    mode.SelectedIndex = 0;
                else if (Settings.Default.banIP)
                    mode.SelectedIndex = 1;
            }
            else
            {
                mode.SelectedIndex = 0;
                mode.Enabled = false;
            }
        }

        private void ban_Click(object sender, EventArgs e)
        {
            _ban.Reason = reason.Text;

            int duration = 0;
            try
            {
                duration = int.Parse(this.duration.Text);
            }
            catch
            {
                MessageBox.Show("Duration must be a number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (span.SelectedIndex == 1)
                duration *= 60;
            else if (span.SelectedIndex == 2)
                duration *= 1440;
            else if (span.SelectedIndex == 3)
                duration *= 10080;

            _ban.Duration = duration;

            if (mode.SelectedIndex == 0)
                _ban.IP = "";
            else if (mode.SelectedIndex == 1)
                _ban.GUID = "";

            if (!_rcon.PendingLeft)
            {
                _rcon.Ban(_ban);
            }
            else
            {
                if (MessageBox.Show("The player you were about to ban left the game.\r\nPress OK to ban him offline (GUID only) instead.", "Attention!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    _ban.Online = false;
                    _rcon.Ban(_ban);
                }
            }

            _rcon.Pending = "";
            _rcon.PendingLeft = false;

            Settings.Default.span = span.SelectedIndex;

            if (_ban.Online)
            {
                if (mode.SelectedIndex == 0)
                {
                    Settings.Default.banGUID = true;
                    Settings.Default.banIP = false;
                }
                else if (mode.SelectedIndex == 1)
                {
                    Settings.Default.banGUID = false;
                    Settings.Default.banIP = true;
                }
                else if (mode.SelectedIndex == 2)
                {
                    Settings.Default.banGUID = true;
                    Settings.Default.banIP = true;
                }
            }
            Settings.Default.Save();

            this.Close();
        }

        private void abort_Click(object sender, EventArgs e)
        { 
            this.Close();
        }

        private void duration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
