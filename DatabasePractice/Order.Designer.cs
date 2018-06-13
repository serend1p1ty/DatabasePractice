namespace DatabasePractice
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.lv = new System.Windows.Forms.ListView();
            this.label = new System.Windows.Forms.Label();
            this.TextBoxMoney = new System.Windows.Forms.TextBox();
            this.ButtonPay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv
            // 
            this.lv.Location = new System.Drawing.Point(0, 60);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(803, 319);
            this.lv.TabIndex = 0;
            this.lv.UseCompatibleStateImageBehavior = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label.ForeColor = System.Drawing.SystemColors.Info;
            this.label.Location = new System.Drawing.Point(216, 15);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(133, 30);
            this.label.TabIndex = 1;
            this.label.Text = "总金额 =";
            // 
            // TextBoxMoney
            // 
            this.TextBoxMoney.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxMoney.Location = new System.Drawing.Point(383, 12);
            this.TextBoxMoney.Name = "TextBoxMoney";
            this.TextBoxMoney.ReadOnly = true;
            this.TextBoxMoney.Size = new System.Drawing.Size(188, 42);
            this.TextBoxMoney.TabIndex = 2;
            // 
            // ButtonPay
            // 
            this.ButtonPay.BackColor = System.Drawing.Color.Transparent;
            this.ButtonPay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPay.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonPay.ForeColor = System.Drawing.SystemColors.Info;
            this.ButtonPay.Location = new System.Drawing.Point(281, 385);
            this.ButtonPay.Name = "ButtonPay";
            this.ButtonPay.Size = new System.Drawing.Size(219, 53);
            this.ButtonPay.TabIndex = 3;
            this.ButtonPay.Text = "现在去支付";
            this.ButtonPay.UseVisualStyleBackColor = false;
            this.ButtonPay.Click += new System.EventHandler(this.ButtonPay_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonPay);
            this.Controls.Add(this.TextBoxMoney);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Order";
            this.Text = "我的订单";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Order_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox TextBoxMoney;
        public System.Windows.Forms.Button ButtonPay;
    }
}