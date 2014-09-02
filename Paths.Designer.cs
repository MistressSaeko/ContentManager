namespace ContentInstaller
{
    partial class Paths
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
            this.ContentLabel = new System.Windows.Forms.Label();
            this.ContentEdit = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.RuntimeEdit = new System.Windows.Forms.TextBox();
            this.BrowseButton2 = new System.Windows.Forms.Button();
            this.RuntimeLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ContentLabel
            // 
            this.ContentLabel.AutoSize = true;
            this.ContentLabel.Location = new System.Drawing.Point(6, 8);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.Size = new System.Drawing.Size(79, 13);
            this.ContentLabel.TabIndex = 0;
            this.ContentLabel.Text = "Content Folder:";
            // 
            // ContentEdit
            // 
            this.ContentEdit.Location = new System.Drawing.Point(92, 4);
            this.ContentEdit.Name = "ContentEdit";
            this.ContentEdit.Size = new System.Drawing.Size(376, 20);
            this.ContentEdit.TabIndex = 1;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(472, 4);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 20);
            this.BrowseButton.TabIndex = 2;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // RuntimeEdit
            // 
            this.RuntimeEdit.Location = new System.Drawing.Point(92, 28);
            this.RuntimeEdit.Name = "RuntimeEdit";
            this.RuntimeEdit.Size = new System.Drawing.Size(376, 20);
            this.RuntimeEdit.TabIndex = 3;
            // 
            // BrowseButton2
            // 
            this.BrowseButton2.Location = new System.Drawing.Point(472, 28);
            this.BrowseButton2.Name = "BrowseButton2";
            this.BrowseButton2.Size = new System.Drawing.Size(75, 20);
            this.BrowseButton2.TabIndex = 4;
            this.BrowseButton2.Text = "Browse";
            this.BrowseButton2.UseVisualStyleBackColor = true;
            this.BrowseButton2.Click += new System.EventHandler(this.BrowseButton2_Click);
            // 
            // RuntimeLabel
            // 
            this.RuntimeLabel.AutoSize = true;
            this.RuntimeLabel.Location = new System.Drawing.Point(4, 32);
            this.RuntimeLabel.Name = "RuntimeLabel";
            this.RuntimeLabel.Size = new System.Drawing.Size(81, 13);
            this.RuntimeLabel.TabIndex = 5;
            this.RuntimeLabel.Text = "Runtime Folder:";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(472, 56);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 6;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(388, 56);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Paths
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 85);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.RuntimeLabel);
            this.Controls.Add(this.BrowseButton2);
            this.Controls.Add(this.RuntimeEdit);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.ContentEdit);
            this.Controls.Add(this.ContentLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Paths";
            this.ShowInTaskbar = false;
            this.Text = "Paths";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ContentLabel;
        private System.Windows.Forms.TextBox ContentEdit;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.TextBox RuntimeEdit;
        private System.Windows.Forms.Button BrowseButton2;
        private System.Windows.Forms.Label RuntimeLabel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
    }
}