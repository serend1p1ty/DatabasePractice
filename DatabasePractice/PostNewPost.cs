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
    public partial class PostNewPost : Form
    {
        private SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-JAK721P;Initial Catalog=FirstDB;Integrated Security=True");

        public PostNewPost()
        {
            InitializeComponent();
        }

        public PostNewPost(HomePage parent_form)
        {
            InitializeComponent();

            this.Text = "发帖";
            this.Owner = parent_form;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(this.Owner.Location.X,this.Owner.Location.Y);
        }

        // “提交”按钮
        private void ButtonCommit_Click(object sender, EventArgs e)
        {
            sqlCon.Open();

            string sql_cmd = String.Format("insert into Post values('{0}','{1}',getdate(),0,'{2}')",
                                   textBox1.Text, textBox2.Text, ((HomePage)this.Owner).username);
            SqlCommand SqlCmd = new SqlCommand(sql_cmd, sqlCon);
            SqlCmd.ExecuteNonQuery();

            sqlCon.Close();

            textBox2.Clear();
            textBox1.Clear();

            ((HomePage)this.Owner).UpdatePostData();

            MessageBox.Show("发布成功！");
        }

        // 窗口关闭事件
        private void PostNewPost_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Location = new Point(this.Location.X, this.Location.Y);
            this.Owner.Show();
        }
    }
}