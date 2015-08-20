namespace MM
{
    partial class FixApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FixApplication));
            this.button_concle = new System.Windows.Forms.Button();
            this.button_submit = new System.Windows.Forms.Button();
            this.tbapnum = new System.Windows.Forms.TextBox();
            this.tbmcategory = new System.Windows.Forms.TextBox();
            this.tbmprice = new System.Windows.Forms.TextBox();
            this.tbmdate = new System.Windows.Forms.TextBox();
            this.tbmagent = new System.Windows.Forms.TextBox();
            this.tbapdeptel = new System.Windows.Forms.TextBox();
            this.tbaptel = new System.Windows.Forms.TextBox();
            this.tbapname = new System.Windows.Forms.TextBox();
            this.tbmname = new System.Windows.Forms.TextBox();
            this.cb_mnum = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.applicant_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.M_Name = new System.Windows.Forms.Label();
            this.InStockNum = new System.Windows.Forms.Label();
            this.tbapdep = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_concle
            // 
            this.button_concle.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_concle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_concle.Location = new System.Drawing.Point(306, 252);
            this.button_concle.Name = "button_concle";
            this.button_concle.Size = new System.Drawing.Size(75, 32);
            this.button_concle.TabIndex = 50;
            this.button_concle.Text = "退 出";
            this.button_concle.UseVisualStyleBackColor = true;
            this.button_concle.Click += new System.EventHandler(this.button_concle_Click);
            // 
            // button_submit
            // 
            this.button_submit.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_submit.Location = new System.Drawing.Point(171, 252);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(75, 32);
            this.button_submit.TabIndex = 49;
            this.button_submit.Text = "提 交";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // tbapnum
            // 
            this.tbapnum.Location = new System.Drawing.Point(415, 89);
            this.tbapnum.Name = "tbapnum";
            this.tbapnum.Size = new System.Drawing.Size(123, 21);
            this.tbapnum.TabIndex = 48;
            // 
            // tbmcategory
            // 
            this.tbmcategory.Location = new System.Drawing.Point(128, 89);
            this.tbmcategory.Name = "tbmcategory";
            this.tbmcategory.Size = new System.Drawing.Size(118, 21);
            this.tbmcategory.TabIndex = 47;
            // 
            // tbmprice
            // 
            this.tbmprice.Location = new System.Drawing.Point(128, 126);
            this.tbmprice.Name = "tbmprice";
            this.tbmprice.Size = new System.Drawing.Size(118, 21);
            this.tbmprice.TabIndex = 46;
            // 
            // tbmdate
            // 
            this.tbmdate.Location = new System.Drawing.Point(128, 164);
            this.tbmdate.Name = "tbmdate";
            this.tbmdate.Size = new System.Drawing.Size(118, 21);
            this.tbmdate.TabIndex = 45;
            // 
            // tbmagent
            // 
            this.tbmagent.Location = new System.Drawing.Point(128, 205);
            this.tbmagent.Name = "tbmagent";
            this.tbmagent.Size = new System.Drawing.Size(118, 21);
            this.tbmagent.TabIndex = 44;
            // 
            // tbapdeptel
            // 
            this.tbapdeptel.Location = new System.Drawing.Point(415, 205);
            this.tbapdeptel.Name = "tbapdeptel";
            this.tbapdeptel.Size = new System.Drawing.Size(123, 21);
            this.tbapdeptel.TabIndex = 43;
            // 
            // tbaptel
            // 
            this.tbaptel.Location = new System.Drawing.Point(415, 126);
            this.tbaptel.Name = "tbaptel";
            this.tbaptel.Size = new System.Drawing.Size(123, 21);
            this.tbaptel.TabIndex = 42;
            // 
            // tbapname
            // 
            this.tbapname.Location = new System.Drawing.Point(415, 50);
            this.tbapname.Name = "tbapname";
            this.tbapname.Size = new System.Drawing.Size(123, 21);
            this.tbapname.TabIndex = 41;
            // 
            // tbmname
            // 
            this.tbmname.Location = new System.Drawing.Point(128, 50);
            this.tbmname.Name = "tbmname";
            this.tbmname.Size = new System.Drawing.Size(118, 21);
            this.tbmname.TabIndex = 40;
            // 
            // cb_mnum
            // 
            this.cb_mnum.FormattingEnabled = true;
            this.cb_mnum.Location = new System.Drawing.Point(128, 16);
            this.cb_mnum.Name = "cb_mnum";
            this.cb_mnum.Size = new System.Drawing.Size(277, 20);
            this.cb_mnum.TabIndex = 39;
            this.cb_mnum.ValueMember = "mNum";
            this.cb_mnum.SelectedIndexChanged += new System.EventHandler(this.cb_mnum_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(45, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 14);
            this.label8.TabIndex = 38;
            this.label8.Text = "经 办 人：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(286, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 14);
            this.label7.TabIndex = 37;
            this.label7.Text = "申请人部门电话：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(290, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 14);
            this.label6.TabIndex = 36;
            this.label6.Text = "申请人部门：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(290, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 14);
            this.label5.TabIndex = 35;
            this.label5.Text = "申请人电话：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(290, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 14);
            this.label4.TabIndex = 34;
            this.label4.Text = "申请人工号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(290, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 14);
            this.label3.TabIndex = 33;
            this.label3.Text = "申请人姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(45, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 32;
            this.label1.Text = "报修日期：";
            // 
            // applicant_name
            // 
            this.applicant_name.AutoSize = true;
            this.applicant_name.BackColor = System.Drawing.Color.Transparent;
            this.applicant_name.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.applicant_name.Location = new System.Drawing.Point(45, 127);
            this.applicant_name.Name = "applicant_name";
            this.applicant_name.Size = new System.Drawing.Size(77, 14);
            this.applicant_name.TabIndex = 31;
            this.applicant_name.Text = "设备价格：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(45, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 30;
            this.label2.Text = "设备类型：";
            // 
            // M_Name
            // 
            this.M_Name.AutoSize = true;
            this.M_Name.BackColor = System.Drawing.Color.Transparent;
            this.M_Name.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.M_Name.Location = new System.Drawing.Point(45, 51);
            this.M_Name.Name = "M_Name";
            this.M_Name.Size = new System.Drawing.Size(77, 14);
            this.M_Name.TabIndex = 29;
            this.M_Name.Text = "设备名称：";
            // 
            // InStockNum
            // 
            this.InStockNum.AutoSize = true;
            this.InStockNum.BackColor = System.Drawing.Color.Transparent;
            this.InStockNum.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InStockNum.Location = new System.Drawing.Point(45, 17);
            this.InStockNum.Name = "InStockNum";
            this.InStockNum.Size = new System.Drawing.Size(77, 14);
            this.InStockNum.TabIndex = 28;
            this.InStockNum.Text = "设备代码：";
            // 
            // tbapdep
            // 
            this.tbapdep.Location = new System.Drawing.Point(415, 164);
            this.tbapdep.Name = "tbapdep";
            this.tbapdep.Size = new System.Drawing.Size(123, 21);
            this.tbapdep.TabIndex = 51;
            // 
            // FixApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MM.Properties.Resources.backGI;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(582, 296);
            this.Controls.Add(this.tbapdep);
            this.Controls.Add(this.button_concle);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.tbapnum);
            this.Controls.Add(this.tbmcategory);
            this.Controls.Add(this.tbmprice);
            this.Controls.Add(this.tbmdate);
            this.Controls.Add(this.tbmagent);
            this.Controls.Add(this.tbapdeptel);
            this.Controls.Add(this.tbaptel);
            this.Controls.Add(this.tbapname);
            this.Controls.Add(this.tbmname);
            this.Controls.Add(this.cb_mnum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.applicant_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.M_Name);
            this.Controls.Add(this.InStockNum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FixApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "报修情况登记";
            this.Load += new System.EventHandler(this.FixApplication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_concle;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.TextBox tbapnum;
        private System.Windows.Forms.TextBox tbmcategory;
        private System.Windows.Forms.TextBox tbmprice;
        private System.Windows.Forms.TextBox tbmdate;
        private System.Windows.Forms.TextBox tbmagent;
        private System.Windows.Forms.TextBox tbapdeptel;
        private System.Windows.Forms.TextBox tbaptel;
        private System.Windows.Forms.TextBox tbapname;
        private System.Windows.Forms.TextBox tbmname;
        private System.Windows.Forms.ComboBox cb_mnum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label applicant_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label M_Name;
        private System.Windows.Forms.Label InStockNum;
        private System.Windows.Forms.TextBox tbapdep;
    }
}