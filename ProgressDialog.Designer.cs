namespace ContentManager
{
    partial class ProgressDialog
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
            this.InstallingLabel = new System.Windows.Forms.Label();
            this.PercentMeter = new System.Windows.Forms.ProgressBar();
            this.PercentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InstallingLabel
            // 
            this.InstallingLabel.AutoSize = true;
            this.InstallingLabel.ForeColor = System.Drawing.Color.BlueViolet;
            this.InstallingLabel.Location = new System.Drawing.Point(4, 4);
            this.InstallingLabel.Name = "InstallingLabel";
            this.InstallingLabel.Size = new System.Drawing.Size(35, 13);
            this.InstallingLabel.TabIndex = 0;
            this.InstallingLabel.Text = "label1";
            // 
            // PercentMeter
            // 
            this.PercentMeter.ForeColor = System.Drawing.Color.BlueViolet;
            this.PercentMeter.Location = new System.Drawing.Point(4, 24);
            this.PercentMeter.Name = "PercentMeter";
            this.PercentMeter.Size = new System.Drawing.Size(368, 13);
            this.PercentMeter.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PercentMeter.TabIndex = 1;
            // 
            // PercentLabel
            // 
            this.PercentLabel.AutoSize = true;
            this.PercentLabel.ForeColor = System.Drawing.Color.BlueViolet;
            this.PercentLabel.Location = new System.Drawing.Point(380, 24);
            this.PercentLabel.Name = "PercentLabel";
            this.PercentLabel.Size = new System.Drawing.Size(35, 13);
            this.PercentLabel.TabIndex = 2;
            this.PercentLabel.Text = "label2";
            // 
            // ProgressDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 46);
            this.Controls.Add(this.PercentLabel);
            this.Controls.Add(this.PercentMeter);
            this.Controls.Add(this.InstallingLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProgressDialog";
            this.ShowInTaskbar = false;
            this.Text = "ProgressDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InstallingLabel;
        private System.Windows.Forms.ProgressBar PercentMeter;
        private System.Windows.Forms.Label PercentLabel;
    }
}