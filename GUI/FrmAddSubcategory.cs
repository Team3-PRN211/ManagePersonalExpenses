using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject.Models;
using DataAccess.Repository;
namespace GUI
{
    public partial class FrmAddSubcategory : Form
    {
        public FrmAddSubcategory()
        {
            InitializeComponent();
        }
        ISubCategoryRepository subCategoryRepository = new SubCategoryRepository();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SubCategory subcategory = new SubCategory
                {

                    Name = txtName.Text,
                    Description = txtDes.Text,
                    CategoryId = (int)cbCate.SelectedValue,

                };
                subCategoryRepository.InsertSubCategory(subcategory);

                MessageBox.Show("Insert success");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmSubcategory frm = new FrmSubcategory();
            frm.Show();
        }


        private void cbCate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        ManagePersonalExpensesContext context = new ManagePersonalExpensesContext();
        private void FrmAddSubcategory_Load(object sender, EventArgs e)
        {
            var cb = from c in context.Categories
                     select c ;
                cbCate.DataSource = cb.ToList();
                cbCate.DisplayMember = "CategoryId";
                cbCate.ValueMember = "CategoryId";
           
        }
    }
}
