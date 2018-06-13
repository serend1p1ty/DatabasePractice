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
    public partial class BookDetail : Form
    {
        private SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-JAK721P;Initial Catalog=FirstDB;Integrated Security=True");
        private string ISBN, title, price, sale_count, username;
        private string HomePageName; // 当前登陆账户的用户名

        public BookDetail()
        {
            InitializeComponent();
        }

        public BookDetail(AllBook parent_form, int book_id)
        {
            InitializeComponent();

            HomePage fa = (HomePage)parent_form.Owner;
            HomePageName = fa.username;

            sqlCon.Open();

            #region 查询图书相关信息
            string sql_cmd = String.Format(@"select ISBN,title,price,sale_count,username
                                            from book
                                            where ISBN={0}", book_id.ToString());
            SqlCommand SqlCmd = new SqlCommand(sql_cmd, sqlCon);
            SqlDataReader sdr;
            sdr = SqlCmd.ExecuteReader();
            sdr.Read();
            ISBN = sdr[0].ToString();
            title = sdr[1].ToString();
            price = sdr[2].ToString();
            sale_count = sdr[3].ToString();
            username = sdr[4].ToString();
            sdr.Close();
            #endregion

            #region 如果这本书在用户的未完成订单里面，则“添加至购物车”按钮应为黑，否则“移出购物车”按钮为黑
            sql_cmd = String.Format(@"select *
                                    from ([user] join [order] on [user].username=[order].username)
                                    join include on [order].order_id=include.order_id
                                    where status=0 and ISBN={0} and [user].username='{1}'", book_id.ToString(), HomePageName);
            SqlCmd = new SqlCommand(sql_cmd, sqlCon);
            sdr = SqlCmd.ExecuteReader();
            ButtonAdd.Enabled = sdr.HasRows ? false : true;
            ButtonCancle.Enabled = sdr.HasRows ? true : false;
            sdr.Close();
            #endregion

            sqlCon.Close();

            this.Text = String.Format("[{0}]的详细信息", title);
            this.Owner = parent_form;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(this.Owner.Location.X, this.Owner.Location.Y);

            TextBoxISBN.Text = ISBN;
            TextBoxTitle.Text = title;
            TextBoxPrice.Text = price;
            TextBoxSale_count.Text = sale_count;
            TextBoxUser.Text = username;
        }

        // “添加至购物车”按钮
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            sqlCon.Open();

            #region 获得订单id
            string sql_cmd = String.Format(@"select order_id
                                            from [user] join [order] on [user].username=[order].username
                                            where [user].username='{0}' and status=0", HomePageName);
            SqlCommand SqlCmd = new SqlCommand(sql_cmd, sqlCon);
            SqlDataReader sdr;
            sdr = SqlCmd.ExecuteReader();

            int order_id;
            if (sdr.HasRows)
            {
                sdr.Read();
                order_id = (int)sdr[0];
                sdr.Close();
            }
            else
            {
                sdr.Close();

                #region 插入一条新的订单记录，状态为“未完成”
                sql_cmd = String.Format("insert into [order] values(getdate(),0,0,'{0}')", HomePageName);
                SqlCmd = new SqlCommand(sql_cmd, sqlCon);
                SqlCmd.ExecuteNonQuery();
                #endregion

                #region 获得新订单的order_id
                sql_cmd = String.Format(@"select order_id
                                        from [user] join [order] on [user].username=[order].username
                                        where [user].username='{0}' and status=0", HomePageName);
                SqlCmd = new SqlCommand(sql_cmd, sqlCon);
                sdr = SqlCmd.ExecuteReader();

                sdr.Read();
                order_id = (int)sdr[0];
                sdr.Close();
                #endregion
            }
            #endregion

            #region 订单中添加一本书
            sql_cmd = String.Format("insert into include values({0},{1})", order_id.ToString(), ISBN);
            SqlCmd = new SqlCommand(sql_cmd, sqlCon);
            SqlCmd.ExecuteNonQuery();
            #endregion

            #region 获得会员等级
            int mem_level;
            sql_cmd = String.Format(@"select mem_level
                                            from [user]
                                            where username='{0}'", HomePageName);
            SqlCmd = new SqlCommand(sql_cmd, sqlCon);
            mem_level = (int)SqlCmd.ExecuteScalar();
            #endregion

            #region 更新订单总额
            sql_cmd = String.Format(@"update [order] set order_money=order_money+{0}
                                    where order_id={1}", (double.Parse(price)*(1-0.1*mem_level)).ToString(), order_id.ToString());
            SqlCmd = new SqlCommand(sql_cmd, sqlCon);
            SqlCmd.ExecuteNonQuery();
            #endregion

            sqlCon.Close();

            ButtonAdd.Enabled = false;
            ButtonCancle.Enabled = true;

            MessageBox.Show("添加购物车成功，您可以在“首页->我的订单”里面查看商品。");
        }

        // “移出购物车”按钮
        private void ButtonCancle_Click(object sender, EventArgs e)
        {
            sqlCon.Open();

            #region 获得订单id
            string sql_cmd = String.Format(@"select order_id
                                            from [user] join [order] on [user].username=[order].username
                                            where [user].username='{0}' and status=0", HomePageName);
            SqlCommand SqlCmd = new SqlCommand(sql_cmd, sqlCon);
            SqlDataReader sdr = SqlCmd.ExecuteReader();
            sdr.Read();
            int order_id = (int)sdr[0];
            sdr.Close();
            #endregion

            #region 从订单中删除这件商品
            sql_cmd = String.Format(@"delete from include where order_id={0} and ISBN={1}", order_id.ToString(), ISBN);
            SqlCmd = new SqlCommand(sql_cmd, sqlCon);
            SqlCmd.ExecuteNonQuery();
            #endregion

            ButtonAdd.Enabled = true;
            ButtonCancle.Enabled = false;

            #region 获得会员等级
            int mem_level;
            sql_cmd = String.Format(@"select mem_level
                                            from [user]
                                            where username='{0}'", HomePageName);
            SqlCmd = new SqlCommand(sql_cmd, sqlCon);
            mem_level = (int)SqlCmd.ExecuteScalar();
            #endregion

            #region 更新订单总额
            sql_cmd = String.Format(@"update [order] set order_money=order_money-{0}
                                    where order_id={1}", (double.Parse(price)*(1-0.1*mem_level)).ToString(), order_id.ToString());
            SqlCmd = new SqlCommand(sql_cmd, sqlCon);
            SqlCmd.ExecuteNonQuery();
            #endregion

            sqlCon.Close();
        }


        // 窗口关闭事件
        private void BookDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Location = new Point(this.Location.X, this.Location.Y);
            this.Owner.Show();
        }
    }
}