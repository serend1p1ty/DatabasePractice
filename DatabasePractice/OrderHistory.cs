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
    public partial class OrderHistory : Form
    {
        private SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-JAK721P;Initial Catalog=FirstDB;Integrated Security=True");
        private SqlConnection sqlCon2 = new SqlConnection("Data Source=DESKTOP-JAK721P;Initial Catalog=FirstDB;Integrated Security=True");
        private int row_cnt = -10; // 所有控件纵坐标的最大值

        public OrderHistory()
        {
            InitializeComponent();
        }

        public OrderHistory(HomePage parent_form)
        {
            InitializeComponent();

            this.Owner = parent_form;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(this.Owner.Location.X, this.Owner.Location.Y);

            #region 显示历史订单的信息
            sqlCon.Open();
            sqlCon2.Open();

            string sql_cmd = String.Format(@"select order_id,order_money
                                            from [order]
                                            where status=1 and username='{0}'", parent_form.username);
            SqlCommand SqlCmd = new SqlCommand(sql_cmd, sqlCon);
            SqlDataReader sdr = SqlCmd.ExecuteReader();
            while (sdr.Read())
            {
                int id = (int)sdr[0];
                string total_money = sdr[1].ToString();
                string sql_cmd2 = String.Format(@"select book.ISBN,book.title,book.price
                                                from include join book on include.ISBN=book.ISBN
                                                where order_id={0}", id.ToString());
                SqlCommand SqlCmd2 = new SqlCommand(sql_cmd2, sqlCon2);
                SqlDataReader sdr2 = SqlCmd2.ExecuteReader();
                ListViewShowDataReader(sdr2, total_money);
                sdr2.Close();
            }
            sdr.Close();

            sqlCon.Close();
            sqlCon2.Close();
            #endregion
        }

        private int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        // 用listview显示一张订单
        public void ListViewShowDataReader(SqlDataReader sdr, string total_money)
        {
            ListView lv = new ListView
            {
                GridLines = true,
                FullRowSelect = true,
                View = View.Details,
                Scrollable = true,
                MultiSelect = false,
                Location = new Point(100, row_cnt + 10),
                Size = new Size(355, 100),
            };
            this.Controls.Add(lv);
            lv.Columns.Add("书号", 50, HorizontalAlignment.Center);
            lv.Columns.Add("标题", 200, HorizontalAlignment.Center);
            lv.Columns.Add("价格", 100, HorizontalAlignment.Center);
            while (sdr.Read())
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Clear();

                item.SubItems[0].Text = sdr[0].ToString();
                item.SubItems.Add(sdr[1].ToString());
                item.SubItems.Add(sdr[2].ToString());
                lv.Items.Add(item);
            }

            row_cnt += 110; // 因为row_cnt从-10开始，所以加110

            Label NewLabel = new Label
            {
                AutoSize = true,
                Location = new Point(200, row_cnt + 10),
                Text = "订单总价为：",
                BackColor = Color.Transparent,
                ForeColor = Color.PaleGreen
            };
            this.Controls.Add(NewLabel);

            Label NewLabel2 = new Label
            {
                AutoSize = true,
                Location = new Point(300, row_cnt + 10),
                Text = total_money,
                BackColor = Color.Transparent,
                ForeColor = Color.PaleGreen
            };
            this.Controls.Add(NewLabel2);

            // 更新row_cnt的值
            row_cnt = Max(row_cnt, NewLabel.Location.Y + NewLabel.Size.Height);
            row_cnt = Max(row_cnt, NewLabel2.Location.Y + NewLabel2.Size.Height);
        }
        
        // 窗口关闭事件
        private void OrderHistory_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Location = new Point(this.Location.X, this.Location.Y);
            this.Owner.Show();
        }
    }
}
