using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeTools.Util;
using CodeTools.CShape;

namespace CodeTools.Control.CShape
{
    public partial class MainCtrl : UserControl
    {
        public MainCtrl()
        {
            InitializeComponent();
        }     

      
        private void btnCShape_Click(object sender, EventArgs e)
        {
            this.labError.Text = "";
            String nameSpace = this.txtNamespace.Text.ToString().Trim();
            if (String.IsNullOrEmpty(nameSpace))
            {
                this.labError.Text = "请输入命名空间前缀！";
                return;
            }

            String dbConfig = this.txtDbConfig.Text.ToString().Trim();
          
            if (String.IsNullOrEmpty(dbConfig))
            {
                this.labError.Text = "请输入数据库配置名称！";
                return;
            }
            string dbStr = this.txtDbConn.Text.ToString().Trim();
            if (String.IsNullOrEmpty(dbStr))
            {
                this.labError.Text = "请输入数据库连接字符串！";
                return;
            }
            if (String.IsNullOrEmpty(this.labTabName.Text.ToString().Trim()))
            {
                this.labError.Text = "请选择生成的数据表！";
                return;
            }
            var dbType1 = this.dbMySql.Checked;
            var dbType2 = this.dbSqlServer.Checked;
            DBType dbtype = DBType.MySql;
            if (!dbType1 && dbType2)
            {
                dbtype = DBType.SqlService;
            }

            StringBuilder cClazz = new StringBuilder();
            StringBuilder cIRepository = new StringBuilder();
            StringBuilder cRepository = new StringBuilder();
            StringBuilder cMapperXml = new StringBuilder();
           
            string tabs = this.labTabName.Text.ToString().Trim();
            foreach (var o in tabs.Split(','))
            {               
                string tabName = o.Trim();
                string clazzName = ConvertHelper.TableNameToClassName(tabName);
                cClazz.Append(CShapeGenrate.Clazz(nameSpace, tabName, dbStr, dbtype));
                cClazz.Append("\r\n\r\n");
                CShapeGenrate.ModuleEnvironment(nameSpace);

                cIRepository.Append(CShapeGenrate.IRepository(nameSpace, clazzName));
                cIRepository.Append("\r\n\r\n");

                cRepository.Append(CShapeGenrate.Repository(nameSpace, clazzName));
                cRepository.Append("\r\n\r\n");

                cMapperXml.Append(CShapeGenrate.RepositoryMapper(nameSpace, tabName, dbConfig, dbStr, dbtype));
                cMapperXml.Append("\r\n\r\n");
              
            }

            this.cCBox.Text = cClazz.ToString();
            this.cIDRBox.Text = cIRepository.ToString();
            this.cDRBox.Text = cRepository.ToString();
            this.cDMBox.Text = cMapperXml.ToString();
           
        }

        private void MainCtrl_Load(object sender, EventArgs e)
        {
            labTabName.DataBindings.Add("Text", ckCombo, "Value");    
        }

        private void MainCtrl_Disposed(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void checkCombo_DataFill(object sender, UtilityLibrary.Combos.TreeCombo.EventArgsTreeDataFill e)
        {          
            string dbConn = this.txtDbConn.Text.ToString().Trim();
            if (!String.IsNullOrEmpty(dbConn) && !this.ckCombo.FillCalled)
            {
                List<string> tabNames = new List<string>();
                var dbType1 = this.dbMySql.Checked;
                var dbType2 = this.dbSqlServer.Checked;
                if (dbType1 && !dbType2 )
                {
                    tabNames = MySqlHelper.GetTables(dbConn);
                }
                if (!dbType1 && dbType2 )
                {
                    string dbName = SqlServiceHelper.GetDBName(dbConn);
                    tabNames = SqlServiceHelper.GetTables(dbConn, dbName);
                }  
                if (tabNames.Count > 0)
                {
                    e.BindedControl.Nodes.Clear();
                    foreach (var o in tabNames)
                    {
                        e.BindedControl.Nodes.Add(o);
                    }
                }
            }

        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.ckCombo.FillCalled = false;
            this.ckCombo.UserRaiseFillData();
        }

        private void dbSqlServer_CheckedChanged(object sender, EventArgs e)
        {
            if (this.dbSqlServer.Checked)
            {
                this.txtDbConn.Text = "Server=127.0.0.1;Database=nData;User Id=sa;password=mick123!@#;";
            }
            if (this.dbMySql.Checked)
            {
                this.txtDbConn.Text = "Server=127.0.0.1;port=3306;user id=root;password=123456;database=nData;Charset=utf8";
            }
        }
                
    }
}
