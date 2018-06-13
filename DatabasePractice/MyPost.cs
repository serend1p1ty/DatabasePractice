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
    public partial class MyPost : Form
    {
        private SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-JAK721P;Initial Catalog=FirstDB;Integrated Security=True");
        private string username;

        public MyPost()
        {
            InitializeComponent();
        }

        public MyPost(HomePage parent_form)
        {
            InitializeComponent();

            username = parent_form.username;
            this.Owner = parent_form;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(this.Owner.Location.X, this.Owner.Location.Y);

            lv.GridLines = true;
            lv.FullRowSelect = true;
            lv.View = View.Details;
            lv.Scrollable = true;
            lv.MultiSelect = false;

            UpdateData();
        }

        // 显示已发布的所有帖子的信息
        public void UpdateData()
        {
            lv.Clear();

            lv.Columns.Add("编号", 50, HorizontalAlignment.Center);
            lv.Columns.Add("标题", 200, HorizontalAlignment.Center);
            lv.Columns.Add("发布时间", 185, HorizontalAlignment.Center);
            
            sqlCon.Open();
            string sql_cmd = String.Format(@"select post_id,title,post_date from post
                                            where username='{0}'", username);
            SqlCommand SqlCmd = new SqlCommand(sql_cmd, sqlCon);
            SqlDataReader sdr = SqlCmd.ExecuteReader();

            while (sdr.Read())
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Clear();

                item.SubItems[0].Text = sdr[0].ToString();
                item.SubItems.Add(sdr[1].ToString());
                item.SubItems.Add(sdr[2].ToString());
                lv.Items.Add(item);
            }
            sqlCon.Close();
        }

        // 双击表格事件
        private void lv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lv.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = lv.SelectedItems;
                ListViewItem lvItem = items[0];
                int post_id = int.Parse(lvItem.SubItems[0].Text);

                this.Hide();
                new ModifyPost(this, post_id).Show();
            } 
        }

        // 窗口关闭事件
        private void MyPost_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Location = new Point(this.Location.X, this.Location.Y);
            this.Owner.Show();
        }
    }
}
