using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Mono.Data.Sqlite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DaRT
{
    public partial class GUIhosts : Form
    {
        private GUImain gui;
        private SqliteConnection _connection;
        private SqliteCommand _command;

        public GUIhosts(GUImain gui, SqliteConnection connection, SqliteCommand command)
        {
            InitializeComponent();
            InitializeList();

            this.gui = gui;
            _connection = connection;
            _command = command;

            using (_command = new SqliteCommand("SELECT host, port, password FROM hosts ORDER BY id DESC", _connection))
            {

                using (SqliteDataReader reader = _command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        String host = gui.GetSafeString(reader, 0);
                        String port = gui.GetSafeString(reader, 1);
                        String password = gui.GetSafeString(reader, 2);

                        String[] items = { host, port, password };
                        ListViewItem item = new ListViewItem(items);
                        list.Items.Add(item);
                    }
                }
            }
        }

        ContextMenuStrip menu = null;
        private void InitializeList()
        {
            menu = new ContextMenuStrip();
            menu.Items.Add("Copy");
            (menu.Items[0] as ToolStripMenuItem).DropDownItems.Add("Host", null, copyHost_click);
            (menu.Items[0] as ToolStripMenuItem).DropDownItems.Add("Port", null, copyPort_click);
            (menu.Items[0] as ToolStripMenuItem).DropDownItems.Add("Both", null, copyBoth_click);
            menu.Items.Add("Delete", null, delete_click);

            list.Columns.Add("IP", 150);
            list.Columns.Add("Port", 100);
            list.Columns.Add("Password", 150);
        }

        private void copyHost_click(object sender, EventArgs e)
        {
            ListViewItem item = list.SelectedItems[0];
            String host = item.SubItems[0].Text;
            try
            {
                gui.Invoke((MethodInvoker)delegate
                {
                    Clipboard.SetText(host);
                });
            }
            catch
            {
                gui.Invoke((MethodInvoker)delegate
                {
                    gui.Log("Error while accessing clipboard!", LogType.Debug, false);
                });
            }
        }
        private void copyPort_click(object sender, EventArgs e)
        {
            ListViewItem item = list.SelectedItems[0];
            String port = item.SubItems[1].Text;
            try
            {
                gui.Invoke((MethodInvoker)delegate
                {
                    Clipboard.SetText(port);
                });
            }
            catch
            {
                gui.Invoke((MethodInvoker)delegate
                {
                    gui.Log("Error while accessing clipboard!", LogType.Debug, false);
                });
            }
        }
        private void copyBoth_click(object sender, EventArgs e)
        {
            ListViewItem item = list.SelectedItems[0];
            String host = item.SubItems[0].Text;
            String port = item.SubItems[1].Text;
            String both = host + ":" + port;
            try
            {
                gui.Invoke((MethodInvoker)delegate
                {
                    Clipboard.SetText(both);
                });
            }
            catch
            {
                gui.Invoke((MethodInvoker)delegate
                {
                    gui.Log("Error while accessing clipboard!", LogType.Debug, false);
                });
            }
        }
        private void delete_click(object sender, EventArgs e)
        {
            using (_command = new SqliteCommand("DELETE FROM hosts WHERE host = @host AND port = @port", _connection))
            {
                ListViewItem item = list.SelectedItems[0];
                list.Items.Remove(item);
                String host = item.SubItems[0].Text;
                String port = item.SubItems[1].Text;
                _command.Parameters.Clear();
                _command.Parameters.Add(new SqliteParameter("@host", host));
                _command.Parameters.Add(new SqliteParameter("@port", port));
                _command.ExecuteNonQuery();
            }
        }

        private void load_Click(object sender, EventArgs e)
        {
            if (!(list.SelectedItems.Count == 0))
            {
                ListViewItem item = list.SelectedItems[0];
                String host = item.SubItems[0].Text;
                String port = item.SubItems[1].Text;
                String password = item.SubItems[2].Text;

                gui.Invoke((MethodInvoker)delegate
                {
                    gui.host.Text = host;
                    gui.port.Text = port;
                    gui.password.Text = password;
                });

                this.Close();
            }
            else
            {
                gui.Log("Please select a host first.", LogType.Console, false);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GUIhosts_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void list_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem Item = default(ListViewItem);
                {
                    Item = list.GetItemAt(e.Location.X, e.Location.Y);
                    if ((Item != null))
                    {
                        menu.Show(Cursor.Position);
                    }
                }
            }
        }
    }
}
