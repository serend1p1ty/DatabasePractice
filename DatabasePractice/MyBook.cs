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
    public partial class MyBook : Form
    {
        private SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-JAK721P;Initial Catalog=FirstDB;Integrated Security=True");
        string username;

        public MyBook()
        {
            InitializeComponent();
        }

        public MyBook(HomePage parent_form)
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

        // 显示已上传的所有资料的信息
        public void UpdateData()
        {
            lv.Clear();

            lv.Columns.Add("书号", 90, HorizontalAlignment.Center);
            lv.Columns.Add("标题", 250, HorizontalAlignment.Center);
            
            sqlCon.Open();

            string sql_cmd = String.Format(@"select ISBN,title from book
                                            where username='{0}'", username);
            SqlCommand SqlCmd = new SqlCommand(sql_cmd, sqlCon);
            SqlDataReader sdr = SqlCmd.ExecuteReader();

            while (sdr.Read())
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Clear();

                item.SubItems[0].Text = sdr[0].ToString();
                item.SubItems.Add(sdr[1].ToString());
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
                int book_id = int.Parse(lvItem.SubItems[0].Text);

                this.Hide();
                new DeleteBook(this, book_id).Show();
            } 
        }

        // 窗口关闭事件
        private void MyBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Location = new Point(this.Location.X, this.Location.Y);
            this.Owner.Show();
        }
    }
}
