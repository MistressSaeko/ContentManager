using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ContentManager
{
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();

            AppNameBox.Text = Application.ProductName;
            AppVersionBox.Text = Application.ProductVersion;
            AppVendorBox.Text = Application.CompanyName;
        }
    }
}
