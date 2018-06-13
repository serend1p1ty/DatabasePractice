namespace DatabasePractice
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.TextAccount = new System.Windows.Forms.TextBox();
            this.TextPasswd = new System.Windows.Forms.TextBox();
            this.Ok = new System.Windows.Forms.Button();
            this.Cancle = new System.Windows.Forms.Button();
            this.LabelAccount = new System.Windows.Forms.Label();
            this.LabelPasswd = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextAccount
            // 
            this.TextAccount.BackColor = System.Drawing.SystemColors.Info;
            this.TextAccount.Location = new System.Drawing.Point(297, 146);
            this.TextAccount.Name = "TextAccount";
            this.TextAccount.Size = new System.Drawing.Size(229, 25);
            this.TextAccount.TabIndex = 0;
            // 
            // TextPasswd
            // 
            this.TextPasswd.BackColor = System.Drawing.SystemColors.Info;
            this.TextPasswd.Location = new System.Drawing.Point(297, 276);
            this.TextPasswd.Name = "TextPasswd";
            this.TextPasswd.Size = new System.Drawing.Size(229, 25);
            this.TextPasswd.TabIndex = 1;
            // 
            // Ok
            // 
            this.Ok.BackColor = System.Drawing.Color.Transparent;
            this.Ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ok.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Ok.ForeColor = System.Drawing.SystemColors.Info;
            this.Ok.Location = new System.Drawing.Point(199, 346);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(81, 45);
            this.Ok.TabIndex = 2;
            this.Ok.Text = "登陆";
            this.Ok.UseVisualStyleBackColor = false;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Cancle
            // 
            this.Cancle.BackColor = System.Drawing.Color.Transparent;
            this.Cancle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Cancle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Cancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cancle.ForeColor = System.Drawing.SystemColors.Info;
            this.Cancle.Location = new System.Drawing.Point(363, 346);
            this.Cancle.Name = "Cancle";
            this.Cancle.Size = new System.Drawing.Size(81, 45);
            this.Cancle.TabIndex = 3;
            this.Cancle.Text = "取消";
            this.Cancle.UseVisualStyleBackColor = false;
            this.Cancle.Click += new System.EventHandler(this.Cancle_Click);
            // 
            // LabelAccount
            // 
            this.LabelAccount.BackColor = System.Drawing.Color.Transparent;
            this.LabelAccount.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelAccount.ForeColor = System.Drawing.SystemColors.Info;
            this.LabelAccount.Location = new System.Drawing.Point(195, 146);
            this.LabelAccount.Name = "LabelAccount";
            this.LabelAccount.Size = new System.Drawing.Size(69, 25);
            this.LabelAccount.TabIndex = 4;
            this.LabelAccount.Text = "账号";
            this.LabelAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelPasswd
            // 
            this.LabelPasswd.BackColor = System.Drawing.Color.Transparent;
            this.LabelPasswd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LabelPasswd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelPasswd.ForeColor = System.Drawing.SystemColors.Info;
            this.LabelPasswd.Location = new System.Drawing.Point(195, 276);
            this.LabelPasswd.Name = "LabelPasswd";
            this.LabelPasswd.Size = new System.Drawing.Size(66, 25);
            this.LabelPasswd.TabIndex = 5;
            this.LabelPasswd.Text = "密码";
            this.LabelPasswd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.Transparent;
            this.Register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Register.ForeColor = System.Drawing.SystemColors.Info;
            this.Register.Location = new System.Drawing.Point(541, 346);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(81, 45);
            this.Register.TabIndex = 6;
            this.Register.Text = "注册";
            this.Register.UseVisualStyleBackColor = false;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(358, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 41);
            this.label1.TabIndex = 7;
            this.label1.Text = "登陆";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.LabelPasswd);
            this.Controls.Add(this.LabelAccount);
            this.Controls.Add(this.Cancle);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.TextPasswd);
            this.Controls.Add(this.TextAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "登陆";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Cancle;
        private System.Windows.Forms.Label LabelAccount;
        private System.Windows.Forms.Label LabelPasswd;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TextAccount;
        public System.Windows.Forms.TextBox TextPasswd;
    }
}