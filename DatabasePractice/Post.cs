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
    public partial class Post : Form
    {
        private SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-JAK721P;Initial Catalog=FirstDB;Integrated Security=True");
        private int post_id;

        private TextBox ContentBox; // 保存帖子的内容
        private Button ButtonCommit; // “提交”按钮

        private int row_cnt = 0; // 所有控件纵坐标的最大值

        public Post()
        {
            InitializeComponent();
        }

        public Post(HomePage parent_form, int Post_id)
        {
            InitializeComponent();

            #region 通过Post_id查询帖子的内容
            sqlCon.Open();

            string sql_cmd = String.Format(@"select *
                                            from post
                                            where post_id={0}", Post_id);
            SqlCommand SqlCmd = new SqlCommand(sql_cmd, sqlCon);
            SqlDataReader sdr = SqlCmd.ExecuteReader();
            sdr.Read();
            post_id = Post_id;
            string title = sdr[1].ToString();
            string content = sdr[2].ToString();
            string username = sdr[5].ToString();
            sdr.Close();
            #endregion

            #region 帖子的star_count加1
            sql_cmd = String.Format(@"update post set star_count=star_count+1 where post_id={0}", Post_id);
            SqlCmd = new SqlCommand(sql_cmd, sqlCon);
            SqlCmd.ExecuteNonQuery();
            parent_form.UpdatePostData();

            sqlCon.Close();
            #endregion

            this.Text = title;
            this.Owner = parent_form;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(this.Owner.Location.X,this.Owner.Location.Y);

            #region 设置帖子的初始界面

            // 显示贴子的内容
            LabelReleaser.Text = String.Format("[贴主]{0}", username);
            LabelPost.Text = String2MultiLen(content);

            row_cnt = LabelPost.Location.Y + LabelPost.Size.Height;

            #region 显示之前的回复
            sqlCon.Open();

            sql_cmd = String.Format(@"select *
                                    from message
                                    where post_id='{0}'", post_id);
            SqlCmd = new SqlCommand(sql_cmd, sqlCon);
            sdr = SqlCmd.ExecuteReader();
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    string MessageContent = sdr[1].ToString();
                    string user = sdr[3].ToString();

                    Label TempLabelContent = new Label
                    {
                        AutoSize = true,
                        Location = new Point(135, row_cnt + 20),
                        Name = "TempLabelContent",
                        Text = MessageContent,
                        BackColor = Color.Transparent
                    };
                    this.Controls.Add(TempLabelContent);

                    HomePage TempParent = (HomePage)this.Owner;
                    Label TempLabelReleaser = new Label
                    {
                        AutoSize = true,
                        Location = new Point(9, row_cnt + 20),
                        Name = "TempLabelReleaser",
                        Text = String.Format("[跟帖者]{0}", user),
                        BackColor = Color.Transparent
                    };
                    this.Controls.Add(TempLabelReleaser);

                    row_cnt = TempLabelContent.Location.Y + TempLabelContent.Size.Height;
                }
            }

            sqlCon.Close();
            #endregion

            MoveButton2Bottom(ref ButtonPostNewMessage);

            // 创建输入框
            ContentBox = new TextBox
            {
                Name = "ContentBox",
                Size = new Size(395, 100),
                TabIndex = 0,
                Multiline = true,
                Visible = false
            };
            this.Controls.Add(ContentBox);

            // 创建“提交”按钮
            ButtonCommit = new Button
            {
                Name = "ButtonCommit",
                Size = new Size(101, 35),
                Text = "提交",
                Visible = false,
                BackColor = Color.Transparent,
                FlatStyle = FlatStyle.Flat
            };
            ButtonCommit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            ButtonCommit.FlatAppearance.MouseOverBackColor = Color.Transparent;

            this.Controls.Add(ButtonCommit);
            ButtonCommit.Click += new EventHandler(this.ButtonCommit_Click);

            #endregion
        }

        // 将“发表评论”按钮移动到最后一条评论的下面
        private void MoveButton2Bottom(ref Button button)
        {
            button.Location = new Point(button.Location.X, row_cnt + 20);
        }

        // 在最后一条评论下面加一条分界线
        //private void DrawLine()
        //{
        //    Graphics graphics = this.CreateGraphics();
        //    graphics.DrawLine(Pens.Black, 0, row_cnt + 10, 818, row_cnt + 10);
        //}

        // 控制文本每一行最多显示30个字符
        public string String2MultiLen(string str)
        {
            string res = "";
            int cnt = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '\n')
                {
                    res += '\n';
                    cnt = 0;
                    continue;
                }

                if (cnt == 30)
                {
                    res += "\n";
                    res += str[i].ToString();
                    cnt = 0;
                }
                else
                {
                    res += str[i].ToString();
                }
                cnt++;
            }
            return res;
        }

        // 关闭窗口
        private void Post_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Location = new Point(this.Location.X, this.Location.Y);
            this.Owner.Show();
        }

        // “发表评论”按钮
        private void ButtonPostNewMessage_Click(object sender, EventArgs e)
        {
            // 隐藏“发表评论”按钮
            ButtonPostNewMessage.Visible = false;

            // 显示输入框 
            ContentBox.Location = new Point(135, row_cnt + 20);
            ContentBox.Clear();
            ContentBox.Visible = true;
            ContentBox.Focus();

            // 显示提交按钮
            ButtonCommit.Location = new Point(282, row_cnt + 140);
            ButtonCommit.Visible = true;
        }

        // “提交”按钮
        private void ButtonCommit_Click(object sender, EventArgs e)
        {
            string content = ContentBox.Text;
            if (content == "")
            {
                MessageBox.Show("评论不能为空，请重新输入！");
                return;
            }

            ButtonCommit.Visible = false;
            ContentBox.Visible = false;

            Label NewLabelContent = new Label
            {
                AutoSize = true,
                Location = new Point(135, row_cnt + 20),
                Name = "NewLabelContent",
                Text = String2MultiLen(content),
                BackColor = Color.Transparent
            };
            this.Controls.Add(NewLabelContent);

            HomePage parent = (HomePage)this.Owner;
            Label NewLabelReleaser = new Label
            {
                AutoSize = true,
                Location = new Point(9, row_cnt + 20),
                Name = "NewLabelReleaser",
                Text = String.Format("[跟帖者]{0}", parent.username),
                BackColor = Color.Transparent
            };
            this.Controls.Add(NewLabelReleaser);

            // 更新最大行数
            row_cnt = NewLabelContent.Location.Y + NewLabelContent.Size.Height;

            MoveButton2Bottom(ref ButtonPostNewMessage);
            ButtonPostNewMessage.Visible = true;

            #region 将新的评论存入数据库
            sqlCon.Open();
            string sql_cmd = String.Format("insert into message values('{0}',getdate(),'{1}', {2})",
                                   NewLabelContent.Text, parent.username, post_id.ToString());
            SqlCommand SqlCmd = new SqlCommand(sql_cmd, sqlCon);
            SqlCmd.ExecuteNonQuery();
            sqlCon.Close();
            #endregion
        }
    }
}