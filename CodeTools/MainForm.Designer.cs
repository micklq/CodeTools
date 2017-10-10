namespace CodeTools
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("All Code");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Service Code");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("ibatisDAO Code");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Repository Code");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Java Code", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("All Code");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Class Code");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Repository Code");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("C# Code", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("PHP Code");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.treeView = new System.Windows.Forms.TreeView();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(1, 1);
            this.treeView.Name = "treeView";
            treeNode1.Checked = true;
            treeNode1.Name = "java0";
            treeNode1.Text = "All Code";
            treeNode2.Checked = true;
            treeNode2.Name = "java1";
            treeNode2.Text = "Service Code";
            treeNode3.Checked = true;
            treeNode3.Name = "java2";
            treeNode3.Text = "ibatisDAO Code";
            treeNode4.Name = "java3";
            treeNode4.Text = "Repository Code";
            treeNode5.Name = "Root0";
            treeNode5.Text = "Java Code";
            treeNode6.Name = "cshape0";
            treeNode6.Text = "All Code";
            treeNode7.Name = "cshape1";
            treeNode7.Text = "Class Code";
            treeNode8.Name = "cshape2";
            treeNode8.Text = "Repository Code";
            treeNode9.Name = "Root1";
            treeNode9.Text = "C# Code";
            treeNode10.Name = "Root2";
            treeNode10.Text = "PHP Code";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode9,
            treeNode10});
            this.treeView.Size = new System.Drawing.Size(180, 800);
            this.treeView.TabIndex = 0;
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(185, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1025, 800);
            this.mainPanel.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 803);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.treeView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Panel mainPanel;
    }
}

