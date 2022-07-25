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
    public partial class FrmAddCategory : Form
    {
        public FrmAddCategory()
        {
            InitializeComponent();
        }

        ICategoryRepository categoryRepository = new CategoryRepository();

        private void btnInsert_Click(object sender, EventArgs e)
        {

            try
            {
                Category category = new Category
                {
                    
                    Name = txtName.Text,
                    Description = txtDescription.Text
                   
                };
                categoryRepository.InsertCategory(category);
                FrmCategories frmCategories = new FrmCategories();
                frmCategories.loadData();
                FrmSubcategory s = new FrmSubcategory();
                s.load();
                FrmAddSubcategory f = new FrmAddSubcategory();
                f.LoadData();
                MessageBox.Show("Category has been create Successfully!");
               
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmCategories frm = new FrmCategories();
            frm.Show();
        }

        private void FrmAddCategory_Load(object sender, EventArgs e)
        {

        }
    }
}
