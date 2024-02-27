using MyApp.Business;
using MyApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp.UI.Forms
{
    public partial class FrmNewRec : Form
    {
        public FrmNewRec()
        {
            InitializeComponent();
        }

        Operations operations = new Operations();   
        private void btnSave_Click(object sender, EventArgs e)
        {
            App app = new App(); 
            app.AppName= txtAppName.Text;
            app.UserName= txtUserName.Text;
            app.Password= txtPassword.Text;
            operations.AddApp(app);
            Close();
        }
    }
}
