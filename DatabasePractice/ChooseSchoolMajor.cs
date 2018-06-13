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
    public partial class ChooseSchoolMajor : Form
    {
        private SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-JAK721P;Initial Catalog=FirstDB;Integrated Security=True");
        private string username;

        public ChooseSchoolMajor()
        {
            InitializeComponent();
        }

        public ChooseSchoolMajor(Login parent_form, string user)
        {
            InitializeComponent();
            username = user;
            this.Owner = parent_form;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(this.Owner.Location.X, this.Owner.Location.Y);
        }

        // “确定”按钮
        private void Ok_Click(object sender, EventArgs e)
        {
            string school_name = ComboBoxSchool.Text;
            string major_name = ComboBoxMajor.Text;

            sqlCon.Open();

            string sql_cmd = String.Format(@"update [user] 
                                            set school_name='{0}', major_name='{1}'
                                            where username='{2}'", school_name, major_name, username);

            SqlCommand SqlCmd = new SqlCommand(sql_cmd, sqlCon);
            SqlCmd.ExecuteNonQuery();

            MessageBox.Show("选择成功，将为您带来和报考专业相关的考研资料。");

            new HomePage((Login)this.Owner, this.Location, username, school_name, major_name).Show();

            this.Close();

            sqlCon.Close();
        }
    }
}
