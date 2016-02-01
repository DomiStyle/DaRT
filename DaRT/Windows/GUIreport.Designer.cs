namespace DaRT
{
    partial class GUIreport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIreport));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reportButton = new System.Windows.Forms.Button();
            this.abort = new System.Windows.Forms.Button();
            this.agree = new System.Windows.Forms.CheckBox();
            this.reason = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please explain why you want to report this player. (required)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Remember: Invalid reports will get your server blacklisted.";
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(156, 137);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(75, 23);
            this.reportButton.TabIndex = 2;
            this.reportButton.Text = "Report";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.report_Click);
            // 
            // abort
            // 
            this.abort.Location = new System.Drawing.Point(239, 137);
            this.abort.Name = "abort";
            this.abort.Size = new System.Drawing.Size(75, 23);
            this.abort.TabIndex = 3;
            this.abort.Text = "Abort";
            this.abort.UseVisualStyleBackColor = true;
            this.abort.Click += new System.EventHandler(this.abort_Click);
            // 
            // agree
            // 
            this.agree.AutoSize = true;
            this.agree.Location = new System.Drawing.Point(185, 102);
            this.agree.Name = "agree";
            this.agree.Size = new System.Drawing.Size(106, 17);
            this.agree.TabIndex = 4;
            this.agree.Text = "I agree (required)";
            this.agree.UseVisualStyleBackColor = true;
            // 
            // reason
            // 
            this.reason.Location = new System.Drawing.Point(34, 52);
            this.reason.Name = "reason";
            this.reason.Size = new System.Drawing.Size(400, 20);
            this.reason.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "You can get the bans.txt HERE.";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(153, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(161, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Reporting a player to DaRTBans";
            // 
            // GUIreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 184);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reason);
            this.Controls.Add(this.agree);
            this.Controls.Add(this.abort);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GUIreport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporting player to DaRTBans";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GUIreport_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button abort;
        private System.Windows.Forms.CheckBox agree;
        private System.Windows.Forms.TextBox reason;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label16;
    }
}