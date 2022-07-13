using DataAccess.Repository;
using Microsoft.Data.SqlClient;
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
    public partial class FrmChangepassword : Form
    {
        public FrmChangepassword()
        {
            InitializeComponent();
        }
        SqlConnection conn;
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

        private void btnChangepass_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                string strCnn = "server=DESKTOP-83LQ6GD\\TRINHNX151;database=ManagePersonalExpenses;uid=trinhnx151;pwd=trinhxq2";
                conn = new SqlConnection(strCnn);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_Update";
                cmd.Parameters.Add("@User", SqlDbType.NVarChar).Value = userRepository.GetUserById(Session.id).Account;
                cmd.Parameters.Add("@OldPass", SqlDbType.NVarChar).Value = CreateMD5(txtOldPass.Text);
                cmd.Parameters.Add("@NewPass", SqlDbType.NVarChar).Value = CreateMD5(txtNewpass.Text);
                cmd.Connection = conn;
                conn.Open();
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.GetInt32(0) == 1)
                {
                    //lbOldpassword.ForeColor = System.Drawing.Color.Blue;
                    //lbOldpassword.Text = dr.GetString(1);
                    txtConfirmNewpass.Text = "";
                    txtOldPass.Text = "";
                    txtNewpass.Text = "";
                    txtOldPass.Focus();
                    MessageBox.Show("You have changed password Succesful!", "Alert");

                }
                else
                {
                    //lbOldpassword.ForeColor = System.Drawing.Color.Red;
                    //lbOldpassword.Text = dr.GetString(1);
                    txtOldPass.Focus();
                    txtOldPass.SelectAll();
                    MessageBox.Show("Username or password incorect!", "Alert");
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dg == DialogResult.Yes)
            //{
                
            //}

            this.Close();
        }

        private void checkShowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowpass.Checked)
            {
                txtOldPass.PasswordChar = (char)0;
                txtNewpass.PasswordChar = (char)0;
                txtConfirmNewpass.PasswordChar = (char)0;
            }
            else
            {
                txtOldPass.PasswordChar = '*';
                txtNewpass.PasswordChar = '*';
                txtConfirmNewpass.PasswordChar = '*';
            }
        }
    }
}
