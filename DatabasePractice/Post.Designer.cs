namespace DatabasePractice
{
    partial class Post
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Post));
            this.LabelPost = new System.Windows.Forms.Label();
            this.ButtonPostNewMessage = new System.Windows.Forms.Button();
            this.LabelReleaser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelPost
            // 
            this.LabelPost.AutoSize = true;
            this.LabelPost.BackColor = System.Drawing.Color.Transparent;
            this.LabelPost.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelPost.Location = new System.Drawing.Point(180, 9);
            this.LabelPost.Name = "LabelPost";
            this.LabelPost.Size = new System.Drawing.Size(67, 15);
            this.LabelPost.TabIndex = 0;
            this.LabelPost.Text = "帖子内容";
            // 
            // ButtonPostNewMessage
            // 
            this.ButtonPostNewMessage.BackColor = System.Drawing.Color.Transparent;
            this.ButtonPostNewMessage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonPostNewMessage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonPostNewMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPostNewMessage.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonPostNewMessage.Location = new System.Drawing.Point(350, 171);
            this.ButtonPostNewMessage.Name = "ButtonPostNewMessage";
            this.ButtonPostNewMessage.Size = new System.Drawing.Size(101, 35);
            this.ButtonPostNewMessage.TabIndex = 2;
            this.ButtonPostNewMessage.Text = "发表评论";
            this.ButtonPostNewMessage.UseVisualStyleBackColor = false;
            this.ButtonPostNewMessage.Click += new System.EventHandler(this.ButtonPostNewMessage_Click);
            // 
            // LabelReleaser
            // 
            this.LabelReleaser.AutoSize = true;
            this.LabelReleaser.BackColor = System.Drawing.Color.Transparent;
            this.LabelReleaser.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelReleaser.Location = new System.Drawing.Point(12, 9);
            this.LabelReleaser.Name = "LabelReleaser";
            this.LabelReleaser.Size = new System.Drawing.Size(52, 15);
            this.LabelReleaser.TabIndex = 1;
            this.LabelReleaser.Text = "发布者";
            // 
            // Post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonPostNewMessage);
            this.Controls.Add(this.LabelReleaser);
            this.Controls.Add(this.LabelPost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Post";
            this.Text = "kj";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Post_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelPost;
        private System.Windows.Forms.Button ButtonPostNewMessage;
        private System.Windows.Forms.Label LabelReleaser;
    }
}