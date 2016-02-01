namespace DaRT
{
    partial class GUImessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUImessage));
            this.messageField = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.abort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // messageField
            // 
            this.messageField.Location = new System.Drawing.Point(12, 38);
            this.messageField.MaxLength = 400;
            this.messageField.Name = "messageField";
            this.messageField.Size = new System.Drawing.Size(360, 20);
            this.messageField.TabIndex = 0;
            this.messageField.Text = "Message";
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(107, 64);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 23);
            this.send.TabIndex = 1;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // abort
            // 
            this.abort.Location = new System.Drawing.Point(206, 64);
            this.abort.Name = "abort";
            this.abort.Size = new System.Drawing.Size(75, 23);
            this.abort.TabIndex = 2;
            this.abort.Text = "Abort";
            this.abort.UseVisualStyleBackColor = true;
            this.abort.Click += new System.EventHandler(this.abort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "What do you want to tell the player?";
            // 
            // GUImessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 112);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.abort);
            this.Controls.Add(this.send);
            this.Controls.Add(this.messageField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GUImessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Talk to player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GUImessage_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox messageField;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Button abort;
        private System.Windows.Forms.Label label1;
    }
}