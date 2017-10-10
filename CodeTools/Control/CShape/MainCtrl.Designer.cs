namespace CodeTools.Control.CShape
{
    partial class MainCtrl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cCBox = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cIDRBox = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cDRBox = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cDMBox = new System.Windows.Forms.RichTextBox();
            this.dbSqlServer = new System.Windows.Forms.RadioButton();
            this.ckCombo = new UtilityLibrary.Combos.CheckCombo();
            this.dbMySql = new System.Windows.Forms.RadioButton();
            this.lab9 = new System.Windows.Forms.Label();
            this.lab10 = new System.Windows.Forms.Label();
            this.txtDbConn = new System.Windows.Forms.TextBox();
            this.lab8 = new System.Windows.Forms.Label();
            this.txtNamespace = new System.Windows.Forms.TextBox();
            this.lab6 = new System.Windows.Forms.Label();
            this.btnCShape = new System.Windows.Forms.Button();
            this.lab7 = new System.Windows.Forms.Label();
            this.txtDbConfig = new System.Windows.Forms.TextBox();
            this.labTabName = new System.Windows.Forms.Label();
            this.labError = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(10, 168);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1004, 624);
            this.tabControl1.TabIndex = 47;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cCBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(996, 598);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Class Code";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cCBox
            // 
            this.cCBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            this.cCBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cCBox.Location = new System.Drawing.Point(10, 10);
            this.cCBox.Name = "cCBox";
            this.cCBox.Size = new System.Drawing.Size(980, 580);
            this.cCBox.TabIndex = 0;
            this.cCBox.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cIDRBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(996, 598);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "IDataRepositories Code";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cIDRBox
            // 
            this.cIDRBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            this.cIDRBox.Font = new System.Drawing.Font("宋体", 12F);
            this.cIDRBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cIDRBox.Location = new System.Drawing.Point(10, 10);
            this.cIDRBox.Name = "cIDRBox";
            this.cIDRBox.Size = new System.Drawing.Size(980, 580);
            this.cIDRBox.TabIndex = 1;
            this.cIDRBox.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cDRBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(996, 598);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "DataRepositories Code";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cDRBox
            // 
            this.cDRBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            this.cDRBox.Font = new System.Drawing.Font("宋体", 12F);
            this.cDRBox.Location = new System.Drawing.Point(10, 10);
            this.cDRBox.Name = "cDRBox";
            this.cDRBox.Size = new System.Drawing.Size(980, 580);
            this.cDRBox.TabIndex = 1;
            this.cDRBox.Text = "";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.cDMBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(996, 598);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "DataRepositories Mapper Xml";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // cDMBox
            // 
            this.cDMBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            this.cDMBox.Font = new System.Drawing.Font("宋体", 12F);
            this.cDMBox.Location = new System.Drawing.Point(10, 10);
            this.cDMBox.Name = "cDMBox";
            this.cDMBox.Size = new System.Drawing.Size(980, 580);
            this.cDMBox.TabIndex = 1;
            this.cDMBox.Text = "";
            // 
            // dbSqlServer
            // 
            this.dbSqlServer.AutoSize = true;
            this.dbSqlServer.Location = new System.Drawing.Point(781, 111);
            this.dbSqlServer.Name = "dbSqlServer";
            this.dbSqlServer.Size = new System.Drawing.Size(83, 16);
            this.dbSqlServer.TabIndex = 46;
            this.dbSqlServer.Text = "SQL Server";
            this.dbSqlServer.UseVisualStyleBackColor = true;
            this.dbSqlServer.CheckedChanged += new System.EventHandler(this.dbSqlServer_CheckedChanged);
            // 
            // ckCombo
            // 
            this.ckCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckCombo.BackColor = System.Drawing.SystemColors.Control;
            this.ckCombo.FillCalled = false;
            this.ckCombo.Location = new System.Drawing.Point(118, 107);
            this.ckCombo.Name = "ckCombo";
            this.ckCombo.ReadOnly = true;
            this.ckCombo.Size = new System.Drawing.Size(445, 21);
            this.ckCombo.TabIndex = 34;
            this.ckCombo.TreeImageList = null;
            this.ckCombo.DataFill += new UtilityLibrary.Combos.TreeCombo.FillTreeByDataHandler(this.checkCombo_DataFill);
            // 
            // dbMySql
            // 
            this.dbMySql.AutoSize = true;
            this.dbMySql.Checked = true;
            this.dbMySql.Location = new System.Drawing.Point(714, 110);
            this.dbMySql.Name = "dbMySql";
            this.dbMySql.Size = new System.Drawing.Size(53, 16);
            this.dbMySql.TabIndex = 44;
            this.dbMySql.TabStop = true;
            this.dbMySql.Text = "MySql";
            this.dbMySql.UseVisualStyleBackColor = true;
            // 
            // lab9
            // 
            this.lab9.AutoSize = true;
            this.lab9.Location = new System.Drawing.Point(32, 112);
            this.lab9.Name = "lab9";
            this.lab9.Size = new System.Drawing.Size(59, 12);
            this.lab9.TabIndex = 43;
            this.lab9.Text = "数据库表:";
            // 
            // lab10
            // 
            this.lab10.AutoSize = true;
            this.lab10.Location = new System.Drawing.Point(630, 112);
            this.lab10.Name = "lab10";
            this.lab10.Size = new System.Drawing.Size(71, 12);
            this.lab10.TabIndex = 42;
            this.lab10.Text = "数据库类型:";
            // 
            // txtDbConn
            // 
            this.txtDbConn.Location = new System.Drawing.Point(118, 69);
            this.txtDbConn.Name = "txtDbConn";
            this.txtDbConn.Size = new System.Drawing.Size(706, 21);
            this.txtDbConn.TabIndex = 41;
            this.txtDbConn.Text = "Server=127.0.0.1;port=3306;user id=root;password=123qwe;database=hzdb;Charset=utf" +
    "8";
            // 
            // lab8
            // 
            this.lab8.AutoSize = true;
            this.lab8.Location = new System.Drawing.Point(32, 74);
            this.lab8.Name = "lab8";
            this.lab8.Size = new System.Drawing.Size(83, 12);
            this.lab8.TabIndex = 40;
            this.lab8.Text = "数据库连接串:";
            // 
            // txtNamespace
            // 
            this.txtNamespace.Location = new System.Drawing.Point(118, 23);
            this.txtNamespace.Name = "txtNamespace";
            this.txtNamespace.Size = new System.Drawing.Size(280, 21);
            this.txtNamespace.TabIndex = 37;
            // 
            // lab6
            // 
            this.lab6.AutoSize = true;
            this.lab6.Location = new System.Drawing.Point(31, 27);
            this.lab6.Name = "lab6";
            this.lab6.Size = new System.Drawing.Size(83, 12);
            this.lab6.TabIndex = 36;
            this.lab6.Text = "命名空间前缀:";
            // 
            // btnCShape
            // 
            this.btnCShape.Location = new System.Drawing.Point(860, 48);
            this.btnCShape.Name = "btnCShape";
            this.btnCShape.Size = new System.Drawing.Size(113, 38);
            this.btnCShape.TabIndex = 35;
            this.btnCShape.Text = "生成C#代码";
            this.btnCShape.UseVisualStyleBackColor = true;
            this.btnCShape.Click += new System.EventHandler(this.btnCShape_Click);
            // 
            // lab7
            // 
            this.lab7.AutoSize = true;
            this.lab7.Location = new System.Drawing.Point(419, 27);
            this.lab7.Name = "lab7";
            this.lab7.Size = new System.Drawing.Size(119, 12);
            this.lab7.TabIndex = 48;
            this.lab7.Text = "数据库连接配置名称:";
            // 
            // txtDbConfig
            // 
            this.txtDbConfig.Location = new System.Drawing.Point(544, 23);
            this.txtDbConfig.Name = "txtDbConfig";
            this.txtDbConfig.Size = new System.Drawing.Size(280, 21);
            this.txtDbConfig.TabIndex = 49;
            // 
            // labTabName
            // 
            this.labTabName.AutoSize = true;
            this.labTabName.Location = new System.Drawing.Point(119, 138);
            this.labTabName.Name = "labTabName";
            this.labTabName.Size = new System.Drawing.Size(0, 12);
            this.labTabName.TabIndex = 71;
            // 
            // labError
            // 
            this.labError.AutoSize = true;
            this.labError.ForeColor = System.Drawing.Color.Red;
            this.labError.Location = new System.Drawing.Point(864, 26);
            this.labError.Name = "labError";
            this.labError.Size = new System.Drawing.Size(0, 12);
            this.labError.TabIndex = 72;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(576, 108);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(39, 23);
            this.btnRefresh.TabIndex = 85;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // MainCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.labError);
            this.Controls.Add(this.labTabName);
            this.Controls.Add(this.txtDbConfig);
            this.Controls.Add(this.lab7);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dbSqlServer);
            this.Controls.Add(this.ckCombo);
            this.Controls.Add(this.dbMySql);
            this.Controls.Add(this.lab9);
            this.Controls.Add(this.lab10);
            this.Controls.Add(this.txtDbConn);
            this.Controls.Add(this.lab8);
            this.Controls.Add(this.txtNamespace);
            this.Controls.Add(this.lab6);
            this.Controls.Add(this.btnCShape);
            this.Name = "MainCtrl";
            this.Size = new System.Drawing.Size(1025, 800);
            this.Load += new System.EventHandler(this.MainCtrl_Load);
            this.Disposed += new System.EventHandler(this.MainCtrl_Disposed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox cCBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox cIDRBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox cDRBox;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RichTextBox cDMBox;
        private System.Windows.Forms.RadioButton dbSqlServer;
        private UtilityLibrary.Combos.CheckCombo ckCombo;
        private System.Windows.Forms.RadioButton dbMySql;
        private System.Windows.Forms.Label lab9;
        private System.Windows.Forms.Label lab10;
        private System.Windows.Forms.TextBox txtDbConn;
        private System.Windows.Forms.Label lab8;
        private System.Windows.Forms.TextBox txtNamespace;
        private System.Windows.Forms.Label lab6;
        private System.Windows.Forms.Button btnCShape;
        private System.Windows.Forms.Label lab7;
        private System.Windows.Forms.TextBox txtDbConfig;
        private System.Windows.Forms.Label labTabName;
        private System.Windows.Forms.Label labError;
        private System.Windows.Forms.Button btnRefresh;

    }
}
