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
    public partial class FrmRecords : Form
    {
        public FrmRecords()
        {
            InitializeComponent();
        }
        Operations operations= new Operations();
        private void FrmRecords_Load(object sender, EventArgs e)
        {
            
            cmbApps.DataSource = operations.FillApps();
            cmbApps.SelectedIndex = -1;
            
            


        }

        

        private void cmbApps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbApps.SelectedItem!=null)
            {
                var app = operations.GetApp(cmbApps.SelectedItem.ToString());
                lblUserName.Text = app.UserName;
                lblPassword.Text = app.Password;
            }
            else
            {
                lblUserName.Text = "";
                lblPassword.Text = "";
            }
           
        }
    }
}
