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
    public partial class DeleteBook : Form
    {
        private SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-JAK721P;Initial Catalog=FirstDB;Integrated Security=True");
        private int ISBN;

        public DeleteBook()
        {
            InitializeComponent();
        }

        public DeleteBook(MyBook parent_form, int book_id)
        {
            InitializeComponent();

            ISBN = book_id;
            this.Owner = parent_form;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(this.Owner.Location.X, this.Owner.Location.Y);

            #region 查询图书相关信息
            sqlCon.Open();

            string sql_cmd = String.Format(@"select ISBN,title,download_link
                                            from book
                                            where ISBN={0}", book_id.ToString());
            SqlCommand SqlCmd = new SqlCommand(sql_cmd, sqlCon);
            SqlDataReader sdr;
            sdr = SqlCmd.ExecuteReader();
            sdr.Read();
            textBox1.Text = sdr[0].ToString();
            textBox2.Text = sdr[1].ToString();
            textBox3.Text = sdr[2].ToString();
            sdr.Close();

            sqlCon.Close();
            #endregion
        }

        // 窗口关闭事件
        private void DeleteBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Location = new Point(this.Location.X, this.Location.Y);
            this.Owner.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            sqlCon.Open();

            string sql_cmd = String.Format(@"delete from book
                                            where ISBN={0}", ISBN.ToString());
            SqlCommand SqlCmd = new SqlCommand(sql_cmd, sqlCon);
            SqlCmd.ExecuteNonQuery();

            sqlCon.Close();

            MessageBox.Show("删除成功！");
            Delete.Enabled = false;
            ((MyBook)this.Owner).UpdateData(); // 更新父窗口信息
        }
    }
}