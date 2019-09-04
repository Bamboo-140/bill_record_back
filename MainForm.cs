using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bill_record
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        #region
        //全局变量区
        public int _userID;     //用户ID
        public string _userName;
        public int _userLevel; //用户等级
        public int _userState = 0;
        public int _userValid = 0;
        public string _connectString="";
        #endregion
        private void MainForm_Load(object sender, EventArgs e)
        {
            using (LoginForm login = new LoginForm())
            {
                login.ShowDialog();
                _connectString = login._connectString;
                _userID = login._userID;
                _userLevel = login._userLevel;
                _userName = login._userName;
                //this.lab_in.Text = _userName;
            }
        }

        private void pic_in_Click(object sender, EventArgs e)
        {
            frm_income income = new frm_income();
                income.Show();      
        }

        private void pic_out_Click(object sender, EventArgs e)
        {
            frm_expend expend = new frm_expend();
            expend.Show();
        }

        private void pic_bill_Click(object sender, EventArgs e)
        {

        }

        private void userManager_Click(object sender, EventArgs e)
        {

        }
    }
}
