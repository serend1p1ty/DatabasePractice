namespace DatabasePractice
{
    partial class ChooseSchoolMajor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseSchoolMajor));
            this.LabelTitle = new System.Windows.Forms.Label();
            this.ComboBoxSchool = new System.Windows.Forms.ComboBox();
            this.ComboBoxMajor = new System.Windows.Forms.ComboBox();
            this.LabelSchool = new System.Windows.Forms.Label();
            this.LabelMajor = new System.Windows.Forms.Label();
            this.Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.BackColor = System.Drawing.Color.Transparent;
            this.LabelTitle.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelTitle.ForeColor = System.Drawing.SystemColors.Info;
            this.LabelTitle.Location = new System.Drawing.Point(87, 34);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(636, 76);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "第一次登陆，请选择您想要报考的专业。";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboBoxSchool
            // 
            this.ComboBoxSchool.FormattingEnabled = true;
            this.ComboBoxSchool.Items.AddRange(new object[] {
            "复旦大学",
            "华东师范大学"});
            this.ComboBoxSchool.Location = new System.Drawing.Point(275, 144);
            this.ComboBoxSchool.Name = "ComboBoxSchool";
            this.ComboBoxSchool.Size = new System.Drawing.Size(240, 23);
            this.ComboBoxSchool.TabIndex = 1;
            // 
            // ComboBoxMajor
            // 
            this.ComboBoxMajor.FormattingEnabled = true;
            this.ComboBoxMajor.Items.AddRange(new object[] {
            "计算机科学与技术"});
            this.ComboBoxMajor.Location = new System.Drawing.Point(275, 233);
            this.ComboBoxMajor.Name = "ComboBoxMajor";
            this.ComboBoxMajor.Size = new System.Drawing.Size(240, 23);
            this.ComboBoxMajor.TabIndex = 2;
            // 
            // LabelSchool
            // 
            this.LabelSchool.BackColor = System.Drawing.Color.Transparent;
            this.LabelSchool.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelSchool.ForeColor = System.Drawing.SystemColors.Info;
            this.LabelSchool.Location = new System.Drawing.Point(118, 144);
            this.LabelSchool.Name = "LabelSchool";
            this.LabelSchool.Size = new System.Drawing.Size(138, 23);
            this.LabelSchool.TabIndex = 3;
            this.LabelSchool.Text = "选择学校";
            this.LabelSchool.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelMajor
            // 
            this.LabelMajor.BackColor = System.Drawing.Color.Transparent;
            this.LabelMajor.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelMajor.ForeColor = System.Drawing.SystemColors.Info;
            this.LabelMajor.Location = new System.Drawing.Point(118, 233);
            this.LabelMajor.Name = "LabelMajor";
            this.LabelMajor.Size = new System.Drawing.Size(134, 23);
            this.LabelMajor.TabIndex = 4;
            this.LabelMajor.Text = "选择专业";
            this.LabelMajor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ok
            // 
            this.Ok.BackColor = System.Drawing.Color.Transparent;
            this.Ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ok.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Ok.ForeColor = System.Drawing.SystemColors.Info;
            this.Ok.Location = new System.Drawing.Point(348, 326);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 43);
            this.Ok.TabIndex = 5;
            this.Ok.Text = "确定";
            this.Ok.UseVisualStyleBackColor = false;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // ChooseSchoolMajor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.LabelMajor);
            this.Controls.Add(this.LabelSchool);
            this.Controls.Add(this.ComboBoxMajor);
            this.Controls.Add(this.ComboBoxSchool);
            this.Controls.Add(this.LabelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ChooseSchoolMajor";
            this.Text = "选择学校专业";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.ComboBox ComboBoxSchool;
        private System.Windows.Forms.ComboBox ComboBoxMajor;
        private System.Windows.Forms.Label LabelSchool;
        private System.Windows.Forms.Label LabelMajor;
        private System.Windows.Forms.Button Ok;
    }
}