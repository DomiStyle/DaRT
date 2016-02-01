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
    public partial class GUImessage : Form
    {
        private GUImain gui = null;
        private int id = 0;
        private String name;

        public GUImessage(GUImain gui, int id, String name)
        {
            InitializeComponent();

            this.gui = gui;
            this.id = id;
            this.name = name;
            this.Text = "Talk to " + name;
        }

        private void send_Click(object sender, EventArgs e)
        {
            Message message = new Message(id, name, messageField.Text);
            gui.say(message);

            this.Close();
        }

        private void abort_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GUImessage_FormClosing(object sender, FormClosingEventArgs e)
        {
            gui.Invoke((MethodInvoker)delegate
            {
                gui.Enabled = true;
            });
        }
    }
}
