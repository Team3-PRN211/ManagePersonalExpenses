using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmSigup : Form
    {
        public FrmSigup()
        {
            InitializeComponent();
        }

        IUserRepository userRepository = new UserRepository();
        MD5 md5 = MD5.Create();
        public static string CreateMD5(string password)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(password);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                return Convert.ToHexString(hashBytes); // .NET 5 +
                // Convert the byte array to hexadecimal string prior to .NET 5
                // StringBuilder sb = new System.Text.StringBuilder();
                // for (int i = 0; i < hashBytes.Length; i++)
                // {
                //     sb.Append(hashBytes[i].ToString("X2"));
                // }
                // return sb.ToString();
            }
        }
        

        private void btnCreate_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                Fullname = txtFullname.Text,
                Account = txtUsername.Text,
                Password = CreateMD5(txtPassword.Text),
                Gender = rdMale.Checked ? true : false
            };
            try
            {
                userRepository.InsertUser(user);
                MessageBox.Show("Create account successfull!","Alert");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Create account error!" + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dg == DialogResult.Yes)
            //    Application.Exit();
            this.Close();
        }

        private void checkShowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowpass.Checked)
            {
                txtPassword.PasswordChar = (char)0;
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
