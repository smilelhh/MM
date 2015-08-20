namespace MM
{
    partial class QInUsing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QInUsing));
            this.labelMDept = new System.Windows.Forms.Label();
            this.cbMDept = new System.Windows.Forms.ComboBox();
            this.Qdep = new System.Windows.Forms.Label();
            this.cbMName = new System.Windows.Forms.ComboBox();
            this.btQuery = new System.Windows.Forms.Button();
            this.dgQIU = new System.Windows.Forms.DataGridView();
            this.totalPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.quit = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Button();
            this.__ = new System.Windows.Forms.Label();
            this.tbEndDate = new System.Windows.Forms.TextBox();
            this.tbStartDate = new System.Windows.Forms.TextBox();
            this.sttime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgQIU)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMDept
            // 
            this.labelMDept.AutoSize = true;
            this.labelMDept.BackColor = System.Drawing.Color.Transparent;
            this.labelMDept.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMDept.Location = new System.Drawing.Point(77, 13);
            this.labelMDept.Name = "labelMDept";
            this.labelMDept.Size = new System.Drawing.Size(56, 14);
            this.labelMDept.TabIndex = 0;
            this.labelMDept.Text = "部 门：";
            // 
            // cbMDept
            // 
            this.cbMDept.FormattingEnabled = true;
            this.cbMDept.Items.AddRange(new object[] {
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
            this.cbMDept.Location = new System.Drawing.Point(146, 12);
            this.cbMDept.Name = "cbMDept";
            this.cbMDept.Size = new System.Drawing.Size(98, 20);
            this.cbMDept.TabIndex = 1;
            // 
            // Qdep
            // 
            this.Qdep.AutoSize = true;
            this.Qdep.BackColor = System.Drawing.Color.Transparent;
            this.Qdep.Font = new System.Drawing.Font("宋体", 10.5F);
            this.Qdep.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Qdep.Location = new System.Drawing.Point(265, 13);
            this.Qdep.Name = "Qdep";
            this.Qdep.Size = new System.Drawing.Size(77, 14);
            this.Qdep.TabIndex = 10;
            this.Qdep.Text = "设备名称：";
            // 
            // cbMName
            // 
            this.cbMName.FormattingEnabled = true;
            this.cbMName.Items.AddRange(new object[] {
            "电脑",
            "打印机",
            "电话",
            "桌子",
            "椅子",
            "柜子",
            "饮水机",
            "空调",
            "扫描仪",
            "传真机",
            "检测仪"});
            this.cbMName.Location = new System.Drawing.Point(348, 12);
            this.cbMName.Name = "cbMName";
            this.cbMName.Size = new System.Drawing.Size(94, 20);
            this.cbMName.TabIndex = 9;
            // 
            // btQuery
            // 
            this.btQuery.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btQuery.Location = new System.Drawing.Point(510, 29);
            this.btQuery.Name = "btQuery";
            this.btQuery.Size = new System.Drawing.Size(75, 32);
            this.btQuery.TabIndex = 8;
            this.btQuery.Text = "查 询";
            this.btQuery.UseVisualStyleBackColor = true;
            this.btQuery.Click += new System.EventHandler(this.btQuery_Click);
            // 
            // dgQIU
            // 
            this.dgQIU.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgQIU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgQIU.Location = new System.Drawing.Point(2, 73);
            this.dgQIU.Name = "dgQIU";
            this.dgQIU.RowTemplate.Height = 23;
            this.dgQIU.Size = new System.Drawing.Size(683, 217);
            this.dgQIU.TabIndex = 11;
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSize = true;
            this.totalPrice.BackColor = System.Drawing.Color.Transparent;
            this.totalPrice.Font = new System.Drawing.Font("宋体", 10.5F);
            this.totalPrice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.totalPrice.Location = new System.Drawing.Point(216, 304);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(14, 14);
            this.totalPrice.TabIndex = 17;
            this.totalPrice.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(63, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 14);
            this.label1.TabIndex = 16;
            this.label1.Text = "当前库存资产总计：";
            // 
            // quit
            // 
            this.quit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.quit.Location = new System.Drawing.Point(510, 296);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(75, 32);
            this.quit.TabIndex = 15;
            this.quit.Text = "退 出";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // output
            // 
            this.output.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.output.Location = new System.Drawing.Point(367, 296);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(75, 32);
            this.output.TabIndex = 14;
            this.output.Text = "导 出";
            this.output.UseVisualStyleBackColor = true;
            this.output.Click += new System.EventHandler(this.output_Click);
            // 
            // __
            // 
            this.__.AutoSize = true;
            this.__.BackColor = System.Drawing.Color.Transparent;
            this.__.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.__.Location = new System.Drawing.Point(280, 49);
            this.__.Name = "__";
            this.__.Size = new System.Drawing.Size(29, 12);
            this.__.TabIndex = 21;
            this.__.Text = "——";
            // 
            // tbEndDate
            // 
            this.tbEndDate.Location = new System.Drawing.Point(348, 46);
            this.tbEndDate.Name = "tbEndDate";
            this.tbEndDate.Size = new System.Drawing.Size(94, 21);
            this.tbEndDate.TabIndex = 20;
            // 
            // tbStartDate
            // 
            this.tbStartDate.Location = new System.Drawing.Point(146, 46);
            this.tbStartDate.Name = "tbStartDate";
            this.tbStartDate.Size = new System.Drawing.Size(100, 21);
            this.tbStartDate.TabIndex = 19;
            // 
            // sttime
            // 
            this.sttime.AutoSize = true;
            this.sttime.BackColor = System.Drawing.Color.Transparent;
            this.sttime.Font = new System.Drawing.Font("宋体", 10.5F);
            this.sttime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sttime.Location = new System.Drawing.Point(63, 47);
            this.sttime.Name = "sttime";
            this.sttime.Size = new System.Drawing.Size(77, 14);
            this.sttime.TabIndex = 18;
            this.sttime.Text = "出库日期：";
            // 
            // QInUsing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MM.Properties.Resources.backGI;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(687, 344);
            this.Controls.Add(this.__);
            this.Controls.Add(this.tbEndDate);
            this.Controls.Add(this.tbStartDate);
            this.Controls.Add(this.sttime);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.output);
            this.Controls.Add(this.dgQIU);
            this.Controls.Add(this.Qdep);
            this.Controls.Add(this.cbMName);
            this.Controls.Add(this.btQuery);
            this.Controls.Add(this.cbMDept);
            this.Controls.Add(this.labelMDept);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QInUsing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "物资分布";
            this.Load += new System.EventHandler(this.QInUsing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgQIU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMDept;
        private System.Windows.Forms.ComboBox cbMDept;
        private System.Windows.Forms.Label Qdep;
        private System.Windows.Forms.ComboBox cbMName;
        private System.Windows.Forms.Button btQuery;
        private System.Windows.Forms.DataGridView dgQIU;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Button output;
        private System.Windows.Forms.Label __;
        private System.Windows.Forms.TextBox tbEndDate;
        private System.Windows.Forms.TextBox tbStartDate;
        private System.Windows.Forms.Label sttime;
    }
}