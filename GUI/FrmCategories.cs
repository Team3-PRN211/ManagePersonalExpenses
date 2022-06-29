﻿using System;
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
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }

        ICategoryRepository categoryRepository = new CategoryRepository();
        ISubCategoryRepository subCategoryRepository = new SubCategoryRepository();
        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            var categories = (from item in categoryRepository.GetAll()
                              select new { item.CategoryId, item.Name,item.Description })
                             .ToList();
            dgvCategory.DataSource = categories;
            txtId.DataBindings.Clear();
            txtId.DataBindings.Add("Text", categories, "CategoryId");

            txtName.DataBindings.Clear();
            txtName.DataBindings.Add("Text", categories, "Name");

            txtDescription.DataBindings.Clear();
            txtDescription.DataBindings.Add("Text", categories, "Description");
        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            FrmAddCategory frmAddCategory = new FrmAddCategory();
            frmAddCategory.Show();
            

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                Category category = new Category { CategoryId = int.Parse(txtId.Text) };
                Category c = categoryRepository.GetCategoryById(category.CategoryId);
                var result = subCategoryRepository.GetAllByCategoryId(category.CategoryId);
                if(result.Count() > 0)
                {
                    MessageBox.Show("Cant not delete");
                    return;
                } 

                if(c != null)
                {
                    categoryRepository.DeleteCategory(c);
                    loadData();
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Fail");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                Category category = new Category { CategoryId = int.Parse(txtId.Text) };
                Category c = categoryRepository.GetCategoryById(category.CategoryId);
                if (c != null)
                {
                    c.Name = txtName.Text;
                    c.Description = txtDescription.Text;
                    categoryRepository.Update(c);
                    MessageBox.Show("Sucess");
                    loadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update");
            }
        }
    }
}
