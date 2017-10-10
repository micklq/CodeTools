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
using CodeTools.Java;

namespace CodeTools.Control.Java
{
    public partial class RepositoryCtrl : UserControl
    {
        public RepositoryCtrl()
        {
            InitializeComponent();
        }
       
        private void btnRepository_Click(object sender, EventArgs e)
        {
            this.labError.Text = "";
            String package = this.txtPackage.Text.ToString().Trim();
            if (String.IsNullOrEmpty(package))
            {
                this.labError.Text = "请输入包名前缀！";
                return;
            }

            String clazz = this.txtJavaClazz.Text.ToString().Trim();

            var isTabFrom = this.ckTabFrom.Checked;

            if (!isTabFrom && String.IsNullOrEmpty(clazz))
            {
                this.labError.Text = "请输入类名！";
                return;
            }
            string dbStr = this.txtDbConn.Text.ToString().Trim();
            if (isTabFrom && String.IsNullOrEmpty(dbStr))
            {
                this.labError.Text = "请输入数据库连接字符串！";
                return;
            }
            if (isTabFrom && String.IsNullOrEmpty(this.labTabName.Text.ToString().Trim()))
            {
                this.labError.Text = "请选择生成的数据表！";
                return;
            }

            var ckPkgDir = this.ckPkgDir.Checked;
            StringBuilder jRepository = new StringBuilder();
            if (isTabFrom)
            {
                string tabs = this.labTabName.Text.ToString().Trim();
                foreach (var o in tabs.Split(','))
                {
                    string clazzName = ConvertHelper.TableNameToClassName(o.Trim());             

                    jRepository.Append(JavaGenrate.Repository(package, clazzName, ckPkgDir));
                    jRepository.Append("\r\n\r\n");
                }
            }
            else
            {
                foreach (var o in clazz.Split(','))
                {                    

                    jRepository.Append(JavaGenrate.Repository(package, o, ckPkgDir));
                    jRepository.Append("\r\n\r\n");
                }
            }         
            this.jRCBox.Text = jRepository.ToString();
        }

        private void RepositoryCtrl_Load(object sender, EventArgs e)
        {
            labTabName.DataBindings.Add("Text", ckCombo, "Value");    
        }

        private void RepositoryCtrl_Disposed(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void checkCombo_DataFill(object sender, UtilityLibrary.Combos.TreeCombo.EventArgsTreeDataFill e)
        {
            var tabFrom = this.ckTabFrom.Checked;
            string dbConn = this.txtDbConn.Text.ToString().Trim();
            if (tabFrom && !String.IsNullOrEmpty(dbConn) && !this.ckCombo.FillCalled)
            {

                List<string> tabNames = MySqlHelper.GetTables(dbConn);
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
    }
}
