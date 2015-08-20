namespace MM
{
    partial class InUsing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InUsing));
            this.labelMNum = new System.Windows.Forms.Label();
            this.labelMName = new System.Windows.Forms.Label();
            this.labelMCategory = new System.Windows.Forms.Label();
            this.labelMPrice = new System.Windows.Forms.Label();
            this.labelOSDate = new System.Windows.Forms.Label();
            this.tbMCategory = new System.Windows.Forms.TextBox();
            this.tbMPrice = new System.Windows.Forms.TextBox();
            this.tbOSDate = new System.Windows.Forms.TextBox();
            this.cbMNum = new System.Windows.Forms.ComboBox();
            this.labelOwner = new System.Windows.Forms.Label();
            this.labelOwner_id = new System.Windows.Forms.Label();
            this.labelOwner_dept = new System.Windows.Forms.Label();
            this.labelOwner_dept_tel = new System.Windows.Forms.Label();
            this.labelOwner_tel = new System.Windows.Forms.Label();
            this.labelAgent_name = new System.Windows.Forms.Label();
            this.tbAgent_name = new System.Windows.Forms.TextBox();
            this.tbOwner = new System.Windows.Forms.TextBox();
            this.tbOwner_id = new System.Windows.Forms.TextBox();
            this.tbOwner_tel = new System.Windows.Forms.TextBox();
            this.tbOwner_dept_tel = new System.Windows.Forms.TextBox();
            this.btSubmit = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.tbMName = new System.Windows.Forms.ComboBox();
            this.tbOwner_dept = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelMNum
            // 
            this.labelMNum.AutoSize = true;
            this.labelMNum.BackColor = System.Drawing.Color.Transparent;
            this.labelMNum.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMNum.Location = new System.Drawing.Point(47, 28);
            this.labelMNum.Name = "labelMNum";
            this.labelMNum.Size = new System.Drawing.Size(77, 14);
            this.labelMNum.TabIndex = 0;
            this.labelMNum.Text = "设备代码：";
            // 
            // labelMName
            // 
            this.labelMName.AutoSize = true;
            this.labelMName.BackColor = System.Drawing.Color.Transparent;
            this.labelMName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMName.Location = new System.Drawing.Point(47, 65);
            this.labelMName.Name = "labelMName";
            this.labelMName.Size = new System.Drawing.Size(77, 14);
            this.labelMName.TabIndex = 2;
            this.labelMName.Text = "设备名称：";
            // 
            // labelMCategory
            // 
            this.labelMCategory.AutoSize = true;
            this.labelMCategory.BackColor = System.Drawing.Color.Transparent;
            this.labelMCategory.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMCategory.Location = new System.Drawing.Point(47, 99);
            this.labelMCategory.Name = "labelMCategory";
            this.labelMCategory.Size = new System.Drawing.Size(77, 14);
            this.labelMCategory.TabIndex = 3;
            this.labelMCategory.Text = "设备类型：";
            // 
            // labelMPrice
            // 
            this.labelMPrice.AutoSize = true;
            this.labelMPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelMPrice.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMPrice.Location = new System.Drawing.Point(47, 133);
            this.labelMPrice.Name = "labelMPrice";
            this.labelMPrice.Size = new System.Drawing.Size(77, 14);
            this.labelMPrice.TabIndex = 4;
            this.labelMPrice.Text = "设备价格：";
            // 
            // labelOSDate
            // 
            this.labelOSDate.AutoSize = true;
            this.labelOSDate.BackColor = System.Drawing.Color.Transparent;
            this.labelOSDate.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelOSDate.Location = new System.Drawing.Point(47, 168);
            this.labelOSDate.Name = "labelOSDate";
            this.labelOSDate.Size = new System.Drawing.Size(77, 14);
            this.labelOSDate.TabIndex = 5;
            this.labelOSDate.Text = "出库日期：";
            // 
            // tbMCategory
            // 
            this.tbMCategory.Location = new System.Drawing.Point(131, 96);
            this.tbMCategory.Name = "tbMCategory";
            this.tbMCategory.Size = new System.Drawing.Size(100, 21);
            this.tbMCategory.TabIndex = 7;
            // 
            // tbMPrice
            // 
            this.tbMPrice.Location = new System.Drawing.Point(131, 132);
            this.tbMPrice.Name = "tbMPrice";
            this.tbMPrice.Size = new System.Drawing.Size(100, 21);
            this.tbMPrice.TabIndex = 8;
            // 
            // tbOSDate
            // 
            this.tbOSDate.Location = new System.Drawing.Point(130, 165);
            this.tbOSDate.Name = "tbOSDate";
            this.tbOSDate.Size = new System.Drawing.Size(100, 21);
            this.tbOSDate.TabIndex = 9;
            // 
            // cbMNum
            // 
            this.cbMNum.DisplayMember = "mNum";
            this.cbMNum.FormattingEnabled = true;
            this.cbMNum.Location = new System.Drawing.Point(130, 27);
            this.cbMNum.Name = "cbMNum";
            this.cbMNum.Size = new System.Drawing.Size(277, 20);
            this.cbMNum.TabIndex = 10;
            this.cbMNum.ValueMember = "mNum";
            this.cbMNum.SelectedIndexChanged += new System.EventHandler(this.cbMNum_SelectedIndexChanged);
            // 
            // labelOwner
            // 
            this.labelOwner.AutoSize = true;
            this.labelOwner.BackColor = System.Drawing.Color.Transparent;
            this.labelOwner.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelOwner.Location = new System.Drawing.Point(316, 65);
            this.labelOwner.Name = "labelOwner";
            this.labelOwner.Size = new System.Drawing.Size(91, 14);
            this.labelOwner.TabIndex = 11;
            this.labelOwner.Text = "申请人姓名：";
            // 
            // labelOwner_id
            // 
            this.labelOwner_id.AutoSize = true;
            this.labelOwner_id.BackColor = System.Drawing.Color.Transparent;
            this.labelOwner_id.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelOwner_id.Location = new System.Drawing.Point(316, 99);
            this.labelOwner_id.Name = "labelOwner_id";
            this.labelOwner_id.Size = new System.Drawing.Size(91, 14);
            this.labelOwner_id.TabIndex = 12;
            this.labelOwner_id.Text = "申请人工号：";
            // 
            // labelOwner_dept
            // 
            this.labelOwner_dept.AutoSize = true;
            this.labelOwner_dept.BackColor = System.Drawing.Color.Transparent;
            this.labelOwner_dept.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelOwner_dept.Location = new System.Drawing.Point(319, 168);
            this.labelOwner_dept.Name = "labelOwner_dept";
            this.labelOwner_dept.Size = new System.Drawing.Size(91, 14);
            this.labelOwner_dept.TabIndex = 13;
            this.labelOwner_dept.Text = "申请人部门：";
            // 
            // labelOwner_dept_tel
            // 
            this.labelOwner_dept_tel.AutoSize = true;
            this.labelOwner_dept_tel.BackColor = System.Drawing.Color.Transparent;
            this.labelOwner_dept_tel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelOwner_dept_tel.Location = new System.Drawing.Point(319, 199);
            this.labelOwner_dept_tel.Name = "labelOwner_dept_tel";
            this.labelOwner_dept_tel.Size = new System.Drawing.Size(119, 14);
            this.labelOwner_dept_tel.TabIndex = 14;
            this.labelOwner_dept_tel.Text = "申请人部门电话：";
            // 
            // labelOwner_tel
            // 
            this.labelOwner_tel.AutoSize = true;
            this.labelOwner_tel.BackColor = System.Drawing.Color.Transparent;
            this.labelOwner_tel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelOwner_tel.Location = new System.Drawing.Point(316, 133);
            this.labelOwner_tel.Name = "labelOwner_tel";
            this.labelOwner_tel.Size = new System.Drawing.Size(91, 14);
            this.labelOwner_tel.TabIndex = 15;
            this.labelOwner_tel.Text = "申请人电话：";
            // 
            // labelAgent_name
            // 
            this.labelAgent_name.AutoSize = true;
            this.labelAgent_name.BackColor = System.Drawing.Color.Transparent;
            this.labelAgent_name.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAgent_name.Location = new System.Drawing.Point(47, 199);
            this.labelAgent_name.Name = "labelAgent_name";
            this.labelAgent_name.Size = new System.Drawing.Size(77, 14);
            this.labelAgent_name.TabIndex = 16;
            this.labelAgent_name.Text = "经 办 人：";
            // 
            // tbAgent_name
            // 
            this.tbAgent_name.Location = new System.Drawing.Point(131, 196);
            this.tbAgent_name.Name = "tbAgent_name";
            this.tbAgent_name.Size = new System.Drawing.Size(100, 21);
            this.tbAgent_name.TabIndex = 17;
            // 
            // tbOwner
            // 
            this.tbOwner.Location = new System.Drawing.Point(426, 62);
            this.tbOwner.Name = "tbOwner";
            this.tbOwner.Size = new System.Drawing.Size(100, 21);
            this.tbOwner.TabIndex = 18;
            // 
            // tbOwner_id
            // 
            this.tbOwner_id.Location = new System.Drawing.Point(426, 96);
            this.tbOwner_id.Name = "tbOwner_id";
            this.tbOwner_id.Size = new System.Drawing.Size(100, 21);
            this.tbOwner_id.TabIndex = 19;
            // 
            // tbOwner_tel
            // 
            this.tbOwner_tel.Location = new System.Drawing.Point(426, 130);
            this.tbOwner_tel.Name = "tbOwner_tel";
            this.tbOwner_tel.Size = new System.Drawing.Size(100, 21);
            this.tbOwner_tel.TabIndex = 20;
            // 
            // tbOwner_dept_tel
            // 
            this.tbOwner_dept_tel.Location = new System.Drawing.Point(426, 196);
            this.tbOwner_dept_tel.Name = "tbOwner_dept_tel";
            this.tbOwner_dept_tel.Size = new System.Drawing.Size(100, 21);
            this.tbOwner_dept_tel.TabIndex = 22;
            // 
            // btSubmit
            // 
            this.btSubmit.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSubmit.Location = new System.Drawing.Point(176, 252);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(75, 32);
            this.btSubmit.TabIndex = 23;
            this.btSubmit.Text = "提 交";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExit.Location = new System.Drawing.Point(318, 252);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 32);
            this.btExit.TabIndex = 24;
            this.btExit.Text = "退 出";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // tbMName
            // 
            this.tbMName.FormattingEnabled = true;
            this.tbMName.Items.AddRange(new object[] {
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
            this.tbMName.Location = new System.Drawing.Point(131, 64);
            this.tbMName.Name = "tbMName";
            this.tbMName.Size = new System.Drawing.Size(100, 20);
            this.tbMName.TabIndex = 25;
            // 
            // tbOwner_dept
            // 
            this.tbOwner_dept.FormattingEnabled = true;
            this.tbOwner_dept.Items.AddRange(new object[] {
            "院领导",
            "办公室",
            "人力资源部",
            "财务部",
            "信息舆情中心",
            "总工办",
            "社会管理与公共服务标准化研究中心",
            "标准化项目评审中心",
            "编码业务管理部",
            "条码检测与编码技术应用部",
            "代码业务管理部",
            "综合执法监督科",
            "代码技术应用部",
            "代码网络与证书管理部",
            "标准文献发行中心",
            "自治区代码服务大厅",
            "服务业标准化研究中心",
            "代码办证点"});
            this.tbOwner_dept.Location = new System.Drawing.Point(426, 165);
            this.tbOwner_dept.Name = "tbOwner_dept";
            this.tbOwner_dept.Size = new System.Drawing.Size(100, 20);
            this.tbOwner_dept.TabIndex = 26;
            // 
            // InUsing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MM.Properties.Resources.backGI;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(582, 296);
            this.Controls.Add(this.tbOwner_dept);
            this.Controls.Add(this.tbMName);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.tbOwner_dept_tel);
            this.Controls.Add(this.tbOwner_tel);
            this.Controls.Add(this.tbOwner_id);
            this.Controls.Add(this.tbOwner);
            this.Controls.Add(this.tbAgent_name);
            this.Controls.Add(this.labelAgent_name);
            this.Controls.Add(this.labelOwner_tel);
            this.Controls.Add(this.labelOwner_dept_tel);
            this.Controls.Add(this.labelOwner_dept);
            this.Controls.Add(this.labelOwner_id);
            this.Controls.Add(this.labelOwner);
            this.Controls.Add(this.cbMNum);
            this.Controls.Add(this.tbOSDate);
            this.Controls.Add(this.tbMPrice);
            this.Controls.Add(this.tbMCategory);
            this.Controls.Add(this.labelOSDate);
            this.Controls.Add(this.labelMPrice);
            this.Controls.Add(this.labelMCategory);
            this.Controls.Add(this.labelMName);
            this.Controls.Add(this.labelMNum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InUsing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "物资申领";
            this.Load += new System.EventHandler(this.InUsing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMNum;
        private System.Windows.Forms.Label labelMName;
        private System.Windows.Forms.Label labelMCategory;
        private System.Windows.Forms.Label labelMPrice;
        private System.Windows.Forms.Label labelOSDate;
        private System.Windows.Forms.TextBox tbMCategory;
        private System.Windows.Forms.TextBox tbMPrice;
        private System.Windows.Forms.TextBox tbOSDate;
        private System.Windows.Forms.ComboBox cbMNum;
        private System.Windows.Forms.Label labelOwner;
        private System.Windows.Forms.Label labelOwner_id;
        private System.Windows.Forms.Label labelOwner_dept;
        private System.Windows.Forms.Label labelOwner_dept_tel;
        private System.Windows.Forms.Label labelOwner_tel;
        private System.Windows.Forms.Label labelAgent_name;
        private System.Windows.Forms.TextBox tbAgent_name;
        private System.Windows.Forms.TextBox tbOwner;
        private System.Windows.Forms.TextBox tbOwner_id;
        private System.Windows.Forms.TextBox tbOwner_tel;
        private System.Windows.Forms.TextBox tbOwner_dept_tel;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.ComboBox tbMName;
        private System.Windows.Forms.ComboBox tbOwner_dept;
    }
}