namespace DatabasePractice
{
    partial class ChooseInstructor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseInstructor));
            this.ComboBoxArea = new System.Windows.Forms.ComboBox();
            this.ListViewInst = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComboBoxArea
            // 
            this.ComboBoxArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxArea.FormattingEnabled = true;
            this.ComboBoxArea.Items.AddRange(new object[] {
            "计算机视觉",
            "自然语言处理",
            "机器学习"});
            this.ComboBoxArea.Location = new System.Drawing.Point(318, 29);
            this.ComboBoxArea.Name = "ComboBoxArea";
            this.ComboBoxArea.Size = new System.Drawing.Size(293, 23);
            this.ComboBoxArea.TabIndex = 0;
            this.ComboBoxArea.TextChanged += new System.EventHandler(this.ComboBoxArea_TextChanged);
            // 
            // ListViewInst
            // 
            this.ListViewInst.Location = new System.Drawing.Point(57, 78);
            this.ListViewInst.Name = "ListViewInst";
            this.ListViewInst.Size = new System.Drawing.Size(684, 315);
            this.ListViewInst.TabIndex = 1;
            this.ListViewInst.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(132, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "您选择的方向是：";
            // 
            // ChooseInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListViewInst);
            this.Controls.Add(this.ComboBoxArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ChooseInstructor";
            this.Text = "选择导师";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChooseInstructor_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxArea;
        private System.Windows.Forms.ListView ListViewInst;
        private System.Windows.Forms.Label label1;
    }
}