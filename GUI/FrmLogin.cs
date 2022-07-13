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
                   
                    string name = dt.Rows[0].ItemArray[2].ToString();
                    Session.id = Convert.ToInt32(dt.Rows[0].ItemArray[0].ToString());
                    FrmMain frmMain = new FrmMain();
                    

                    frmMain.Show();
                    this.Hide();
                    FrmIndex frmIndex = new FrmIndex();
                   
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
        
        
        private void connectDB()
        {
            try
            {
                string strCnn = "server=DESKTOP-83LQ6GD\\TRINHNX151;database=ManagePersonalExpenses;uid=trinhnx151;pwd=trinhxq2";
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

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
