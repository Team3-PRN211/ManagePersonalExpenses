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

        private void pbRecord_Click(object sender, EventArgs e)
        {
            FrmRecords frmRecords = new FrmRecords();
            frmRecords.Show();
        }

        private void pbProfile_Click(object sender, EventArgs e)
        {
            FrmProfile frmProfile = new FrmProfile();
            frmProfile.Show();
        }

        private void pbStatictis_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
        }

        private void pbSubCategory_Click(object sender, EventArgs e)
        {
            FrmSubcategory frm = new FrmSubcategory();
            frm.Show();
        }

        private void pbCategory_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes) {

                Application.Exit();
            }
        }
                

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
        }
    }
}
