using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;

namespace ContentManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitToolButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutToolButton_Click(object sender, EventArgs e)
        {
            AboutDialog sexy = new AboutDialog();
            sexy.ShowDialog(this);
        }

        private void PathsToolButton_Click(object sender, EventArgs e)
        {
            PathsDialog paths = new PathsDialog();
            ListViewItem Item = null;
            ListViewItem.ListViewSubItem[] PoserContent;
            ContentView.Items.Clear();
            DirectoryInfo DirInfo = new DirectoryInfo(@"\Silky Softworks\Content Manager\Content");

            DialogResult DlgResult = paths.ShowDialog(this);
            if (DlgResult == DialogResult.OK)
            {
                foreach (FileInfo file in DirInfo.GetFiles())
                {
                    Item = new ListViewItem(file.Name);
                    PoserContent = new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(Item, "Content"), new ListViewItem.ListViewSubItem(Item, file.LastAccessTime.ToShortDateString()) };
                    Item.SubItems.AddRange(PoserContent);
                    ContentView.Items.Add(paths.Content);
                }
            }
            else
            {
                paths.Close();
            }
        }

        private void InstallToolButton_Click(object sender, EventArgs e)
        {
            ProgressDialog Install = new ProgressDialog();
            Install.Text = "Installing Content";
        }

        private void ScanToolButton_Click(object sender, EventArgs e)
        {

        }
    }
}
