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
    public partial class Register : Form
    {
        private SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-JAK721P;Initial Catalog=FirstDB;Integrated Security=True");

        public Register()
        {
            InitializeComponent();
        }

        public Register(Login parent_form)
        {
            InitializeComponent();
            this.Owner = parent_form;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(this.Owner.Location.X, this.Owner.Location.Y);
        }

        private void String2NULL(ref string str)
        {
            if (str == "")
                str = "NULL";
            else
            {
                str = str.Insert(0, "'");
                str += "'";
            }
        }

        // 确定按钮
        private void Ok_Click(object sender, EventArgs e)
        {
            string username = TextAccount.Text.Trim();
            string password = TextPasswd.Text.Trim();
            string sex = TextSex.Text.Trim();
            string birthday = TextBirthday.Text.Trim();
            string telephone = TextPhone.Text.Trim();
            string email = TextEmail.Text.Trim();

            String2NULL(ref username);
            String2NULL(ref password);
            String2NULL(ref sex);
            String2NULL(ref birthday);
            String2NULL(ref telephone);
            String2NULL(ref email);

            #region 查询数据库当前账号是否被注册过
            sqlCon.Open();

            string sql_cmd = String.Format("select * from [user] where username={0}", username);
            SqlDataAdapter sda = new SqlDataAdapter(sql_cmd, sqlCon);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("当前账户名已被使用，请重新输入！");
            }
            else
            {
                sql_cmd = String.Format("insert into [user] values({0},{1},{2},{3},{4},{5},0,0,NULL,NULL)",
                                        username, password, sex, birthday, telephone, email);
                SqlCommand SqlCmd = new SqlCommand(sql_cmd, sqlCon);
                SqlCmd.ExecuteNonQuery();
                MessageBox.Show("账号创建成功！");
            }
            TextAccount.Clear();
            TextPasswd.Clear();
            TextSex.Clear();
            TextBirthday.Clear();
            TextPhone.Clear();
            TextEmail.Clear();
            TextAccount.Focus();

            sqlCon.Close();
            #endregion
        }

        // 取消按钮
        private void Cancle_Click(object sender, EventArgs e)
        {
            this.Owner.Location = new Point(this.Location.X, this.Location.Y);
            this.Owner.Show();
            this.Close();
        }

        // 窗口关闭事件
        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Location = new Point(this.Location.X, this.Location.Y);
            this.Owner.Show();
        }
    }
}