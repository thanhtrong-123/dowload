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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        private List<TreeNode> CurrentNodeMatches = new List<TreeNode>();

        private int LastNodeIndex = 0;

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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string searchText = txtFirstName.Text;
            if (String.IsNullOrEmpty(searchText))
            {
                return;
            };


            if (txtLastName.Text != searchText)
            {
                CurrentNodeMatches.Clear();
                txtLastName.Text = searchText;
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

        }
    }
}
