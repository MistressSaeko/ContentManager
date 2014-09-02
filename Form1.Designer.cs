namespace ContentInstaller
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.InstallButton = new System.Windows.Forms.Button();
            this.UninstallButton = new System.Windows.Forms.Button();
            this.PathsButton = new System.Windows.Forms.Button();
            this.ScanButton = new System.Windows.Forms.Button();
            this.ContentGenButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.PromoDisplay = new System.Windows.Forms.PictureBox();
            this.ContentView = new System.Windows.Forms.ListView();
            this.InstalledHeader = new System.Windows.Forms.ColumnHeader();
            this.SKUHeader = new System.Windows.Forms.ColumnHeader();
            this.PNHeader = new System.Windows.Forms.ColumnHeader();
            this.VendorHeader = new System.Windows.Forms.ColumnHeader();
            this.FigureHeader = new System.Windows.Forms.ColumnHeader();
            this.SizeHeader = new System.Windows.Forms.ColumnHeader();
            this.ContentList = new System.Windows.Forms.TreeView();
            this.ExtensionList = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PromoDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.04489F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.95511F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 487F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PromoDisplay, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ContentView, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ContentList, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.46771F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.53229F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1272, 573);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.InstallButton);
            this.flowLayoutPanel1.Controls.Add(this.UninstallButton);
            this.flowLayoutPanel1.Controls.Add(this.PathsButton);
            this.flowLayoutPanel1.Controls.Add(this.ScanButton);
            this.flowLayoutPanel1.Controls.Add(this.ContentGenButton);
            this.flowLayoutPanel1.Controls.Add(this.AboutButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 486);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(245, 84);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // InstallButton
            // 
            this.InstallButton.Location = new System.Drawing.Point(3, 3);
            this.InstallButton.Name = "InstallButton";
            this.InstallButton.Size = new System.Drawing.Size(75, 23);
            this.InstallButton.TabIndex = 0;
            this.InstallButton.Text = "Install";
            this.InstallButton.UseVisualStyleBackColor = true;
            this.InstallButton.Click += new System.EventHandler(this.InstallButton_Click);
            // 
            // UninstallButton
            // 
            this.UninstallButton.Location = new System.Drawing.Point(84, 3);
            this.UninstallButton.Name = "UninstallButton";
            this.UninstallButton.Size = new System.Drawing.Size(75, 23);
            this.UninstallButton.TabIndex = 1;
            this.UninstallButton.Text = "Uninstall";
            this.UninstallButton.UseVisualStyleBackColor = true;
            this.UninstallButton.Click += new System.EventHandler(this.UninstallButton_Click);
            // 
            // PathsButton
            // 
            this.PathsButton.Location = new System.Drawing.Point(165, 3);
            this.PathsButton.Name = "PathsButton";
            this.PathsButton.Size = new System.Drawing.Size(75, 23);
            this.PathsButton.TabIndex = 2;
            this.PathsButton.Text = "Paths";
            this.PathsButton.UseVisualStyleBackColor = true;
            this.PathsButton.Click += new System.EventHandler(this.PathsButton_Click);
            // 
            // ScanButton
            // 
            this.ScanButton.Location = new System.Drawing.Point(3, 32);
            this.ScanButton.Name = "ScanButton";
            this.ScanButton.Size = new System.Drawing.Size(75, 23);
            this.ScanButton.TabIndex = 3;
            this.ScanButton.Text = "Scan";
            this.ScanButton.UseVisualStyleBackColor = true;
            this.ScanButton.Click += new System.EventHandler(this.ScanButton_Click);
            // 
            // ContentGenButton
            // 
            this.ContentGenButton.Location = new System.Drawing.Point(84, 32);
            this.ContentGenButton.Name = "ContentGenButton";
            this.ContentGenButton.Size = new System.Drawing.Size(157, 23);
            this.ContentGenButton.TabIndex = 4;
            this.ContentGenButton.Text = "Generate Content File";
            this.ContentGenButton.UseVisualStyleBackColor = true;
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(3, 61);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(237, 23);
            this.AboutButton.TabIndex = 5;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // PromoDisplay
            // 
            this.PromoDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PromoDisplay.Location = new System.Drawing.Point(787, 3);
            this.PromoDisplay.Name = "PromoDisplay";
            this.tableLayoutPanel1.SetRowSpan(this.PromoDisplay, 2);
            this.PromoDisplay.Size = new System.Drawing.Size(482, 567);
            this.PromoDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PromoDisplay.TabIndex = 0;
            this.PromoDisplay.TabStop = false;
            // 
            // ContentView
            // 
            this.ContentView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ContentView.AllowColumnReorder = true;
            this.ContentView.CheckBoxes = true;
            this.ContentView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.InstalledHeader,
            this.SKUHeader,
            this.PNHeader,
            this.VendorHeader,
            this.FigureHeader,
            this.SizeHeader});
            this.ContentView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentView.Location = new System.Drawing.Point(254, 3);
            this.ContentView.Name = "ContentView";
            this.tableLayoutPanel1.SetRowSpan(this.ContentView, 2);
            this.ContentView.Size = new System.Drawing.Size(527, 567);
            this.ContentView.TabIndex = 2;
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
            // PNHeader
            // 
            this.PNHeader.Text = "Product Name";
            this.PNHeader.Width = 109;
            // 
            // VendorHeader
            // 
            this.VendorHeader.Text = "Vendor";
            this.VendorHeader.Width = 87;
            // 
            // FigureHeader
            // 
            this.FigureHeader.Text = "Figure";
            // 
            // SizeHeader
            // 
            this.SizeHeader.Text = "File Size";
            this.SizeHeader.Width = 61;
            // 
            // ContentList
            // 
            this.ContentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentList.HotTracking = true;
            this.ContentList.ImageIndex = 0;
            this.ContentList.ImageList = this.ExtensionList;
            this.ContentList.Location = new System.Drawing.Point(3, 3);
            this.ContentList.Name = "ContentList";
            this.ContentList.SelectedImageIndex = 0;
            this.ContentList.Size = new System.Drawing.Size(245, 477);
            this.ContentList.TabIndex = 3;
            this.ContentList.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ContentList_NodeMouseClick);
            // 
            // ExtensionList
            // 
            this.ExtensionList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ExtensionList.ImageStream")));
            this.ExtensionList.TransparentColor = System.Drawing.Color.Transparent;
            this.ExtensionList.Images.SetKeyName(0, "file_extension_bmp.png");
            this.ExtensionList.Images.SetKeyName(1, "file_extension_jpeg.png");
            this.ExtensionList.Images.SetKeyName(2, "file_extension_jpg.png");
            this.ExtensionList.Images.SetKeyName(3, "file_extension_png.png");
            this.ExtensionList.Images.SetKeyName(4, "file_extension_tif.png");
            this.ExtensionList.Images.SetKeyName(5, "file_extension_zip.png");
            this.ExtensionList.Images.SetKeyName(6, "folder.png");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 573);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Content Installer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PromoDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox PromoDisplay;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button InstallButton;
        private System.Windows.Forms.Button UninstallButton;
        private System.Windows.Forms.Button PathsButton;
        private System.Windows.Forms.Button ScanButton;
        private System.Windows.Forms.ListView ContentView;
        private System.Windows.Forms.ColumnHeader PNHeader;
        private System.Windows.Forms.ColumnHeader VendorHeader;
        private System.Windows.Forms.ColumnHeader FigureHeader;
        private System.Windows.Forms.ColumnHeader SizeHeader;
        private System.Windows.Forms.ColumnHeader SKUHeader;
        private System.Windows.Forms.ColumnHeader InstalledHeader;
        private System.Windows.Forms.TreeView ContentList;
        private System.Windows.Forms.Button ContentGenButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.ImageList ExtensionList;

    }
}

