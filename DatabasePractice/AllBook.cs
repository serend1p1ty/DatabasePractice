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
    public partial class AllBook : Form
    {
        private SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-JAK721P;Initial Catalog=FirstDB;Integrated Security=True");

        public AllBook()
        {
            InitializeComponent();
        }

        public AllBook(HomePage parent_form, string major_name)
        {
            InitializeComponent();

            this.Text = String.Format("[{0}]相关的资料", major_name);
            this.Owner = parent_form;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(this.Owner.Location.X, this.Owner.Location.Y);

            #region 显示所有书籍
            sqlCon.Open();
            string sql_cmd = String.Format(@"select ISBN,title,sale_count
                                            from [user] join book on [user].username=book.username
                                            where [user].major_name='{0}'
                                            order by sale_count desc,ISBN", major_name);
            SqlCommand SqlCmd = new SqlCommand(sql_cmd, sqlCon);
            SqlDataReader sda = SqlCmd.ExecuteReader();
            if (sda.HasRows)
            {
                ListView.GridLines = true;
                ListView.FullRowSelect = true;
                ListView.View = View.Details;
                ListView.Scrollable = true;
                ListView.MultiSelect = false;

                ListView.Columns.Add("书号", 140, HorizontalAlignment.Center);
                ListView.Columns.Add("标题", 225, HorizontalAlignment.Center);
                ListView.Columns.Add("销量", 215, HorizontalAlignment.Center);
                while (sda.Read())
                {
                    ListViewItem temp = new ListViewItem();
                    temp.SubItems.Clear();
                    temp.SubItems[0].Text = sda[0].ToString();
                    temp.SubItems.Add(sda[1].ToString());
                    temp.SubItems.Add(sda[2].ToString());
                    ListView.Items.Add(temp);
                }
            }
            sqlCon.Close();
            #endregion
        }

        // 窗口关闭事件
        private void BuyBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Location = new Point(this.Location.X, this.Location.Y);
            this.Owner.Show();
        }

        // 双击表格事件
        private void ListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ListView.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = ListView.SelectedItems;
                ListViewItem lvItem = items[0];
                int ISBN = int.Parse(lvItem.SubItems[0].Text);

                this.Hide();
                new BookDetail(this, ISBN).Show();
            } 
        }
    }
}