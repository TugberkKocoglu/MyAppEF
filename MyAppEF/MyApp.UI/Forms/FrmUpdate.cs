using MyApp.Business;
using MyApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp.UI.Forms
{
    public partial class FrmUpdate : Form
    {
        public FrmUpdate()
        {
            InitializeComponent();
        }

        Operations operations=new Operations();
        private void FrmUpdate_Load(object sender, EventArgs e)
        {
            cmbApps.DataSource= operations.FillApps();
            cmbApps.SelectedIndex = -1;
        }

        private void cmbApps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbApps.SelectedItem!=null)
            {
                var app = operations.GetApp(cmbApps.SelectedItem.ToString());
                txtUserName.Text = app.UserName;
                txtPassword.Text = app.Password;
            }
            else
            {
                txtUserName.Text = "";
                txtPassword.Text = "";
            }
            
        }

        private void btnUpdateR_Click(object sender, EventArgs e)
        {
            operations.UpdateApp(cmbApps.SelectedItem.ToString(), txtUserName.Text, txtPassword.Text);
            Close();
        }

        private void btnDelR_Click(object sender, EventArgs e)
        {
            
            operations.DeleteApp(cmbApps.SelectedItem.ToString());
            Close();
        }
    }
}
