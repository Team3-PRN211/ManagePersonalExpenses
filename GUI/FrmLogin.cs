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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            connectDB();
        }

        SqlConnection cnn;
        SqlDataAdapter da;
        SqlCommand cmd;
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string strselect = "select * from [User] where account='" + txtUsername.Text + "'and password='" + CreateMD5(txtPassword.Text) + "'";
                da = new SqlDataAdapter(strselect, cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    //ton tai du lieu --> login thnh cong
                    MessageBox.Show("Login Successful!", "Alert");
                    string name = Getname(txtUsername.Text);
                    FrmCategories frmcategory = new FrmCategories();
                    frmcategory.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login Fail!", "Alert");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Error :" + ex.Message);
            }
        }
        private string Getname(string text)
        {
            string name = "";
            try
            {
                string strselect = "select * from [User] where account= '" + txtUsername.Text + "'and password='" + txtPassword.Text + "'";
                da = new SqlDataAdapter(strselect, cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    name = dt.Rows[0].ItemArray[2].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("getname error :" + ex.Message);
            }
            return name;
        }
        private void connectDB()
        {
            try
            {
                string strCnn = "server=DESKTOP-671LN6B;database=ManagePersonalExpenses;uid=sa;pwd=123456";
                cnn = new SqlConnection(strCnn);
                cnn.Open();
                // MessageBox.Show("Connect succesfully");
            }
            catch (Exception ex)
            {
                // MessageBox.Show("Connect error :" + ex.Message);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
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
