
namespace Bai1
{
    partial class Form9
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Nguyen Van Tuan");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Nguyen Thi Lan");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Nguyen Van Huong");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("THTH5A", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("le Nghiep");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("tran long");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("ly hai");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("THTH5B", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Le trung");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Ton thi mai");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Tran minh");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("THTH5C", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Khoa Tin Hoc", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8,
            treeNode12});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 57);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node4";
            treeNode1.Text = "Nguyen Van Tuan";
            treeNode2.Name = "Node5";
            treeNode2.Text = "Nguyen Thi Lan";
            treeNode3.Name = "Node6";
            treeNode3.Text = "Nguyen Van Huong";
            treeNode4.Name = "Node1";
            treeNode4.Text = "THTH5A";
            treeNode5.Name = "Node7";
            treeNode5.Text = "le Nghiep";
            treeNode6.Name = "Node8";
            treeNode6.Text = "tran long";
            treeNode7.Name = "Node9";
            treeNode7.Text = "ly hai";
            treeNode8.Name = "Node2";
            treeNode8.Text = "THTH5B";
            treeNode9.Name = "Node10";
            treeNode9.Text = "Le trung";
            treeNode10.Name = "Node11";
            treeNode10.Text = "Ton thi mai";
            treeNode11.Name = "Node12";
            treeNode11.Text = "Tran minh";
            treeNode12.Name = "Node3";
            treeNode12.Text = "THTH5C";
            treeNode13.Name = "Node0";
            treeNode13.Text = "Khoa Tin Hoc";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13});
            this.treeView1.Size = new System.Drawing.Size(386, 381);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(404, 57);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(384, 381);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ten Sinh Vien";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Lop";
            this.columnHeader2.Width = 160;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input\'s Name";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(404, 12);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(218, 30);
            this.txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(640, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 30);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form9";
            this.Text = "Form9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}