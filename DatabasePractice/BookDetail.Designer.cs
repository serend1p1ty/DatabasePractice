namespace DatabasePractice
{
    partial class BookDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookDetail));
            this.TextBoxISBN = new System.Windows.Forms.TextBox();
            this.TextBoxTitle = new System.Windows.Forms.TextBox();
            this.TextBoxPrice = new System.Windows.Forms.TextBox();
            this.TextBoxSale_count = new System.Windows.Forms.TextBox();
            this.TextBoxUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonCancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxISBN
            // 
            this.TextBoxISBN.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxISBN.Location = new System.Drawing.Point(144, 33);
            this.TextBoxISBN.Name = "TextBoxISBN";
            this.TextBoxISBN.ReadOnly = true;
            this.TextBoxISBN.Size = new System.Drawing.Size(265, 30);
            this.TextBoxISBN.TabIndex = 0;
            // 
            // TextBoxTitle
            // 
            this.TextBoxTitle.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxTitle.Location = new System.Drawing.Point(144, 107);
            this.TextBoxTitle.Name = "TextBoxTitle";
            this.TextBoxTitle.ReadOnly = true;
            this.TextBoxTitle.Size = new System.Drawing.Size(265, 30);
            this.TextBoxTitle.TabIndex = 1;
            // 
            // TextBoxPrice
            // 
            this.TextBoxPrice.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxPrice.Location = new System.Drawing.Point(144, 190);
            this.TextBoxPrice.Name = "TextBoxPrice";
            this.TextBoxPrice.ReadOnly = true;
            this.TextBoxPrice.Size = new System.Drawing.Size(265, 30);
            this.TextBoxPrice.TabIndex = 2;
            // 
            // TextBoxSale_count
            // 
            this.TextBoxSale_count.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxSale_count.Location = new System.Drawing.Point(144, 276);
            this.TextBoxSale_count.Name = "TextBoxSale_count";
            this.TextBoxSale_count.ReadOnly = true;
            this.TextBoxSale_count.Size = new System.Drawing.Size(265, 30);
            this.TextBoxSale_count.TabIndex = 3;
            // 
            // TextBoxUser
            // 
            this.TextBoxUser.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxUser.Location = new System.Drawing.Point(144, 367);
            this.TextBoxUser.Name = "TextBoxUser";
            this.TextBoxUser.ReadOnly = true;
            this.TextBoxUser.Size = new System.Drawing.Size(265, 30);
            this.TextBoxUser.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(53, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "书号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(53, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "标题";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(53, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "价格";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(53, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "销量";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(53, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "作者";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.Transparent;
            this.ButtonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonAdd.ForeColor = System.Drawing.SystemColors.Info;
            this.ButtonAdd.Location = new System.Drawing.Point(509, 136);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(198, 58);
            this.ButtonAdd.TabIndex = 10;
            this.ButtonAdd.Text = "加入购物车";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonCancle
            // 
            this.ButtonCancle.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCancle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonCancle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancle.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonCancle.ForeColor = System.Drawing.SystemColors.Info;
            this.ButtonCancle.Location = new System.Drawing.Point(509, 241);
            this.ButtonCancle.Name = "ButtonCancle";
            this.ButtonCancle.Size = new System.Drawing.Size(198, 58);
            this.ButtonCancle.TabIndex = 11;
            this.ButtonCancle.Text = "移出购物车";
            this.ButtonCancle.UseVisualStyleBackColor = false;
            this.ButtonCancle.Click += new System.EventHandler(this.ButtonCancle_Click);
            // 
            // BookDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonCancle);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxUser);
            this.Controls.Add(this.TextBoxSale_count);
            this.Controls.Add(this.TextBoxPrice);
            this.Controls.Add(this.TextBoxTitle);
            this.Controls.Add(this.TextBoxISBN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "BookDetail";
            this.Text = "书籍详情";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BookDetail_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxISBN;
        private System.Windows.Forms.TextBox TextBoxTitle;
        private System.Windows.Forms.TextBox TextBoxPrice;
        private System.Windows.Forms.TextBox TextBoxSale_count;
        private System.Windows.Forms.TextBox TextBoxUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonCancle;
    }
}