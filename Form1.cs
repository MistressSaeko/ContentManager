using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;



namespace ContentInstaller
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            poptview();
        }

        private void PathsButton_Click(object sender, EventArgs e)
        {
            Paths paths = new Paths();
            DialogResult res = paths.ShowDialog();
            if (res == DialogResult.OK)
            {
                ContentList.Nodes.Add(paths.Content);
            }
        }

        private void InstallButton_Click(object sender, EventArgs e)
        {
            Progress inst = new Progress();
            inst.Text = "Installing content...";
            // The label would be the contents of the archive
            // Then we set the checkbox control in the ContentView to checked signifying that the content has been installed.
        }

        private void UninstallButton_Click(object sender, EventArgs e)
        {
            Progress uninst = new Progress();
            uninst.Text = "Uninstalling content...";
            // The label would be the contents of what's being removed. Ideally, you'd want the app to "remember" where everything went.
        }



        private void poptview()
        {
            TreeNode rootnode;

            DirectoryInfo content = new DirectoryInfo();
            if (content.Exists)
            {
                rootnode = new TreeNode(content.Name);
                rootnode.Tag = content;
                GetDirectories(content.GetDirectories(), rootnode);
                ContentList.Nodes.Add(rootnode);
            }
        }

        private void GetDirectories(DirectoryInfo[] subdirs, TreeNode addnode)
        {
            TreeNode anode;
            DirectoryInfo[] subsubdirs;
            foreach (DirectoryInfo subdir in subdirs)
            {
                anode = new TreeNode(subdir.Name, 0, 0);
                anode.Tag = subdir;
                subsubdirs = subdir.GetDirectories();
                if (subsubdirs.Length != 0)
                {
                    GetDirectories(subsubdirs, anode);
                }
                addnode.Nodes.Add(anode);
            }
        }

        void ContentList_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode newselected = e.Node;
            ContentView.Items.Clear();
            DirectoryInfo nodedirinfo = (DirectoryInfo)newselected.Tag;
            ListViewItem.ListViewSubItem[] subitems;
            ListViewItem item = null;

            foreach(DirectoryInfo dir in nodedirinfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name);
                subitems = new ListViewItem.ListViewSubItem[]
                {
                    new ListViewItem.ListViewSubItem(item, "Directory"),
                    new ListViewItem.ListViewSubItem(item, dir.LastAccessTime.ToShortDateString())
                };

                item.SubItems.AddRange(subitems);
                ContentView.Items.Add(item);
            }

            foreach (FileInfo file in nodedirinfo.GetFiles())
            {
                item = new ListViewItem(file.Name);
                subitems = new ListViewItem.ListViewSubItem[]
            { new ListViewItem.ListViewSubItem(item, "File"), 
             new ListViewItem.ListViewSubItem(item, 
                file.LastAccessTime.ToShortDateString())};

                item.SubItems.AddRange(subitems);
                ContentView.Items.Add(item);
            }

            ContentView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void ScanButton_Click(object sender, EventArgs e)
        {
//            Directory.GetFiles();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            AboutDialog aboot = new AboutDialog();
            aboot.ShowDialog(this);
        }
    }
}
