namespace CodeTools.Control.Java
{
    partial class iBatisDAOCtrl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabCtrl2 = new System.Windows.Forms.TabControl();
            this.javaTab3 = new System.Windows.Forms.TabPage();
            this.jIDCBox = new System.Windows.Forms.RichTextBox();
            this.javaTab4 = new System.Windows.Forms.TabPage();
            this.jIMXBox = new System.Windows.Forms.RichTextBox();
            this.ckTabFrom = new System.Windows.Forms.CheckBox();
            this.ckCombo = new UtilityLibrary.Combos.CheckCombo();
            this.dbMySql = new System.Windows.Forms.RadioButton();
            this.lab4 = new System.Windows.Forms.Label();
            this.lab5 = new System.Windows.Forms.Label();
            this.txtDbConn = new System.Windows.Forms.TextBox();
            this.lab3 = new System.Windows.Forms.Label();
            this.ckPkgDir = new System.Windows.Forms.CheckBox();
            this.txtJavaClazz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPackage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMapper = new System.Windows.Forms.Button();
            this.labTabName = new System.Windows.Forms.Label();
            this.labError = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tabCtrl2.SuspendLayout();
            this.javaTab3.SuspendLayout();
            this.javaTab4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrl2
            // 
            this.tabCtrl2.Controls.Add(this.javaTab3);
            this.tabCtrl2.Controls.Add(this.javaTab4);
            this.tabCtrl2.Location = new System.Drawing.Point(15, 154);
            this.tabCtrl2.Margin = new System.Windows.Forms.Padding(10);
            this.tabCtrl2.Name = "tabCtrl2";
            this.tabCtrl2.SelectedIndex = 0;
            this.tabCtrl2.Size = new System.Drawing.Size(1000, 640);
            this.tabCtrl2.TabIndex = 80;
            // 
            // javaTab3
            // 
            this.javaTab3.Controls.Add(this.jIDCBox);
            this.javaTab3.Location = new System.Drawing.Point(4, 22);
            this.javaTab3.Name = "javaTab3";
            this.javaTab3.Size = new System.Drawing.Size(992, 614);
            this.javaTab3.TabIndex = 2;
            this.javaTab3.Text = "ibatis DAO Code";
            this.javaTab3.UseVisualStyleBackColor = true;
            // 
            // jIDCBox
            // 
            this.jIDCBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            this.jIDCBox.Font = new System.Drawing.Font("宋体", 12F);
            this.jIDCBox.Location = new System.Drawing.Point(10, 10);
            this.jIDCBox.Margin = new System.Windows.Forms.Padding(5);
            this.jIDCBox.Name = "jIDCBox";
            this.jIDCBox.Size = new System.Drawing.Size(970, 600);
            this.jIDCBox.TabIndex = 1;
            this.jIDCBox.Text = "";
            // 
            // javaTab4
            // 
            this.javaTab4.Controls.Add(this.jIMXBox);
            this.javaTab4.Location = new System.Drawing.Point(4, 22);
            this.javaTab4.Name = "javaTab4";
            this.javaTab4.Size = new System.Drawing.Size(992, 614);
            this.javaTab4.TabIndex = 3;
            this.javaTab4.Text = "ibatis Mapper Xml";
            this.javaTab4.UseVisualStyleBackColor = true;
            // 
            // jIMXBox
            // 
            this.jIMXBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            this.jIMXBox.Font = new System.Drawing.Font("宋体", 12F);
            this.jIMXBox.Location = new System.Drawing.Point(10, 10);
            this.jIMXBox.Margin = new System.Windows.Forms.Padding(5);
            this.jIMXBox.Name = "jIMXBox";
            this.jIMXBox.Size = new System.Drawing.Size(970, 600);
            this.jIMXBox.TabIndex = 1;
            this.jIMXBox.Text = "";
            // 
            // ckTabFrom
            // 
            this.ckTabFrom.AutoSize = true;
            this.ckTabFrom.Location = new System.Drawing.Point(767, 64);
            this.ckTabFrom.Name = "ckTabFrom";
            this.ckTabFrom.Size = new System.Drawing.Size(96, 16);
            this.ckTabFrom.TabIndex = 79;
            this.ckTabFrom.Text = "数据库表生成";
            this.ckTabFrom.UseVisualStyleBackColor = true;
            // 
            // ckCombo
            // 
            this.ckCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckCombo.BackColor = System.Drawing.SystemColors.Control;
            this.ckCombo.FillCalled = false;
            this.ckCombo.Location = new System.Drawing.Point(110, 102);
            this.ckCombo.Name = "ckCombo";
            this.ckCombo.ReadOnly = true;
            this.ckCombo.Size = new System.Drawing.Size(631, 21);
            this.ckCombo.TabIndex = 67;
            this.ckCombo.TreeImageList = null;
            this.ckCombo.DataFill += new UtilityLibrary.Combos.TreeCombo.FillTreeByDataHandler(this.checkCombo_DataFill);
            // 
            // dbMySql
            // 
            this.dbMySql.AutoSize = true;
            this.dbMySql.Checked = true;
            this.dbMySql.Location = new System.Drawing.Point(876, 107);
            this.dbMySql.Name = "dbMySql";
            this.dbMySql.Size = new System.Drawing.Size(53, 16);
            this.dbMySql.TabIndex = 78;
            this.dbMySql.TabStop = true;
            this.dbMySql.Text = "MySql";
            this.dbMySql.UseVisualStyleBackColor = true;
            // 
            // lab4
            // 
            this.lab4.AutoSize = true;
            this.lab4.Location = new System.Drawing.Point(24, 107);
            this.lab4.Name = "lab4";
            this.lab4.Size = new System.Drawing.Size(59, 12);
            this.lab4.TabIndex = 77;
            this.lab4.Text = "数据库表:";
            // 
            // lab5
            // 
            this.lab5.AutoSize = true;
            this.lab5.Location = new System.Drawing.Point(801, 108);
            this.lab5.Name = "lab5";
            this.lab5.Size = new System.Drawing.Size(71, 12);
            this.lab5.TabIndex = 76;
            this.lab5.Text = "数据库类型:";
            // 
            // txtDbConn
            // 
            this.txtDbConn.Location = new System.Drawing.Point(110, 62);
            this.txtDbConn.Name = "txtDbConn";
            this.txtDbConn.Size = new System.Drawing.Size(631, 21);
            this.txtDbConn.TabIndex = 75;
            this.txtDbConn.Text = "Server=192.168.1.21;port=3306;user id=root;password=123456;database=rainbow;Chars" +
    "et=utf8";
            // 
            // lab3
            // 
            this.lab3.AutoSize = true;
            this.lab3.Location = new System.Drawing.Point(24, 66);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(83, 12);
            this.lab3.TabIndex = 74;
            this.lab3.Text = "数据库连接串:";
            // 
            // ckPkgDir
            // 
            this.ckPkgDir.AutoSize = true;
            this.ckPkgDir.Location = new System.Drawing.Point(767, 29);
            this.ckPkgDir.Name = "ckPkgDir";
            this.ckPkgDir.Size = new System.Drawing.Size(96, 16);
            this.ckPkgDir.TabIndex = 73;
            this.ckPkgDir.Text = "生成框架目录";
            this.ckPkgDir.UseVisualStyleBackColor = true;
            // 
            // txtJavaClazz
            // 
            this.txtJavaClazz.Location = new System.Drawing.Point(469, 25);
            this.txtJavaClazz.Name = "txtJavaClazz";
            this.txtJavaClazz.Size = new System.Drawing.Size(272, 21);
            this.txtJavaClazz.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 71;
            this.label1.Text = "Java类名:";
            // 
            // txtPackage
            // 
            this.txtPackage.Location = new System.Drawing.Point(110, 25);
            this.txtPackage.Name = "txtPackage";
            this.txtPackage.Size = new System.Drawing.Size(272, 21);
            this.txtPackage.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 69;
            this.label2.Text = "Java包名前缀:";
            // 
            // btnMapper
            // 
            this.btnMapper.Location = new System.Drawing.Point(880, 46);
            this.btnMapper.Name = "btnMapper";
            this.btnMapper.Size = new System.Drawing.Size(106, 36);
            this.btnMapper.TabIndex = 68;
            this.btnMapper.Text = "生成Java代码";
            this.btnMapper.UseVisualStyleBackColor = true;
            this.btnMapper.Click += new System.EventHandler(this.btnMapper_Click);
            // 
            // labTabName
            // 
            this.labTabName.AutoSize = true;
            this.labTabName.Location = new System.Drawing.Point(113, 130);
            this.labTabName.Name = "labTabName";
            this.labTabName.Size = new System.Drawing.Size(0, 12);
            this.labTabName.TabIndex = 81;
            // 
            // labError
            // 
            this.labError.AutoSize = true;
            this.labError.ForeColor = System.Drawing.Color.Red;
            this.labError.Location = new System.Drawing.Point(886, 22);
            this.labError.Name = "labError";
            this.labError.Size = new System.Drawing.Size(0, 12);
            this.labError.TabIndex = 82;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(750, 102);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(39, 23);
            this.btnRefresh.TabIndex = 83;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // iBatisDAOCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.labError);
            this.Controls.Add(this.labTabName);
            this.Controls.Add(this.tabCtrl2);
            this.Controls.Add(this.ckTabFrom);
            this.Controls.Add(this.ckCombo);
            this.Controls.Add(this.dbMySql);
            this.Controls.Add(this.lab4);
            this.Controls.Add(this.lab5);
            this.Controls.Add(this.txtDbConn);
            this.Controls.Add(this.lab3);
            this.Controls.Add(this.ckPkgDir);
            this.Controls.Add(this.txtJavaClazz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPackage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMapper);
            this.Name = "iBatisDAOCtrl";
            this.Size = new System.Drawing.Size(1025, 800);
            this.Load += new System.EventHandler(this.iBatisDAOCtrl_Load);
            this.Disposed += new System.EventHandler(this.iBatisDAOCtrl_Disposed);
            this.tabCtrl2.ResumeLayout(false);
            this.javaTab3.ResumeLayout(false);
            this.javaTab4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrl2;
        private System.Windows.Forms.TabPage javaTab3;
        private System.Windows.Forms.RichTextBox jIDCBox;
        private System.Windows.Forms.TabPage javaTab4;
        private System.Windows.Forms.RichTextBox jIMXBox;
        private System.Windows.Forms.CheckBox ckTabFrom;
        private UtilityLibrary.Combos.CheckCombo ckCombo;
        private System.Windows.Forms.RadioButton dbMySql;
        private System.Windows.Forms.Label lab4;
        private System.Windows.Forms.Label lab5;
        private System.Windows.Forms.TextBox txtDbConn;
        private System.Windows.Forms.Label lab3;
        private System.Windows.Forms.CheckBox ckPkgDir;
        private System.Windows.Forms.TextBox txtJavaClazz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPackage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMapper;
        private System.Windows.Forms.Label labTabName;
        private System.Windows.Forms.Label labError;
        private System.Windows.Forms.Button btnRefresh;
    }
}
