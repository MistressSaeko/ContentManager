namespace ContentManager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ExitToolButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.InstallToolButton = new System.Windows.Forms.ToolStripButton();
            this.UninstallToolButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.GenerateXMLToolButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ScanToolButton = new System.Windows.Forms.ToolStripButton();
            this.PathsToolButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutToolButton = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ContentView = new System.Windows.Forms.ListView();
            this.InstalledHeader = new System.Windows.Forms.ColumnHeader();
            this.SKUHeader = new System.Windows.Forms.ColumnHeader();
            this.ProductHeader = new System.Windows.Forms.ColumnHeader();
            this.VendorHeader = new System.Windows.Forms.ColumnHeader();
            this.FigureHeader = new System.Windows.Forms.ColumnHeader();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolButton,
            this.toolStripSeparator1,
            this.InstallToolButton,
            this.UninstallToolButton,
            this.toolStripSeparator2,
            this.GenerateXMLToolButton,
            this.toolStripSeparator4,
            this.ScanToolButton,
            this.PathsToolButton,
            this.toolStripSeparator3,
            this.AboutToolButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1016, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ExitToolButton
            // 
            this.ExitToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExitToolButton.Image = global::ContentManager.Properties.Resources.female;
            this.ExitToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExitToolButton.Name = "ExitToolButton";
            this.ExitToolButton.Size = new System.Drawing.Size(36, 36);
            this.ExitToolButton.Text = "toolStripButton1";
            this.ExitToolButton.ToolTipText = "Quit";
            this.ExitToolButton.Click += new System.EventHandler(this.ExitToolButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // InstallToolButton
            // 
            this.InstallToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.InstallToolButton.Image = global::ContentManager.Properties.Resources.arrow_down;
            this.InstallToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InstallToolButton.Name = "InstallToolButton";
            this.InstallToolButton.Size = new System.Drawing.Size(36, 36);
            this.InstallToolButton.Text = "toolStripButton2";
            this.InstallToolButton.ToolTipText = "Install content";
            this.InstallToolButton.Click += new System.EventHandler(this.InstallToolButton_Click);
            // 
            // UninstallToolButton
            // 
            this.UninstallToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UninstallToolButton.Image = global::ContentManager.Properties.Resources.arrow_up;
            this.UninstallToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UninstallToolButton.Name = "UninstallToolButton";
            this.UninstallToolButton.Size = new System.Drawing.Size(36, 36);
            this.UninstallToolButton.Text = "toolStripButton3";
            this.UninstallToolButton.ToolTipText = "Uninstall content";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // GenerateXMLToolButton
            // 
            this.GenerateXMLToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GenerateXMLToolButton.Image = global::ContentManager.Properties.Resources.xhtml;
            this.GenerateXMLToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GenerateXMLToolButton.Name = "GenerateXMLToolButton";
            this.GenerateXMLToolButton.Size = new System.Drawing.Size(36, 36);
            this.GenerateXMLToolButton.Text = "toolStripButton7";
            this.GenerateXMLToolButton.ToolTipText = "Generate an XML content file";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // ScanToolButton
            // 
            this.ScanToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ScanToolButton.Image = global::ContentManager.Properties.Resources.folder_explore;
            this.ScanToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ScanToolButton.Name = "ScanToolButton";
            this.ScanToolButton.Size = new System.Drawing.Size(36, 36);
            this.ScanToolButton.Text = "toolStripButton4";
            this.ScanToolButton.ToolTipText = "Scan folder for new content";
            this.ScanToolButton.Click += new System.EventHandler(this.ScanToolButton_Click);
            // 
            // PathsToolButton
            // 
            this.PathsToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PathsToolButton.Image = global::ContentManager.Properties.Resources.folder;
            this.PathsToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PathsToolButton.Name = "PathsToolButton";
            this.PathsToolButton.Size = new System.Drawing.Size(36, 36);
            this.PathsToolButton.Text = "toolStripButton5";
            this.PathsToolButton.ToolTipText = "Setup paths";
            this.PathsToolButton.Click += new System.EventHandler(this.PathsToolButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // AboutToolButton
            // 
            this.AboutToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AboutToolButton.Image = global::ContentManager.Properties.Resources.help;
            this.AboutToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AboutToolButton.Name = "AboutToolButton";
            this.AboutToolButton.Size = new System.Drawing.Size(36, 36);
            this.AboutToolButton.Text = "toolStripButton6";
            this.AboutToolButton.ToolTipText = "About";
            this.AboutToolButton.Click += new System.EventHandler(this.AboutToolButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.19685F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.80315F));
            this.tableLayoutPanel1.Controls.Add(this.ContentView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1016, 534);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // ContentView
            // 
            this.ContentView.CheckBoxes = true;
            this.ContentView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.InstalledHeader,
            this.SKUHeader,
            this.ProductHeader,
            this.VendorHeader,
            this.FigureHeader});
            this.ContentView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ContentView.Location = new System.Drawing.Point(3, 3);
            this.ContentView.MultiSelect = false;
            this.ContentView.Name = "ContentView";
            this.ContentView.Size = new System.Drawing.Size(503, 528);
            this.ContentView.TabIndex = 0;
            this.ContentView.UseCompatibleStateImageBehavior = false;
            this.ContentView.View = System.Windows.Forms.View.Details;
            // 
            // InstalledHeader
            // 
            this.InstalledHeader.Text = "Installed";
            // 
            // SKUHeader
            // 
            this.SKUHeader.Text = "SKU";
            // 
            // ProductHeader
            // 
            this.ProductHeader.Text = "Product";
            this.ProductHeader.Width = 148;
            // 
            // VendorHeader
            // 
            this.VendorHeader.Text = "Vendor";
            // 
            // FigureHeader
            // 
            this.FigureHeader.Text = "Figure";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(512, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(501, 528);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 573);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Content Manager";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ExitToolButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton InstallToolButton;
        private System.Windows.Forms.ToolStripButton UninstallToolButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ScanToolButton;
        private System.Windows.Forms.ToolStripButton PathsToolButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton AboutToolButton;
        private System.Windows.Forms.ToolStripButton GenerateXMLToolButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView ContentView;
        private System.Windows.Forms.ColumnHeader InstalledHeader;
        private System.Windows.Forms.ColumnHeader SKUHeader;
        private System.Windows.Forms.ColumnHeader ProductHeader;
        private System.Windows.Forms.ColumnHeader VendorHeader;
        private System.Windows.Forms.ColumnHeader FigureHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

