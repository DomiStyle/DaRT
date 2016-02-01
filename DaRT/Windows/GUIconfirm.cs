using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DaRT
{
    public partial class GUIconfirm : Form
    {
        private GUImain gui;
        private RCon rcon;

        public GUIconfirm(GUImain gui, RCon rcon)
        {
            InitializeComponent();

            this.gui = gui;
            this.rcon = rcon;
        }

        private void shutdown_Click(object sender, EventArgs e)
        {
            rcon.shutdown();
            this.Close();
        }

        private void abort_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GUIconfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            gui.Invoke((MethodInvoker)delegate
            {
                gui.Enabled = true;
            });
        }
    }
}
