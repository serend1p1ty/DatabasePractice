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
    public partial class ModifyPost : Form
    {
        private SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-JAK721P;Initial Catalog=FirstDB;Integrated Security=True");
        private int post_id;

        public ModifyPost()
        {
            InitializeComponent();
        }

        public ModifyPost(MyPost parent_form, int id)
        {
            InitializeComponent();

            post_id = id;
            this.Owner = parent_form;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(this.Owner.Location.X, this.Owner.Location.Y);

            #region 获得帖子的相关信息
            sqlCon.Open();

            string sql_cmd = String.Format(@"select title,content
                                            from post
                                            where post_id={0}", post_id.ToString());
            SqlCommand SqlCmd = new SqlCommand(sql_cmd, sqlCon);
            SqlDataReader sdr = SqlCmd.ExecuteReader();
            sdr.Read();
            textBox1.Text = sdr[0].ToString();
            textBox2.Text = sdr[1].ToString();
            sdr.Close();

            sqlCon.Close();
            #endregion
        }

        // “修改”按钮
        private void Modify_Click(object sender, EventArgs e)
        {
            sqlCon.Open();

            string sql_cmd = String.Format(@"update post set title='{0}',content='{1}'
                                            where post_id={2}", textBox1.Text, textBox2.Text, post_id.ToString());
            SqlCommand SqlCmd = new SqlCommand(sql_cmd, sqlCon);
            SqlCmd.ExecuteNonQuery();

            sqlCon.Close();

            MessageBox.Show("修改成功！");
            ((MyPost)this.Owner).UpdateData();
            ((HomePage)(((MyPost)this.Owner).Owner)).UpdatePostData();
        }

        // “删除”按钮
        private void Delete_Click(object sender, EventArgs e)
        {
            sqlCon.Open();

            string sql_cmd = String.Format(@"delete from post
                                            where post_id={0}", post_id.ToString());
            SqlCommand SqlCmd = new SqlCommand(sql_cmd, sqlCon);
            SqlCmd.ExecuteNonQuery();

            sqlCon.Close();

            MessageBox.Show("删除成功！");

            Delete.Enabled = false;
            Modify.Enabled = false;

            ((MyPost)this.Owner).UpdateData(); // 更新父窗口的信息
            ((HomePage)(((MyPost)this.Owner).Owner)).UpdatePostData();
        }

        // 窗口关闭事件
        private void ModifyPost_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Location = new Point(this.Location.X, this.Location.Y);
            this.Owner.Show();
        }
    }
}
