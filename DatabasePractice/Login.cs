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

namespace DatabasePractice
{
    public partial class Login : Form
    {
        private SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-JAK721P;Initial Catalog=FirstDB;Integrated Security=True");
        private int error_cnt; // 记录错误次数

        public Login()
        {
            InitializeComponent();
            
            // 登陆界面显示在屏幕中央
            this.StartPosition = FormStartPosition.CenterScreen;

            error_cnt = 0;
        }

        // 登陆按钮
        private void Ok_Click(object sender, EventArgs e)
        {
            if (error_cnt == 3)
            {
                MessageBox.Show("账号或密码错误次数已达3次，无法登陆！");
                TextAccount.Clear();
                TextPasswd.Clear();
                TextAccount.Focus();
                return;
            }

            string username = TextAccount.Text.Trim();
            string password = TextPasswd.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("账户或密码为空，请重新输入！");
                TextAccount.Clear();
                TextPasswd.Clear();
                TextAccount.Focus();
                return;
            }

            #region 检测账号密码是否正确
            sqlCon.Open();

            string sql_cmd = String.Format(@"select *
                                            from [user]
                                            where username='{0}' and passwd='{1}'"
                                            , username, password);
            SqlCommand SqlCmd = new SqlCommand(sql_cmd, sqlCon);
            SqlDataReader sdr = SqlCmd.ExecuteReader();

            if (sdr.HasRows)  
            {
                MessageBox.Show("登陆成功！");
                error_cnt = 0;
                this.Hide();

                sdr.Read();
                if (sdr["school_name"] == DBNull.Value)
                {
                    new ChooseSchoolMajor(this, username).Show();
                }
                else
                {
                    new HomePage(this, this.Location, username, 
                                (string)sdr["school_name"], (string)sdr["major_name"]).Show();
                }
            }
            else 
            {
                error_cnt++;
                MessageBox.Show("用户名或密码错误，请重新输入，您还有" + Convert.ToString(3 - error_cnt) + "次机会！");
                TextAccount.Clear();
                TextPasswd.Clear();
                TextAccount.Focus();
            }
            sdr.Close();

            sqlCon.Close();
            #endregion
        }

        // 取消按钮
        private void Cancle_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // 注册按钮
        private void Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Register(this).Show();
        }

        //private void Login_Load(object sender, EventArgs e)
        //{
        //    //new HomePage(this, this.Location, "fd1", 
        //    //            "复旦大学", "计算机科学与技术").Show();
        //}
    }
}