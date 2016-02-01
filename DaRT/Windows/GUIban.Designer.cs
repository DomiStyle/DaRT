namespace DaRT
{
    partial class GUIban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIban));
            this.label1 = new System.Windows.Forms.Label();
            this.reason = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.duration = new System.Windows.Forms.TextBox();
            this.banButton = new System.Windows.Forms.Button();
            this.abort = new System.Windows.Forms.Button();
            this.span = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mode = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Why do you want to ban this player?";
            // 
            // reason
            // 
            this.reason.Location = new System.Drawing.Point(12, 32);
            this.reason.Name = "reason";
            this.reason.Size = new System.Drawing.Size(324, 20);
            this.reason.TabIndex = 7;
            this.reason.Text = "Admin Ban";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ban duration:";
            // 
            // duration
            // 
            this.duration.Location = new System.Drawing.Point(128, 61);
            this.duration.Name = "duration";
            this.duration.ShortcutsEnabled = false;
            this.duration.Size = new System.Drawing.Size(68, 20);
            this.duration.TabIndex = 9;
            this.duration.Text = "0";
            this.duration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.duration_KeyPress);
            // 
            // banButton
            // 
            this.banButton.Location = new System.Drawing.Point(12, 124);
            this.banButton.Name = "banButton";
            this.banButton.Size = new System.Drawing.Size(220, 23);
            this.banButton.TabIndex = 10;
            this.banButton.Text = "Ban";
            this.banButton.UseVisualStyleBackColor = true;
            this.banButton.Click += new System.EventHandler(this.ban_Click);
            // 
            // abort
            // 
            this.abort.Location = new System.Drawing.Point(238, 124);
            this.abort.Name = "abort";
            this.abort.Size = new System.Drawing.Size(98, 23);
            this.abort.TabIndex = 11;
            this.abort.Text = "Abort";
            this.abort.UseVisualStyleBackColor = true;
            this.abort.Click += new System.EventHandler(this.abort_Click);
            // 
            // span
            // 
            this.span.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.span.FormattingEnabled = true;
            this.span.Items.AddRange(new object[] {
            "minutes",
            "hours",
            "days",
            "weeks"});
            this.span.Location = new System.Drawing.Point(202, 61);
            this.span.Name = "span";
            this.span.Size = new System.Drawing.Size(95, 21);
            this.span.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ban type:";
            // 
            // mode
            // 
            this.mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mode.FormattingEnabled = true;
            this.mode.Items.AddRange(new object[] {
            "GUID",
            "IP",
            "GUID & IP"});
            this.mode.Location = new System.Drawing.Point(128, 87);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(95, 21);
            this.mode.TabIndex = 16;
            // 
            // GUIban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 159);
            this.Controls.Add(this.mode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.span);
            this.Controls.Add(this.abort);
            this.Controls.Add(this.banButton);
            this.Controls.Add(this.duration);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reason);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GUIban";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ban player";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox reason;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox duration;
        private System.Windows.Forms.Button banButton;
        private System.Windows.Forms.Button abort;
        private System.Windows.Forms.ComboBox span;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox mode;
    }
}