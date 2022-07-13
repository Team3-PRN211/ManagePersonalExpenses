using BusinessObject.Models;
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
    public partial class FrmProfile : Form
    {
        public FrmProfile()
        {
            InitializeComponent();
        }
        public FrmProfile(string id)
        {
            InitializeComponent();
            this.Text = id;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        ManagePersonalExpensesContext context = new ManagePersonalExpensesContext();

        private void FrmProfile_Load(object sender, EventArgs e)
        {
          

            var result = context.Users.SingleOrDefault(x => x.UserId == Session.id);
            txtName.Text = result.Fullname;

            txtAccount.Text = result.Account;
            
            if(result.Gender )
            {
                rdMale.Checked = true;
            }
            else
            {
                rdFemale.Checked = true;
            }


            //txtName.DataBindings.Clear();
            //txtName.DataBindings.Add("Text", User, "Fullname");
           // txtAccount.DataBindings.Clear();
            //txtAccount.DataBindings.Add("Text", User, "Account");
            //txtPass.DataBindings.Clear();
            //txtPass.DataBindings.Add("Text", User, "Password");
            
            //txtGen.DataBindings.Add("Text", User, "Gender");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                var user = context.Users.SingleOrDefault(item => item.Account == txtAccount.Text);
                if (user != null)
                {
                    user.Fullname = txtName.Text;
                    //user.Gender = txtGen.Created;

                    int count = context.SaveChanges();
                    if (count > 0)
                    {
                        MessageBox.Show("update success");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("update error: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnChangePW_Click(object sender, EventArgs e)
        {
            FrmChangepassword frmChangepassword = new FrmChangepassword();
            frmChangepassword.Show();
        }
    }
}
