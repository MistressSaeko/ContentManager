namespace ContentManager
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AppNameBox = new System.Windows.Forms.TextBox();
            this.AppVersionBox = new System.Windows.Forms.TextBox();
            this.AppVendorBox = new System.Windows.Forms.TextBox();
            this.SexyButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.19693F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.80307F));
            this.tableLayoutPanel1.Controls.Add(this.AppNameBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.AppVersionBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.AppVendorBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.SexyButton, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.143323F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.143323F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.794788F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.47231F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.120522F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(391, 307);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // AppNameBox
            // 
            this.AppNameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppNameBox.Location = new System.Drawing.Point(210, 3);
            this.AppNameBox.Name = "AppNameBox";
            this.AppNameBox.ReadOnly = true;
            this.AppNameBox.Size = new System.Drawing.Size(178, 20);
            this.AppNameBox.TabIndex = 0;
            // 
            // AppVersionBox
            // 
            this.AppVersionBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppVersionBox.Location = new System.Drawing.Point(210, 28);
            this.AppVersionBox.Name = "AppVersionBox";
            this.AppVersionBox.ReadOnly = true;
            this.AppVersionBox.Size = new System.Drawing.Size(178, 20);
            this.AppVersionBox.TabIndex = 1;
            // 
            // AppVendorBox
            // 
            this.AppVendorBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppVendorBox.Location = new System.Drawing.Point(210, 53);
            this.AppVendorBox.Name = "AppVendorBox";
            this.AppVendorBox.ReadOnly = true;
            this.AppVendorBox.Size = new System.Drawing.Size(178, 20);
            this.AppVendorBox.TabIndex = 2;
            // 
            // SexyButton
            // 
            this.SexyButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SexyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SexyButton.Image = global::ContentManager.Properties.Resources.button;
            this.SexyButton.Location = new System.Drawing.Point(210, 281);
            this.SexyButton.Name = "SexyButton";
            this.SexyButton.Size = new System.Drawing.Size(178, 23);
            this.SexyButton.TabIndex = 3;
            this.SexyButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ContentManager.Properties.Resources.selfie;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox1, 5);
            this.pictureBox1.Size = new System.Drawing.Size(201, 301);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // AboutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 307);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutDialog";
            this.ShowInTaskbar = false;
            this.Text = "About Content Manager";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox AppNameBox;
        private System.Windows.Forms.TextBox AppVersionBox;
        private System.Windows.Forms.TextBox AppVendorBox;
        private System.Windows.Forms.Button SexyButton;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}