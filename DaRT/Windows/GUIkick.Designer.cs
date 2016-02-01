namespace DaRT
{
    partial class GUIkick
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIkick));
            this.kickButton = new System.Windows.Forms.Button();
            this.abort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reason = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // kickButton
            // 
            this.kickButton.Location = new System.Drawing.Point(105, 76);
            this.kickButton.Name = "kickButton";
            this.kickButton.Size = new System.Drawing.Size(75, 23);
            this.kickButton.TabIndex = 0;
            this.kickButton.Text = "Kick";
            this.kickButton.UseVisualStyleBackColor = true;
            this.kickButton.Click += new System.EventHandler(this.kick_Click);
            // 
            // abort
            // 
            this.abort.Location = new System.Drawing.Point(208, 76);
            this.abort.Name = "abort";
            this.abort.Size = new System.Drawing.Size(75, 23);
            this.abort.TabIndex = 1;
            this.abort.Text = "Abort";
            this.abort.UseVisualStyleBackColor = true;
            this.abort.Click += new System.EventHandler(this.abort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Why do you want to kick this player?";
            // 
            // reason
            // 
            this.reason.Location = new System.Drawing.Point(39, 38);
            this.reason.Name = "reason";
            this.reason.Size = new System.Drawing.Size(306, 20);
            this.reason.TabIndex = 3;
            this.reason.Text = "Admin Kick";
            // 
            // GUIkick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 112);
            this.Controls.Add(this.reason);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.abort);
            this.Controls.Add(this.kickButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GUIkick";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kick Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GUIkick_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kickButton;
        private System.Windows.Forms.Button abort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox reason;
    }
}