using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ContentInstaller
{
    public partial class Paths : Form
    {
        private string mRuntime;

        public Paths()
        {
            InitializeComponent();
        }
         
        public string Runtime
        {
            get 
            {
               return mRuntime;
            }
        }

        public string Content
        {
            get
            {
                return ContentEdit.Text;
            }
            set
            {
                return ContentEdit.Text;
            }
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog cnt = new FolderBrowserDialog();
            if (cnt.ShowDialog(this) == DialogResult.OK)
            {
                ContentEdit.Text = cnt.SelectedPath;
            }
        }

        private void BrowseButton2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog rnt = new FolderBrowserDialog();
            if (rnt.ShowDialog(this) == DialogResult.OK)
            {
                RuntimeEdit.Text = rnt.SelectedPath;
                mRuntime = RuntimeEdit.Text;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
