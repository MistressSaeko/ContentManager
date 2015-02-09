using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ContentManager
{
    public partial class PathsDialog : Form
    {
        public PathsDialog()
        {
            InitializeComponent();
        }

        public string Runtime
        {
            get
            {
                return RuntimeBox.Text;
            }
        }

        public string Content
        {
            get
            {
                return ContentBox.Text;
            }
        }

        private void ContentExploreButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ContentFolder = new FolderBrowserDialog();

            if (ContentFolder.ShowDialog(this) == DialogResult.OK)
            {
                ContentBox.Text = ContentFolder.SelectedPath;
            }
        }

        private void RuntimeExploreButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog RuntimeFolder = new FolderBrowserDialog();

            if (RuntimeFolder.ShowDialog(this) == DialogResult.OK)
            {
                RuntimeBox.Text = RuntimeFolder.SelectedPath;
            }
        }
    }
}
