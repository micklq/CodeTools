using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeTools
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
       

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string text = e.Node.Name;
            Control.Java.MainCtrl jmCtrl = new Control.Java.MainCtrl();
            Control.Java.ServiceCtrl jsCtrl = new Control.Java.ServiceCtrl();
            Control.Java.iBatisDAOCtrl jiCtrl = new Control.Java.iBatisDAOCtrl();
            Control.Java.RepositoryCtrl jrCtrl = new Control.Java.RepositoryCtrl();

            Control.CShape.MainCtrl cmCtrl = new Control.CShape.MainCtrl();
            Control.CShape.ClazzCtrl ccCtrl = new Control.CShape.ClazzCtrl();
            Control.CShape.RepositoryCtrl crCtrl = new Control.CShape.RepositoryCtrl();

            switch (text)
            {
                case "java0":
                    {
                        this.mainPanel.Controls.Clear(); 
                        this.mainPanel.Controls.Add(jmCtrl);
                        jsCtrl.Dispose();
                        jiCtrl.Dispose();
                        jrCtrl.Dispose();
                        cmCtrl.Dispose();
                        ccCtrl.Dispose();
                        crCtrl.Dispose();
                        break;
                    }
                case "java1":
                    {
                        this.mainPanel.Controls.Clear();                     
                        this.mainPanel.Controls.Add(jsCtrl);                       
                        jmCtrl.Dispose();
                        jiCtrl.Dispose();
                        jrCtrl.Dispose();
                        cmCtrl.Dispose();
                        ccCtrl.Dispose();
                        crCtrl.Dispose();
                        break;
                    }
                case "java2":
                    {
                        this.mainPanel.Controls.Clear();                       
                        this.mainPanel.Controls.Add(jiCtrl);
                        jmCtrl.Dispose();
                        jsCtrl.Dispose();
                        jrCtrl.Dispose();
                        cmCtrl.Dispose();
                        ccCtrl.Dispose();
                        crCtrl.Dispose();
                        break;
                    }
                case "java3":
                    {
                        this.mainPanel.Controls.Clear();                       
                        this.mainPanel.Controls.Add(jrCtrl);
                        jmCtrl.Dispose();
                        jsCtrl.Dispose();
                        jiCtrl.Dispose();
                        cmCtrl.Dispose();
                        ccCtrl.Dispose();
                        crCtrl.Dispose();
                        break;
                    }
                case "cshape0":
                    {
                        this.mainPanel.Controls.Clear();                        
                        this.mainPanel.Controls.Add(cmCtrl);
                        jmCtrl.Dispose();
                        jsCtrl.Dispose();
                        jiCtrl.Dispose();
                        jrCtrl.Dispose();
                        ccCtrl.Dispose();
                        crCtrl.Dispose();
                        break;
                    }
                case "cshape1":
                    {
                        this.mainPanel.Controls.Clear();                       
                        this.mainPanel.Controls.Add(ccCtrl);
                        jmCtrl.Dispose();
                        jsCtrl.Dispose();
                        jiCtrl.Dispose();
                        jrCtrl.Dispose();
                        cmCtrl.Dispose();
                        crCtrl.Dispose();
                        break;
                    }
                case "cshape2":
                    {
                        this.mainPanel.Controls.Clear();                      
                        this.mainPanel.Controls.Add(crCtrl);
                        jmCtrl.Dispose();
                        jsCtrl.Dispose();
                        jiCtrl.Dispose();
                        jrCtrl.Dispose();
                        cmCtrl.Dispose();
                        ccCtrl.Dispose();
                        break;
                    }
                    
                   
            }

        }
        private void frmMain_Disposed(object sender, EventArgs e)
        {
            this.Dispose();
        }
      
    }
}
