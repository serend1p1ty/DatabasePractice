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
    public partial class UploadBook : Form
    {
        private SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-JAK721P;Initial Catalog=FirstDB;Integrated Security=True");
        private string username;

        public UploadBook()
        {
            InitializeComponent();
        }

        public UploadBook(HomePage parent_form)
        {
            InitializeComponent();

            username = parent_form.username; 
            this.Owner = parent_form;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(this.Owner.Location.X, this.Owner.Location.Y);
        }

        // “确定”按钮
        private void ButtonOk_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" ||
                textBox2.Text.Trim() == "" ||
                textBox3.Text.Trim() == "")
            {
                MessageBox.Show("书名/标题/价格不能为空！");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();
                return;
            }

            #region 上传资料
            sqlCon.Open();

            string sql_cmd = String.Format(@"insert into book values
                                            ('{0}',{1},0,'{2}','{3}')", textBox1.Text, textBox2.Text, textBox3.Text, username);
            SqlCommand SqlCmd = new SqlCommand(sql_cmd, sqlCon);
            SqlCmd.ExecuteNonQuery();

            sqlCon.Close();
            #endregion

            MessageBox.Show("上传成功！");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        // 窗口关闭事件
        private void UploadBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Location = new Point(this.Location.X, this.Location.Y);
            this.Owner.Show();
        }
    }
}
