namespace DatabasePractice
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.GridViewMajor2Post = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.我的帖子ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.发帖ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MyPostToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.已上传资料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上传资料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.购买资料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MyBookToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.未完成订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.已完成订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChooseInstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MyInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMajor2Post)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridViewMajor2Post
            // 
            this.GridViewMajor2Post.AllowUserToAddRows = false;
            this.GridViewMajor2Post.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewMajor2Post.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridViewMajor2Post.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewMajor2Post.Location = new System.Drawing.Point(65, 116);
            this.GridViewMajor2Post.Name = "GridViewMajor2Post";
            this.GridViewMajor2Post.ReadOnly = true;
            this.GridViewMajor2Post.RowTemplate.Height = 27;
            this.GridViewMajor2Post.Size = new System.Drawing.Size(674, 277);
            this.GridViewMajor2Post.TabIndex = 0;
            this.GridViewMajor2Post.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewMajor2Post_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(240, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "与本专业相关的所有帖子";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.我的帖子ToolStripMenuItem,
            this.已上传资料ToolStripMenuItem,
            this.订单ToolStripMenuItem,
            this.ChooseInstToolStripMenuItem,
            this.MyInfoToolStripMenuItem,
            this.ExitToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // 我的帖子ToolStripMenuItem
            // 
            this.我的帖子ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.发帖ToolStripMenuItem,
            this.MyPostToolStripMenuItem1});
            this.我的帖子ToolStripMenuItem.Name = "我的帖子ToolStripMenuItem";
            this.我的帖子ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.我的帖子ToolStripMenuItem.Text = "帖子";
            // 
            // 发帖ToolStripMenuItem
            // 
            this.发帖ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("发帖ToolStripMenuItem.BackgroundImage")));
            this.发帖ToolStripMenuItem.Name = "发帖ToolStripMenuItem";
            this.发帖ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.发帖ToolStripMenuItem.Text = "发帖";
            this.发帖ToolStripMenuItem.Click += new System.EventHandler(this.NewPostToolStripMenuItem_Click);
            // 
            // MyPostToolStripMenuItem1
            // 
            this.MyPostToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MyPostToolStripMenuItem1.BackgroundImage")));
            this.MyPostToolStripMenuItem1.Name = "MyPostToolStripMenuItem1";
            this.MyPostToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.MyPostToolStripMenuItem1.Text = "我发布的帖子";
            this.MyPostToolStripMenuItem1.Click += new System.EventHandler(this.MyPostToolStripMenuItem1_Click);
            // 
            // 已上传资料ToolStripMenuItem
            // 
            this.已上传资料ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.上传资料ToolStripMenuItem,
            this.购买资料ToolStripMenuItem,
            this.MyBookToolStripMenuItem1});
            this.已上传资料ToolStripMenuItem.Name = "已上传资料ToolStripMenuItem";
            this.已上传资料ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.已上传资料ToolStripMenuItem.Text = "资料";
            // 
            // 上传资料ToolStripMenuItem
            // 
            this.上传资料ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("上传资料ToolStripMenuItem.BackgroundImage")));
            this.上传资料ToolStripMenuItem.Name = "上传资料ToolStripMenuItem";
            this.上传资料ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.上传资料ToolStripMenuItem.Text = "上传资料";
            this.上传资料ToolStripMenuItem.Click += new System.EventHandler(this.UploadBookToolStripMenuItem_Click);
            // 
            // 购买资料ToolStripMenuItem
            // 
            this.购买资料ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("购买资料ToolStripMenuItem.BackgroundImage")));
            this.购买资料ToolStripMenuItem.Name = "购买资料ToolStripMenuItem";
            this.购买资料ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.购买资料ToolStripMenuItem.Text = "购买资料";
            this.购买资料ToolStripMenuItem.Click += new System.EventHandler(this.BuyToolStripMenuItem_Click);
            // 
            // MyBookToolStripMenuItem1
            // 
            this.MyBookToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MyBookToolStripMenuItem1.BackgroundImage")));
            this.MyBookToolStripMenuItem1.Name = "MyBookToolStripMenuItem1";
            this.MyBookToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.MyBookToolStripMenuItem1.Text = "我上传的资料";
            this.MyBookToolStripMenuItem1.Click += new System.EventHandler(this.MyBookToolStripMenuItem1_Click);
            // 
            // 订单ToolStripMenuItem
            // 
            this.订单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.未完成订单ToolStripMenuItem,
            this.已完成订单ToolStripMenuItem});
            this.订单ToolStripMenuItem.Name = "订单ToolStripMenuItem";
            this.订单ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.订单ToolStripMenuItem.Text = "订单";
            // 
            // 未完成订单ToolStripMenuItem
            // 
            this.未完成订单ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("未完成订单ToolStripMenuItem.BackgroundImage")));
            this.未完成订单ToolStripMenuItem.Name = "未完成订单ToolStripMenuItem";
            this.未完成订单ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.未完成订单ToolStripMenuItem.Text = "未完成订单";
            this.未完成订单ToolStripMenuItem.Click += new System.EventHandler(this.MyOrderToolStripMenuItem_Click);
            // 
            // 已完成订单ToolStripMenuItem
            // 
            this.已完成订单ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("已完成订单ToolStripMenuItem.BackgroundImage")));
            this.已完成订单ToolStripMenuItem.Name = "已完成订单ToolStripMenuItem";
            this.已完成订单ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.已完成订单ToolStripMenuItem.Text = "已完成订单";
            this.已完成订单ToolStripMenuItem.Click += new System.EventHandler(this.HistoryOrderToolStripMenuItem_Click);
            // 
            // ChooseInstToolStripMenuItem
            // 
            this.ChooseInstToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ChooseInstToolStripMenuItem.Name = "ChooseInstToolStripMenuItem";
            this.ChooseInstToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.ChooseInstToolStripMenuItem.Text = "找导师";
            this.ChooseInstToolStripMenuItem.Click += new System.EventHandler(this.ChooseInstToolStripMenuItem_Click);
            // 
            // MyInfoToolStripMenuItem
            // 
            this.MyInfoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MyInfoToolStripMenuItem.Name = "MyInfoToolStripMenuItem";
            this.MyInfoToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.MyInfoToolStripMenuItem.Text = "我的信息";
            this.MyInfoToolStripMenuItem.Click += new System.EventHandler(this.MyInfoToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem1
            // 
            this.ExitToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1";
            this.ExitToolStripMenuItem1.Size = new System.Drawing.Size(51, 24);
            this.ExitToolStripMenuItem1.Text = "退出";
            this.ExitToolStripMenuItem1.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridViewMajor2Post);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "HomePage";
            this.Text = "主页";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomePage_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMajor2Post)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewMajor2Post;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem ChooseInstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MyInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 我的帖子ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 已上传资料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 发帖ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MyPostToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 上传资料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 购买资料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 订单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 未完成订单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 已完成订单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MyBookToolStripMenuItem1;
    }
}