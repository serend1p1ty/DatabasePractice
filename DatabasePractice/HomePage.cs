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
    public partial class HomePage : Form
    {
        SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-JAK721P;Initial Catalog=FirstDB;Integrated Security=True");
        public string username;
        public string school_name;
        public string major_name;

        public HomePage()
        {
            InitializeComponent();
        }

        public HomePage(Login parent_form, Point p, string user, string school, string major)
        {
            InitializeComponent();

            username = user;
            school_name = school;
            major_name = major;

            this.Text = String.Format("您选择的专业是：{0}--{1}", school_name, major_name);
            this.Owner = parent_form;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = p;

            sqlCon.Open();

            UpdatePostData();

            sqlCon.Close();
        }

        // 显示本专业所有帖子的信息
        public void UpdatePostData()
        {
            // 执行存储过程
            SqlCommand SqlCmd = new SqlCommand("major2post", sqlCon)
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlCmd.Parameters.Add("@school_name",SqlDbType.VarChar);
            SqlCmd.Parameters["@school_name"].Value = school_name;
            SqlCmd.Parameters.Add("@major_name",SqlDbType.VarChar);
            SqlCmd.Parameters["@major_name"].Value = major_name;

            SqlDataAdapter sda = new SqlDataAdapter(SqlCmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            GridViewMajor2Post.DataSource = ds.Tables[0];
        }

        // “退出”按钮
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // 窗口关闭事件
        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Location = new Point(this.Location.X, this.Location.Y);
            ((Login)this.Owner).TextAccount.Clear();
            ((Login)this.Owner).TextPasswd.Clear();
            ((Login)this.Owner).TextAccount.Focus();
            this.Owner.Show();
        }

        // 双击表格事件
        private void GridViewMajor2Post_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex, col = e.ColumnIndex;
            if (col != 1)
                return;
            int post_id = (int)GridViewMajor2Post.Rows[row].Cells[0].Value;
            this.Hide();
            new Post(this, post_id).Show();
        }

        // “购买资料”按钮
        private void BuyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AllBook(this, major_name).Show();
        }

        // “我的订单”按钮
        private void MyOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Order(this).Show();
        }

        // “我的信息”按钮
        private void MyInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MyInfo(this).Show();
        }

        // “寻找导师”按钮
        private void ChooseInstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ChooseInstructor(this).Show();
        }

        // “发帖”按钮
        private void NewPostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PostNewPost(this).Show();
        }

        // “历史订单”按钮
        private void HistoryOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new OrderHistory(this).Show();
        }

        // “上传资料”按钮
        private void UploadBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UploadBook(this).Show();
        }

        // “我的帖子”按钮
        private void MyPostToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MyPost(this).Show();
        }

        // “已上传资料”按钮
        private void MyBookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MyBook(this).Show();
        }
    }
}