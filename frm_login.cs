using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;


namespace bill_record
{

    public partial class LoginForm : Form
    {  
        #region
         //全局变量区
         public int _userID;     //用户ID
         public string _userName;
         public int _userLevel ; //用户等级
         public int _loginState = 0;
         public bool _userValid;
         public string _connectString = ConfigurationManager.ConnectionStrings["mycon"].ToString();           // "Data Source = .;Initial Catalog = DataStorage;User ID = sa;Password = wuti5zhu";
        #endregion

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            StringBuilder queryText = new StringBuilder();
           // if(txt_username.Text.Equals(string.IsNullOrWhiteSpace()))
            queryText.AppendFormat("SELECT " +
                "                           acc_uname as userName," +
                "                           acc_ulevel as userLevel," +
                "                           acc_uid as userID," +
                "                           acc_uvalid as userValid" +
                "                    FROM tbl_access " +
                "                    WHERE " +                  
                                    "acc_uid = {0} " +
                                    "AND acc_uvalid = 1 " +
                                    "AND acc_ustate = 0 " +
                                    "AND acc_upassword = '{1}' ",
                (string.IsNullOrWhiteSpace(txt_username.Text)?"(-1)":txt_username.Text),txt_password.Text);
            using (SqlConnection connect = new SqlConnection(_connectString))
            {
                if (connect.State != ConnectionState.Open)
                    try
                    {
                        connect.Open();
                    }
                    catch
                    {
                        MessageBox.Show("数据通信错误！","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                using (SqlCommand com = new SqlCommand(queryText.ToString(), connect))
                {
                    SqlDataReader dReader = com.ExecuteReader();
                    if (dReader.HasRows)
                    {
                        dReader.Read();
                        _userName = dReader.GetString(dReader.GetOrdinal("userName"));
                        _userLevel = dReader.GetInt32(dReader.GetOrdinal("userLevel"));
                        _userID = dReader.GetInt32(dReader.GetOrdinal("userID"));
                        _userValid = dReader.GetBoolean(dReader.GetOrdinal("userValid"));
                        _loginState = 1;
                        this.Close();
                    }
                    else
                    {
                        _loginState = 0;
                        MessageBox.Show("登录失败，请校验ID及密码！","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                connect.Close();
            }
          
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //this.btn_submit.Text = "登录";
            //this.btn_cancel.Text = "取消";
            //this.label1.Text = "用户ID：";
            //this.label2.Text = "密  码：";
            
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_loginState == 0)
                Application.Exit();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
