namespace MM
{
    partial class InStockModify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InStockModify));
            this.cbMName = new System.Windows.Forms.ComboBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.InStock_Concle = new System.Windows.Forms.Button();
            this.btModify = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.applicant_name = new System.Windows.Forms.Label();
            this.M_Name = new System.Windows.Forms.Label();
            this.InStockNum = new System.Windows.Forms.Label();
            this.cbMNum = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbMName
            // 
            this.cbMName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbMName.FormattingEnabled = true;
            this.cbMName.Items.AddRange(new object[] {
            "电脑",
            "路由器",
            "硒鼓",
            "硬盘",
            "显示器",
            "电脑配件",
            "传真机",
            "复印机",
            "扫描仪",
            "碎纸机",
            "照相机",
            "通讯工具",
            "椅子",
            "柜子",
            "沙发",
            "验钞机",
            "电源",
            "存储器",
            "饮水机",
            "照相机",
            "交换机",
            "摄像机",
            "验钞机",
            "点钞机",
            "装订器",
            "读卡器",
            "查验设备",
            "条码设备",
            "音响",
            "音箱",
            "调音台",
            "话筒",
            "反馈调制器",
            "数字均衡器",
            "效果机",
            "DVD机",
            "屏蔽器",
            "投影仪",
            "幕布",
            "伸缩架",
            "中控",
            "机柜",
            "电源时序器",
            "录音笔",
            "服务器",
            "空调",
            "考勤机",
            "消毒柜",
            "纤检设备",
            "SFP激光设备",
            "核心交换主板",
            "电冰箱",
            "装饰牌",
            "电视",
            "影音传输器",
            "UPS",
            "稳压器",
            "微波炉",
            "数据采集器",
            "LED屏",
            "吊牌",
            "触摸屏",
            "调制解调器",
            "打卡机",
            "检测仪",
            "商务通",
            "雕刻机",
            "刻录笔",
            "班台",
            "衣架",
            "门",
            "镜子",
            "密集架",
            "房屋",
            "车辆",
            "其他"});
            this.cbMName.Location = new System.Drawing.Point(202, 66);
            this.cbMName.Name = "cbMName";
            this.cbMName.Size = new System.Drawing.Size(261, 22);
            this.cbMName.TabIndex = 24;
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(202, 207);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(261, 21);
            this.tbDate.TabIndex = 23;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(202, 159);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(261, 21);
            this.tbPrice.TabIndex = 22;
            // 
            // tbCategory
            // 
            this.tbCategory.Location = new System.Drawing.Point(202, 113);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(261, 21);
            this.tbCategory.TabIndex = 21;
            // 
            // InStock_Concle
            // 
            this.InStock_Concle.BackColor = System.Drawing.Color.Transparent;
            this.InStock_Concle.Location = new System.Drawing.Point(358, 249);
            this.InStock_Concle.Name = "InStock_Concle";
            this.InStock_Concle.Size = new System.Drawing.Size(75, 32);
            this.InStock_Concle.TabIndex = 19;
            this.InStock_Concle.Text = "退 出";
            this.InStock_Concle.UseVisualStyleBackColor = false;
            this.InStock_Concle.Click += new System.EventHandler(this.InStock_Concle_Click);
            // 
            // btModify
            // 
            this.btModify.BackColor = System.Drawing.Color.Transparent;
            this.btModify.Location = new System.Drawing.Point(223, 249);
            this.btModify.Name = "btModify";
            this.btModify.Size = new System.Drawing.Size(75, 32);
            this.btModify.TabIndex = 18;
            this.btModify.Text = "修 改";
            this.btModify.UseVisualStyleBackColor = false;
            this.btModify.Click += new System.EventHandler(this.btModify_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(119, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "设备类型：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(119, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 16;
            this.label1.Text = "入库日期：";
            // 
            // applicant_name
            // 
            this.applicant_name.AutoSize = true;
            this.applicant_name.BackColor = System.Drawing.Color.Transparent;
            this.applicant_name.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.applicant_name.Location = new System.Drawing.Point(119, 160);
            this.applicant_name.Name = "applicant_name";
            this.applicant_name.Size = new System.Drawing.Size(77, 14);
            this.applicant_name.TabIndex = 15;
            this.applicant_name.Text = "设备价格：";
            // 
            // M_Name
            // 
            this.M_Name.AutoSize = true;
            this.M_Name.BackColor = System.Drawing.Color.Transparent;
            this.M_Name.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.M_Name.Location = new System.Drawing.Point(119, 69);
            this.M_Name.Name = "M_Name";
            this.M_Name.Size = new System.Drawing.Size(77, 14);
            this.M_Name.TabIndex = 14;
            this.M_Name.Text = "设备名称：";
            // 
            // InStockNum
            // 
            this.InStockNum.AutoSize = true;
            this.InStockNum.BackColor = System.Drawing.Color.Transparent;
            this.InStockNum.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InStockNum.Location = new System.Drawing.Point(119, 23);
            this.InStockNum.Name = "InStockNum";
            this.InStockNum.Size = new System.Drawing.Size(77, 14);
            this.InStockNum.TabIndex = 13;
            this.InStockNum.Text = "设备代码：";
            // 
            // cbMNum
            // 
            this.cbMNum.DisplayMember = "mNum";
            this.cbMNum.FormattingEnabled = true;
            this.cbMNum.Location = new System.Drawing.Point(202, 22);
            this.cbMNum.Name = "cbMNum";
            this.cbMNum.Size = new System.Drawing.Size(261, 20);
            this.cbMNum.TabIndex = 49;
            this.cbMNum.ValueMember = "mNum";
            this.cbMNum.SelectedIndexChanged += new System.EventHandler(this.cbMNum_SelectedIndexChanged);
            // 
            // InStockModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MM.Properties.Resources.backGI;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(582, 296);
            this.Controls.Add(this.cbMNum);
            this.Controls.Add(this.cbMName);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbCategory);
            this.Controls.Add(this.InStock_Concle);
            this.Controls.Add(this.btModify);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.applicant_name);
            this.Controls.Add(this.M_Name);
            this.Controls.Add(this.InStockNum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InStockModify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InStockModify";
            this.Load += new System.EventHandler(this.InStockModify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMName;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbCategory;
        private System.Windows.Forms.Button InStock_Concle;
        private System.Windows.Forms.Button btModify;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label applicant_name;
        private System.Windows.Forms.Label M_Name;
        private System.Windows.Forms.Label InStockNum;
        private System.Windows.Forms.ComboBox cbMNum;
    }
}