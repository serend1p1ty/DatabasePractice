using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DatabasePractice
{
    public partial class MyInfo : Form
    {
        SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-JAK721P;Initial Catalog=FirstDB;Integrated Security=True");

        public MyInfo()
        {
            InitializeComponent();
        }

        public MyInfo(HomePage parent_form)
        {
            InitializeComponent();

            this.Owner = parent_form;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(this.Owner.Location.X, this.Owner.Location.Y);

            #region 获得用户信息
            sqlCon.Open();

            string username = parent_form.username;
            string sql_cmd = String.Format("select * from [user] where username='{0}'", username);
            SqlCommand SqlCmd = new SqlCommand(sql_cmd, sqlCon);
            SqlDataReader sdr = SqlCmd.ExecuteReader();
            sdr.Read();
            textBox1.Text = sdr[0].ToString();
            textBox2.Text = sdr[1].ToString();
            textBox3.Text = sdr[2].ToString();
            textBox4.Text = sdr[3].ToString();
            textBox5.Text = sdr[4].ToString();
            textBox6.Text = sdr[5].ToString();
            textBox7.Text = sdr[6].ToString();
            textBox8.Text = sdr[7].ToString();
            sdr.Close();

            sqlCon.Close();
            #endregion
        }

        // 窗口关闭事件
        private void MyInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Location = new Point(this.Location.X, this.Location.Y);
            this.Owner.Show();
        }

        // “修改”按钮
        private void Modify_Click(object sender, EventArgs e)
        {
            sqlCon.Open();

            string sql_cmd = String.Format(@"update [user] set passwd='{0}',sex='{1}',birthday='{2}',telephone='{3}',
                                            email='{4}'
                                            where username='{5}'", textBox2.Text, textBox3.Text, textBox4.Text,
                                            textBox5.Text,textBox6.Text,textBox1.Text);
            SqlCommand SqlCmd = new SqlCommand(sql_cmd, sqlCon);
            SqlCmd.ExecuteNonQuery();

            sqlCon.Close();

            MessageBox.Show("修改成功！");
        }
    }
}

