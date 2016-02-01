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
    public partial class GUIkick : Form
    {
        private GUImain gui = null;
        private int id = 0;
        private String name = "";

        public GUIkick(GUImain gui, int id, String name)
        {
            InitializeComponent();

            this.gui = gui;
            this.id = id;
            this.name = name;
            this.Text = "Kick " + name;
        }

        private void kick_Click(object sender, EventArgs e)
        {
            Kick kick = new Kick(id, name, reason.Text);

            gui.kick(kick);

            this.Close();
        }

        private void abort_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GUIkick_FormClosing(object sender, FormClosingEventArgs e)
        {
            gui.Invoke((MethodInvoker)delegate
            {
                gui.Enabled = true;
            });
        }
    }
}
