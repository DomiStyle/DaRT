namespace DaRT
{
    partial class GUImanualBans
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUImanualBans));
            this.label1 = new System.Windows.Forms.Label();
            this.ban = new System.Windows.Forms.Button();
            this.abort = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Paste your bans in the box below";
            // 
            // ban
            // 
            this.ban.Location = new System.Drawing.Point(217, 249);
            this.ban.Name = "ban";
            this.ban.Size = new System.Drawing.Size(75, 23);
            this.ban.TabIndex = 9;
            this.ban.Text = "Ban";
            this.ban.UseVisualStyleBackColor = true;
            this.ban.Click += new System.EventHandler(this.ban_Click);
            // 
            // abort
            // 
            this.abort.Location = new System.Drawing.Point(302, 249);
            this.abort.Name = "abort";
            this.abort.Size = new System.Drawing.Size(75, 23);
            this.abort.TabIndex = 10;
            this.abort.Text = "Abort";
            this.abort.UseVisualStyleBackColor = true;
            this.abort.Click += new System.EventHandler(this.abort_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(13, 25);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(565, 218);
            this.input.TabIndex = 11;
            this.input.Text = "";
            this.input.Enter += new System.EventHandler(this.input_Enter);
            // 
            // GUIbanGUIDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 284);
            this.Controls.Add(this.input);
            this.Controls.Add(this.abort);
            this.Controls.Add(this.ban);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GUIbanGUIDS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ban GUIDS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ban;
        private System.Windows.Forms.Button abort;
        private System.Windows.Forms.RichTextBox input;
    }
}