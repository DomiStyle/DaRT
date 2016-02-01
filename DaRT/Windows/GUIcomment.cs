using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Mono.Data.Sqlite;

namespace DaRT
{
    public partial class GUIcomment : Form
    {
        private GUImain gui = null;
        private SqliteConnection connection = null;
        private String guid = "";
        private String mode = "";

        public GUIcomment()
        {
            InitializeComponent();
        }
        public void Comment(GUImain gui, SqliteConnection connection, String name, String guid, String mode)
        {
            this.gui = gui;
            this.connection = connection;
            this.Text = "Comment " + name;
            this.guid = guid;
            this.mode = mode;

            SqliteCommand command = new SqliteCommand(connection);
            command.CommandText = "SELECT comment FROM comments WHERE guid = @guid";
            command.Parameters.Add(new SqliteParameter("@guid", guid));

            SqliteDataReader reader = command.ExecuteReader();

            if (reader.Read())
                input.Text = gui.GetSafeString(reader, 0);

            reader.Close();
            reader.Dispose();
            command.Dispose();
        }

        private void apply_Click(object sender, EventArgs e)
        {
            SqliteCommand command = new SqliteCommand(connection);
            String date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            command.CommandText = "INSERT OR REPLACE INTO comments (guid, comment, date) VALUES (@guid, @comment, @date)";
            command.Parameters.Add(new SqliteParameter("@guid", guid));
            command.Parameters.Add(new SqliteParameter("@comment", input.Text));
            command.Parameters.Add(new SqliteParameter("@date", date));
            command.ExecuteNonQuery();

            command.Dispose();

            if (mode == "players")
            {
                Thread thread = new Thread(new ThreadStart(gui.thread_Player));
                thread.IsBackground = true;
                thread.Start();
            }
            else if (mode == "bans")
            {
                Thread thread = new Thread(new ThreadStart(gui.thread_Bans));
                thread.IsBackground = true;
                thread.Start();
            }
            else if (mode == "player database")
            {
                Thread thread = new Thread(new ThreadStart(gui.thread_Database));
                thread.IsBackground = true;
                thread.Start();
            }

            this.Close();
        }

        private void GUIcomment_FormClosing(object sender, FormClosingEventArgs e)
        {
            gui.Invoke((MethodInvoker)delegate
            {
                gui.Enabled = true;
            });
        }
    }
}
