using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        private List<TreeNode> CurrentNodeMatches = new List<TreeNode>();

        private int LastNodeIndex = 0;
        private string LastSearchText;
        private void SearchNodes(string SearchText, TreeNode StartNode)
        {
            while (StartNode != null)
            {
                if (StartNode.Text.ToLower().Contains(SearchText.ToLower()))
                {
                    CurrentNodeMatches.Add(StartNode);
                };
                if (StartNode.Nodes.Count != 0)
                {
                    SearchNodes(SearchText, StartNode.Nodes[0]);
                };
                StartNode = StartNode.NextNode;
            };

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {

            string searchText = this.txtSearch.Text;
            if (String.IsNullOrEmpty(searchText))
            {
                return;
            };


            if (LastSearchText != searchText)
            {
                CurrentNodeMatches.Clear();
                LastSearchText = searchText;
                LastNodeIndex = 0;
                SearchNodes(searchText, treeView1.Nodes[0]);
            }

            if (LastNodeIndex >= 0 && CurrentNodeMatches.Count > 0 && LastNodeIndex < CurrentNodeMatches.Count)
            {
                TreeNode selectedNode = CurrentNodeMatches[LastNodeIndex];
                LastNodeIndex++;
                this.treeView1.SelectedNode = selectedNode;
                this.treeView1.SelectedNode.Expand();
                this.treeView1.Select();

            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ListViewItem item = new ListViewItem();
            for (int i = 0; i < treeView1.Nodes.Count; i++)
            {
                if (treeView1.SelectedNode.Nodes.Count > 0)
                {
                    item.Text = treeView1.SelectedNode.Nodes[i].Text;
                    item.SubItems.Add(treeView1.SelectedNode.Text);
                }
               
                
            }

            listView1.Items.Add(item);

        }
    }
}
