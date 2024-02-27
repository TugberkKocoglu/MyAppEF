using MyApp.UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp.UI
{
    public partial class FrmIndex : Form
    {
        public FrmIndex()
        {
            InitializeComponent();
        }

        private void btnNewRec_Click(object sender, EventArgs e)
        {
            FrmNewRec frmNewRec = new FrmNewRec();
            frmNewRec.ShowDialog();
        }

        private void btnRecs_Click(object sender, EventArgs e)
        {
            FrmRecords frmRecords = new FrmRecords();
            frmRecords.ShowDialog();
        }

        private void btnRecUpdate_Click(object sender, EventArgs e)
        {
            FrmUpdate frmUpdate = new FrmUpdate();
            frmUpdate.ShowDialog();
        }
    }
}
