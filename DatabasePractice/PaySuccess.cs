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
    public partial class PaySuccess : Form
    {
        private SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-JAK721P;Initial Catalog=FirstDB;Integrated Security=True");
        private SqlConnection sqlCon2 = new SqlConnection("Data Source=DESKTOP-JAK721P;Initial Catalog=FirstDB;Integrated Security=True");

        public PaySuccess()
        {
            InitializeComponent();
        }

        public PaySuccess(Order parent_form)
        {
            InitializeComponent();

            this.Text = String.Format("支付页面");
            this.Owner = parent_form;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(this.Owner.Location.X, this.Owner.Location.Y);

            #region 显示已购买书籍的下载链接
            lv.GridLines = true;
            lv.FullRowSelect = true;
            lv.View = View.Details;
            lv.Scrollable = true;
            lv.MultiSelect = false;

            lv.Columns.Add("下载链接", 340, HorizontalAlignment.Center);
            lv.Columns.Add("标题", 200, HorizontalAlignment.Center);

            sqlCon.Open();

            string username = ((HomePage)parent_form.Owner).username;
            string sql_cmd = String.Format(@"select download_link,title,book.ISBN
                                            from (([user] join [order] on [user].username=[order].username)
                                            join include on [order].order_id=include.order_id) join book on
                                            include.ISBN=book.ISBN
                                            where status=0 and [user].username='{0}'", username);
            SqlCommand SqlCmd = new SqlCommand(sql_cmd, sqlCon);
            SqlDataReader sdr = SqlCmd.ExecuteReader();
            while (sdr.Read())
            {
                ListViewItem item = new ListViewItem();
　　　　　　　   item.SubItems.Clear();

                item.SubItems[0].Text = sdr[0].ToString();
                item.SubItems.Add(sdr[1].ToString());

                lv.Items.Add(item);

                sqlCon2.Open();
                sql_cmd = String.Format(@"update book set sale_count=sale_count+1
                                        where ISBN={0}", sdr[2].ToString());
                SqlCommand SqlCmd2 = new SqlCommand(sql_cmd, sqlCon2);
                SqlCmd2.ExecuteNonQuery();
                sqlCon2.Close();
            }
            sdr.Close();
            #endregion

            #region 更新会员积分，会员等级。修改订单状态为完成
            SqlCmd = new SqlCommand("UpdateInfo", sqlCon)
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlCmd.Parameters.Add("@p1",SqlDbType.Int);
            SqlCmd.Parameters["@p1"].Value = (int)(double.Parse(parent_form.total_money));
            SqlCmd.Parameters.Add("@p2",SqlDbType.VarChar);
            SqlCmd.Parameters["@p2"].Value = username;
            SqlCmd.ExecuteNonQuery(); 

            sql_cmd = String.Format(@"select score,mem_level 
                                    from [user]
                                    where username='{0}'", username);
            SqlCmd = new SqlCommand(sql_cmd, sqlCon);
            sdr = SqlCmd.ExecuteReader();
            sdr.Read();
            MessageBox.Show("支付成功！您现在的积分：" + sdr[0].ToString() + "，会员等级：" + sdr[1].ToString());
            sdr.Close();

            sqlCon.Close();
            #endregion
        }

        // 窗口关闭事件
        private void PaySuccess_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Location = new Point(this.Location.X, this.Location.Y);
            ((Order)this.Owner).ButtonPay.Enabled = false;
            this.Owner.Show();
        }
    }
}