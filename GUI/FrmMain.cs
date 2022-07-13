using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        public static string[] FormShowed = { "", "Closed", "Closed", "Closed", "Closed", "Closed", "Closed" };
        private void toolStripMenuItemRecord_Click(object sender, EventArgs e)
        {
            FrmRecords frmRecords = new FrmRecords();
            frmRecords.Show();
            
        }

        private void subCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSubcategory frm  = new FrmSubcategory();
            frm.Show();
        }

        private void staticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProfile frmProfile = new FrmProfile();
            frmProfile.Show();
        }
    }
}
