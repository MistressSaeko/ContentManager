namespace ContentInstaller
{
    partial class AboutDialog
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CreditsBox = new System.Windows.Forms.RichTextBox();
            this.CompanyEdit = new System.Windows.Forms.TextBox();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.AppEdit = new System.Windows.Forms.TextBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.AutoScrollMinSize = new System.Drawing.Size(200, 300);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CreditsBox);
            this.splitContainer1.Panel2.Controls.Add(this.CompanyEdit);
            this.splitContainer1.Panel2.Controls.Add(this.ButtonOK);
            this.splitContainer1.Panel2.Controls.Add(this.AppEdit);
            this.splitContainer1.Size = new System.Drawing.Size(384, 300);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ContentInstaller.Properties.Resources.selfie;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 300);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CreditsBox
            // 
            this.CreditsBox.Location = new System.Drawing.Point(4, 52);
            this.CreditsBox.Name = "CreditsBox";
            this.CreditsBox.ReadOnly = true;
            this.CreditsBox.Size = new System.Drawing.Size(172, 220);
            this.CreditsBox.TabIndex = 3;
            this.CreditsBox.Text = "Primary Programmer: April Horne";
            // 
            // CompanyEdit
            // 
            this.CompanyEdit.Location = new System.Drawing.Point(4, 28);
            this.CompanyEdit.Name = "CompanyEdit";
            this.CompanyEdit.ReadOnly = true;
            this.CompanyEdit.Size = new System.Drawing.Size(172, 20);
            this.CompanyEdit.TabIndex = 2;
            this.CompanyEdit.Text = "Copyright (C) 2014 Silky Softworks";
            // 
            // ButtonOK
            // 
            this.ButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOK.Image = global::ContentInstaller.Properties.Resources.button;
            this.ButtonOK.Location = new System.Drawing.Point(4, 276);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(172, 23);
            this.ButtonOK.TabIndex = 1;
            this.ButtonOK.UseVisualStyleBackColor = true;
            // 
            // AppEdit
            // 
            this.AppEdit.Location = new System.Drawing.Point(4, 4);
            this.AppEdit.Name = "AppEdit";
            this.AppEdit.ReadOnly = true;
            this.AppEdit.Size = new System.Drawing.Size(172, 20);
            this.AppEdit.TabIndex = 0;
            this.AppEdit.Text = "Content Installer";
            // 
            // AboutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 300);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutDialog";
            this.ShowInTaskbar = false;
            this.Text = "AboutDialog";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.TextBox AppEdit;
        private System.Windows.Forms.RichTextBox CreditsBox;
        private System.Windows.Forms.TextBox CompanyEdit;

    }
}