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
    public partial class ChooseInstructor : Form
    {
        private SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-JAK721P;Initial Catalog=FirstDB;Integrated Security=True");

        public ChooseInstructor()
        {
            InitializeComponent();
        }

        public ChooseInstructor(HomePage parent_form)
        {
            InitializeComponent();

            this.Text = String.Format("寻找导师");
            this.Owner = parent_form;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(this.Owner.Location.X, this.Owner.Location.Y);
        }

        // 检测到了下拉选择框文本的变化
        private void ComboBoxArea_TextChanged(object sender, EventArgs e)
        {
            ListViewInst.Clear();

            #region 显示当前方向的导师信息
            ListViewInst.GridLines = true;
            ListViewInst.FullRowSelect = true;
            ListViewInst.View = View.Details;
            ListViewInst.Scrollable = true;
            ListViewInst.MultiSelect = false;

            ListViewInst.Columns.Add("姓名", 50, HorizontalAlignment.Center);
            ListViewInst.Columns.Add("职称", 100, HorizontalAlignment.Center);
            ListViewInst.Columns.Add("性别", 50, HorizontalAlignment.Center);
            ListViewInst.Columns.Add("电话", 100, HorizontalAlignment.Center);
            ListViewInst.Columns.Add("地址", 100, HorizontalAlignment.Center);
            ListViewInst.Columns.Add("邮箱", 100, HorizontalAlignment.Center);
            ListViewInst.Columns.Add("个人主页", 70, HorizontalAlignment.Center);

            sqlCon.Open();

            string school_name = ((HomePage)this.Owner).school_name;
            string major_name = ((HomePage)this.Owner).major_name;
            string area = ComboBoxArea.Text;
            string sql_cmd = String.Format(@"select name,prof_title,sex,telephone,address,email,homepage from area,engage,instructor 
                                            where area.area_id = engage.area_id and 
                                            engage.instructor_id = instructor.instructor_id
                                            and instructor.school_name = '{0}' and instructor.major_name = '{1}'
                                            and area.area_name = '{2}'", school_name, major_name, area);
            SqlCommand SqlCmd = new SqlCommand(sql_cmd, sqlCon);
            SqlDataReader sdr = SqlCmd.ExecuteReader();
            while (sdr.Read())
            {
                ListViewItem item = new ListViewItem();
　　　　　　　   item.SubItems.Clear();

                item.SubItems[0].Text = sdr[0].ToString();
                item.SubItems.Add(sdr[1].ToString());
                item.SubItems.Add(sdr[2].ToString());
                item.SubItems.Add(sdr[3].ToString());
                item.SubItems.Add(sdr[4].ToString());
                item.SubItems.Add(sdr[5].ToString());
                item.SubItems.Add(sdr[6].ToString());
                ListViewInst.Items.Add(item);
            }
            sdr.Close();

            sqlCon.Close();
            #endregion
        }

        // 窗口关闭事件
        private void ChooseInstructor_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Location = new Point(this.Location.X, this.Location.Y);
            this.Owner.Show();
        }
    }
}