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
    public partial class Order : Form
    {
        private SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-JAK721P;Initial Catalog=FirstDB;Integrated Security=True");
        public string total_money = "";

        public Order()
        {
            InitializeComponent();
        }

        public Order(HomePage parent_form)
        {
            InitializeComponent();

            string username = parent_form.username; 
            this.Text = String.Format("[{0}]的订单", username);
            this.Owner = parent_form;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(this.Owner.Location.X, this.Owner.Location.Y);

            #region 显示用户的未完成订单
            lv.GridLines = true;
            lv.FullRowSelect = true;
            lv.View = View.Details;
            lv.Scrollable = true;
            lv.MultiSelect = false;

            lv.Columns.Add("书号", 150, HorizontalAlignment.Center);
            lv.Columns.Add("标题", 225, HorizontalAlignment.Center);
            lv.Columns.Add("价格", 220, HorizontalAlignment.Center);

            sqlCon.Open();

            string sql_cmd = String.Format(@"select book.ISBN,title,price,[order].order_money,[user].mem_level
                                            from (([user] join [order] on [user].username=[order].username)
                                            join include on [order].order_id=include.order_id) join book on
                                            include.ISBN=book.ISBN
                                            where status=0 and [user].username='{0}'", username);
            SqlCommand SqlCmd = new SqlCommand(sql_cmd, sqlCon);
            SqlDataReader sdr = SqlCmd.ExecuteReader();
            total_money = "";
            int level = 0;

            ButtonPay.Enabled = sdr.HasRows;

            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Clear();

                    item.SubItems[0].Text = sdr[0].ToString();
                    item.SubItems.Add(sdr[1].ToString());
                    item.SubItems.Add(sdr[2].ToString());
                    lv.Items.Add(item);

                    total_money = sdr[3].ToString();
                    level = int.Parse(sdr[4].ToString());
                }
            }
            sdr.Close();

            sqlCon.Close();
            #endregion

            TextBoxMoney.Text = total_money;
        }

        // 窗口关闭界面
        private void Order_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Location = new Point(this.Location.X, this.Location.Y);
            this.Owner.Show();
        }

        // 显示支付页面
        private void ButtonPay_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PaySuccess(this).Show();
        }
    }
}