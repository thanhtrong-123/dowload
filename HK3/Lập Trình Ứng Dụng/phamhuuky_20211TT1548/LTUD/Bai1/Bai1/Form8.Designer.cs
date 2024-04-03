
namespace Bai1
{
    partial class Form8
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("A");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Bao,Nguyen The");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Binh,Nguyen Thanh");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("B", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("C");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Dung Van Tran");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("D", new System.Windows.Forms.TreeNode[] {
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("E");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("F");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("G");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("H");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("J");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("K");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("L");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Q");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("E");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node0";
            treeNode1.Text = "A";
            treeNode2.Name = "Node13";
            treeNode2.Text = "Bao,Nguyen The";
            treeNode3.Name = "Node16";
            treeNode3.Text = "Binh,Nguyen Thanh";
            treeNode4.Name = "Node1";
            treeNode4.Text = "B";
            treeNode5.Name = "Node2";
            treeNode5.Text = "C";
            treeNode6.Name = "Node17";
            treeNode6.Text = "Dung Van Tran";
            treeNode7.Name = "Node3";
            treeNode7.Text = "D";
            treeNode8.Name = "Node4";
            treeNode8.Text = "E";
            treeNode9.Name = "Node5";
            treeNode9.Text = "F";
            treeNode10.Name = "Node6";
            treeNode10.Text = "G";
            treeNode11.Name = "Node7";
            treeNode11.Text = "H";
            treeNode12.Name = "Node8";
            treeNode12.Text = "J";
            treeNode13.Name = "Node9";
            treeNode13.Text = "K";
            treeNode14.Name = "Node10";
            treeNode14.Text = "L";
            treeNode15.Name = "Node11";
            treeNode15.Text = "Q";
            treeNode16.Name = "Node12";
            treeNode16.Text = "E";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode4,
            treeNode5,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16});
            this.treeView1.Size = new System.Drawing.Size(440, 426);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(475, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 315);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(6, 198);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(301, 39);
            this.txtLastName.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(199, 263);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 39);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Name";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(6, 71);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(301, 39);
            this.txtFirstName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(608, 363);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(134, 40);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
    }
}