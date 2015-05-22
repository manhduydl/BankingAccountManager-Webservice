namespace ActivityMonitor
{
    partial class frmAutoLogout
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
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnContinue
            // 
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Location = new System.Drawing.Point(157, 136);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(108, 28);
            this.btnContinue.TabIndex = 5;
            this.btnContinue.Text = "Resume";
            this.btnContinue.UseVisualStyleBackColor = true;
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.Location = new System.Drawing.Point(113, 95);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(152, 13);
            this.lblCountdown.TabIndex = 4;
            this.lblCountdown.Text = "You have 5 minutes remaining.";
            // 
            // lblWarning
            // 
            this.lblWarning.Location = new System.Drawing.Point(113, 28);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(292, 42);
            this.lblWarning.TabIndex = 3;
            this.lblWarning.Text = "You have been inactive for too long.  You will be logged-out of the application i" +
    "f you have been idle for more than 40 minutes.  Any unsaved work will be lost.";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ActivityMonitor.Properties.Resources.advertising_48;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(22, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(71, 56);
            this.panel1.TabIndex = 6;
            // 
            // frmAutoLogout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 181);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.lblWarning);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAutoLogout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAutoLogout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Panel panel1;
    }
}