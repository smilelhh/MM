namespace MM
{
    partial class QFixed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QFixed));
            this.btQuery = new System.Windows.Forms.Button();
            this.__ = new System.Windows.Forms.Label();
            this.tbEndDate = new System.Windows.Forms.TextBox();
            this.tbStartDate = new System.Windows.Forms.TextBox();
            this.sttime = new System.Windows.Forms.Label();
            this.cbDepName = new System.Windows.Forms.ComboBox();
            this.QScrDepName = new System.Windows.Forms.Label();
            this.quit = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Button();
            this.totalPrice = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.dgQFixed = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgQFixed)).BeginInit();
            this.SuspendLayout();
            // 
            // btQuery
            // 
            this.btQuery.Location = new System.Drawing.Point(584, 7);
            this.btQuery.Name = "btQuery";
            this.btQuery.Size = new System.Drawing.Size(75, 32);
            this.btQuery.TabIndex = 22;
            this.btQuery.Text = "查 询";
            this.btQuery.UseVisualStyleBackColor = true;
            this.btQuery.Click += new System.EventHandler(this.btQuery_Click);
            // 
            // __
            // 
            this.__.AutoSize = true;
            this.__.BackColor = System.Drawing.Color.Transparent;
            this.__.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.__.Location = new System.Drawing.Point(406, 17);
            this.__.Name = "__";
            this.__.Size = new System.Drawing.Size(29, 12);
            this.__.TabIndex = 21;
            this.__.Text = "——";
            // 
            // tbEndDate
            // 
            this.tbEndDate.Location = new System.Drawing.Point(441, 13);
            this.tbEndDate.Name = "tbEndDate";
            this.tbEndDate.Size = new System.Drawing.Size(100, 21);
            this.tbEndDate.TabIndex = 20;
            // 
            // tbStartDate
            // 
            this.tbStartDate.Location = new System.Drawing.Point(300, 12);
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
            this.sttime.Location = new System.Drawing.Point(231, 14);
            this.sttime.Name = "sttime";
            this.sttime.Size = new System.Drawing.Size(63, 14);
            this.sttime.TabIndex = 18;
            this.sttime.Text = "起止日期";
            // 
            // cbDepName
            // 
            this.cbDepName.FormattingEnabled = true;
            this.cbDepName.Items.AddRange(new object[] {
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
            this.cbDepName.Location = new System.Drawing.Point(72, 13);
            this.cbDepName.Name = "cbDepName";
            this.cbDepName.Size = new System.Drawing.Size(137, 20);
            this.cbDepName.TabIndex = 17;
            // 
            // QScrDepName
            // 
            this.QScrDepName.AutoSize = true;
            this.QScrDepName.BackColor = System.Drawing.Color.Transparent;
            this.QScrDepName.Font = new System.Drawing.Font("宋体", 10.5F);
            this.QScrDepName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.QScrDepName.Location = new System.Drawing.Point(24, 15);
            this.QScrDepName.Name = "QScrDepName";
            this.QScrDepName.Size = new System.Drawing.Size(42, 14);
            this.QScrDepName.TabIndex = 16;
            this.QScrDepName.Text = "部门:";
            // 
            // quit
            // 
            this.quit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.quit.Location = new System.Drawing.Point(584, 295);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(75, 32);
            this.quit.TabIndex = 26;
            this.quit.Text = "退 出";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // output
            // 
            this.output.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.output.Location = new System.Drawing.Point(466, 295);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(75, 32);
            this.output.TabIndex = 25;
            this.output.Text = "导 出";
            this.output.UseVisualStyleBackColor = true;
            this.output.Click += new System.EventHandler(this.output_Click);
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSize = true;
            this.totalPrice.BackColor = System.Drawing.Color.Transparent;
            this.totalPrice.Font = new System.Drawing.Font("宋体", 10.5F);
            this.totalPrice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.totalPrice.Location = new System.Drawing.Point(177, 303);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(14, 14);
            this.totalPrice.TabIndex = 24;
            this.totalPrice.Text = "0";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.BackColor = System.Drawing.Color.Transparent;
            this.total.Font = new System.Drawing.Font("宋体", 10.5F);
            this.total.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.total.Location = new System.Drawing.Point(24, 303);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(147, 14);
            this.total.TabIndex = 23;
            this.total.Text = "已修好设备资产总计：";
            // 
            // dgQFixed
            // 
            this.dgQFixed.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgQFixed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgQFixed.Location = new System.Drawing.Point(27, 45);
            this.dgQFixed.Name = "dgQFixed";
            this.dgQFixed.RowTemplate.Height = 23;
            this.dgQFixed.Size = new System.Drawing.Size(632, 244);
            this.dgQFixed.TabIndex = 27;
            // 
            // QFixed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MM.Properties.Resources.backGI;
            this.ClientSize = new System.Drawing.Size(687, 344);
            this.Controls.Add(this.dgQFixed);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.output);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.total);
            this.Controls.Add(this.btQuery);
            this.Controls.Add(this.__);
            this.Controls.Add(this.tbEndDate);
            this.Controls.Add(this.tbStartDate);
            this.Controls.Add(this.sttime);
            this.Controls.Add(this.cbDepName);
            this.Controls.Add(this.QScrDepName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QFixed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "已修理";
            this.Load += new System.EventHandler(this.QFixed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgQFixed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btQuery;
        private System.Windows.Forms.Label __;
        private System.Windows.Forms.TextBox tbEndDate;
        private System.Windows.Forms.TextBox tbStartDate;
        private System.Windows.Forms.Label sttime;
        private System.Windows.Forms.ComboBox cbDepName;
        private System.Windows.Forms.Label QScrDepName;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Button output;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.DataGridView dgQFixed;
    }
}