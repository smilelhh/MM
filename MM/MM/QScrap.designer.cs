namespace MM
{
    partial class QScrap
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QScrap));
            this.QScrDepName = new System.Windows.Forms.Label();
            this.cbDepName = new System.Windows.Forms.ComboBox();
            this.sttime = new System.Windows.Forms.Label();
            this.tbStartDate = new System.Windows.Forms.TextBox();
            this.tbEndDate = new System.Windows.Forms.TextBox();
            this.__ = new System.Windows.Forms.Label();
            this.btQuery = new System.Windows.Forms.Button();
            this.dgScrapDetail = new System.Windows.Forms.DataGridView();
            this.mNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicantdeptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicantnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicantidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicanttelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicantdepttelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tScrapingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bYMMDataSetScrapDetail = new MM.BYMMDataSetScrapDetail();
            this.total = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.Label();
            this.quit = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Button();
            this.t_ScrapingTableAdapter = new MM.BYMMDataSetScrapDetailTableAdapters.T_ScrapingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgScrapDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tScrapingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bYMMDataSetScrapDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // QScrDepName
            // 
            this.QScrDepName.AutoSize = true;
            this.QScrDepName.BackColor = System.Drawing.Color.Transparent;
            this.QScrDepName.Font = new System.Drawing.Font("宋体", 10.5F);
            this.QScrDepName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.QScrDepName.Location = new System.Drawing.Point(22, 22);
            this.QScrDepName.Name = "QScrDepName";
            this.QScrDepName.Size = new System.Drawing.Size(42, 14);
            this.QScrDepName.TabIndex = 8;
            this.QScrDepName.Text = "部门:";
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
            this.cbDepName.Location = new System.Drawing.Point(70, 20);
            this.cbDepName.Name = "cbDepName";
            this.cbDepName.Size = new System.Drawing.Size(137, 20);
            this.cbDepName.TabIndex = 9;
            // 
            // sttime
            // 
            this.sttime.AutoSize = true;
            this.sttime.BackColor = System.Drawing.Color.Transparent;
            this.sttime.Font = new System.Drawing.Font("宋体", 10.5F);
            this.sttime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sttime.Location = new System.Drawing.Point(229, 21);
            this.sttime.Name = "sttime";
            this.sttime.Size = new System.Drawing.Size(63, 14);
            this.sttime.TabIndex = 11;
            this.sttime.Text = "起止日期";
            // 
            // tbStartDate
            // 
            this.tbStartDate.Location = new System.Drawing.Point(298, 19);
            this.tbStartDate.Name = "tbStartDate";
            this.tbStartDate.Size = new System.Drawing.Size(100, 21);
            this.tbStartDate.TabIndex = 12;
            // 
            // tbEndDate
            // 
            this.tbEndDate.Location = new System.Drawing.Point(439, 20);
            this.tbEndDate.Name = "tbEndDate";
            this.tbEndDate.Size = new System.Drawing.Size(100, 21);
            this.tbEndDate.TabIndex = 13;
            // 
            // __
            // 
            this.__.AutoSize = true;
            this.__.BackColor = System.Drawing.Color.Transparent;
            this.__.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.__.Location = new System.Drawing.Point(404, 24);
            this.__.Name = "__";
            this.__.Size = new System.Drawing.Size(29, 12);
            this.__.TabIndex = 14;
            this.__.Text = "——";
            // 
            // btQuery
            // 
            this.btQuery.Location = new System.Drawing.Point(582, 17);
            this.btQuery.Name = "btQuery";
            this.btQuery.Size = new System.Drawing.Size(75, 32);
            this.btQuery.TabIndex = 15;
            this.btQuery.Text = "查 询";
            this.btQuery.UseVisualStyleBackColor = true;
            this.btQuery.Click += new System.EventHandler(this.btQuery_Click);
            // 
            // dgScrapDetail
            // 
            this.dgScrapDetail.AutoGenerateColumns = false;
            this.dgScrapDetail.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgScrapDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgScrapDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mNumDataGridViewTextBoxColumn,
            this.mNameDataGridViewTextBoxColumn,
            this.mCategoryDataGridViewTextBoxColumn,
            this.mPriceDataGridViewTextBoxColumn,
            this.mDateDataGridViewTextBoxColumn,
            this.applicantdeptDataGridViewTextBoxColumn,
            this.applicantnameDataGridViewTextBoxColumn,
            this.applicantidDataGridViewTextBoxColumn,
            this.applicanttelDataGridViewTextBoxColumn,
            this.applicantdepttelDataGridViewTextBoxColumn,
            this.agentnameDataGridViewTextBoxColumn});
            this.dgScrapDetail.DataSource = this.tScrapingBindingSource;
            this.dgScrapDetail.Location = new System.Drawing.Point(0, 55);
            this.dgScrapDetail.Name = "dgScrapDetail";
            this.dgScrapDetail.RowTemplate.Height = 23;
            this.dgScrapDetail.Size = new System.Drawing.Size(689, 225);
            this.dgScrapDetail.TabIndex = 16;
            // 
            // mNumDataGridViewTextBoxColumn
            // 
            this.mNumDataGridViewTextBoxColumn.DataPropertyName = "mNum";
            this.mNumDataGridViewTextBoxColumn.HeaderText = "设备代码";
            this.mNumDataGridViewTextBoxColumn.Name = "mNumDataGridViewTextBoxColumn";
            // 
            // mNameDataGridViewTextBoxColumn
            // 
            this.mNameDataGridViewTextBoxColumn.DataPropertyName = "mName";
            this.mNameDataGridViewTextBoxColumn.HeaderText = "设备名称";
            this.mNameDataGridViewTextBoxColumn.Name = "mNameDataGridViewTextBoxColumn";
            // 
            // mCategoryDataGridViewTextBoxColumn
            // 
            this.mCategoryDataGridViewTextBoxColumn.DataPropertyName = "mCategory";
            this.mCategoryDataGridViewTextBoxColumn.HeaderText = "设备类型";
            this.mCategoryDataGridViewTextBoxColumn.Name = "mCategoryDataGridViewTextBoxColumn";
            // 
            // mPriceDataGridViewTextBoxColumn
            // 
            this.mPriceDataGridViewTextBoxColumn.DataPropertyName = "mPrice";
            this.mPriceDataGridViewTextBoxColumn.HeaderText = "设备价格";
            this.mPriceDataGridViewTextBoxColumn.Name = "mPriceDataGridViewTextBoxColumn";
            // 
            // mDateDataGridViewTextBoxColumn
            // 
            this.mDateDataGridViewTextBoxColumn.DataPropertyName = "mDate";
            this.mDateDataGridViewTextBoxColumn.HeaderText = "报废日期";
            this.mDateDataGridViewTextBoxColumn.Name = "mDateDataGridViewTextBoxColumn";
            // 
            // applicantdeptDataGridViewTextBoxColumn
            // 
            this.applicantdeptDataGridViewTextBoxColumn.DataPropertyName = "applicant_dept";
            this.applicantdeptDataGridViewTextBoxColumn.HeaderText = "申请部门";
            this.applicantdeptDataGridViewTextBoxColumn.Name = "applicantdeptDataGridViewTextBoxColumn";
            // 
            // applicantnameDataGridViewTextBoxColumn
            // 
            this.applicantnameDataGridViewTextBoxColumn.DataPropertyName = "applicant_name";
            this.applicantnameDataGridViewTextBoxColumn.HeaderText = "报废申请人";
            this.applicantnameDataGridViewTextBoxColumn.Name = "applicantnameDataGridViewTextBoxColumn";
            // 
            // applicantidDataGridViewTextBoxColumn
            // 
            this.applicantidDataGridViewTextBoxColumn.DataPropertyName = "applicant_id";
            this.applicantidDataGridViewTextBoxColumn.HeaderText = "工号";
            this.applicantidDataGridViewTextBoxColumn.Name = "applicantidDataGridViewTextBoxColumn";
            // 
            // applicanttelDataGridViewTextBoxColumn
            // 
            this.applicanttelDataGridViewTextBoxColumn.DataPropertyName = "applicant_tel";
            this.applicanttelDataGridViewTextBoxColumn.HeaderText = "电话号码";
            this.applicanttelDataGridViewTextBoxColumn.Name = "applicanttelDataGridViewTextBoxColumn";
            // 
            // applicantdepttelDataGridViewTextBoxColumn
            // 
            this.applicantdepttelDataGridViewTextBoxColumn.DataPropertyName = "applicant_dept_tel";
            this.applicantdepttelDataGridViewTextBoxColumn.HeaderText = "部门电话";
            this.applicantdepttelDataGridViewTextBoxColumn.Name = "applicantdepttelDataGridViewTextBoxColumn";
            // 
            // agentnameDataGridViewTextBoxColumn
            // 
            this.agentnameDataGridViewTextBoxColumn.DataPropertyName = "agent_name";
            this.agentnameDataGridViewTextBoxColumn.HeaderText = "经办人";
            this.agentnameDataGridViewTextBoxColumn.Name = "agentnameDataGridViewTextBoxColumn";
            // 
            // tScrapingBindingSource
            // 
            this.tScrapingBindingSource.DataMember = "T_Scraping";
            this.tScrapingBindingSource.DataSource = this.bYMMDataSetScrapDetail;
            // 
            // bYMMDataSetScrapDetail
            // 
            this.bYMMDataSetScrapDetail.DataSetName = "BYMMDataSetScrapDetail";
            this.bYMMDataSetScrapDetail.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.BackColor = System.Drawing.Color.Transparent;
            this.total.Font = new System.Drawing.Font("宋体", 10.5F);
            this.total.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.total.Location = new System.Drawing.Point(22, 294);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(175, 14);
            this.total.TabIndex = 17;
            this.total.Text = "当前已报废设备资产总计：";
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSize = true;
            this.totalPrice.BackColor = System.Drawing.Color.Transparent;
            this.totalPrice.Font = new System.Drawing.Font("宋体", 10.5F);
            this.totalPrice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.totalPrice.Location = new System.Drawing.Point(203, 294);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(14, 14);
            this.totalPrice.TabIndex = 18;
            this.totalPrice.Text = "0";
            // 
            // quit
            // 
            this.quit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.quit.Location = new System.Drawing.Point(582, 286);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(75, 32);
            this.quit.TabIndex = 20;
            this.quit.Text = "退 出";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // output
            // 
            this.output.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.output.Location = new System.Drawing.Point(464, 286);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(75, 32);
            this.output.TabIndex = 19;
            this.output.Text = "导 出";
            this.output.UseVisualStyleBackColor = true;
            this.output.Click += new System.EventHandler(this.output_Click);
            // 
            // t_ScrapingTableAdapter
            // 
            this.t_ScrapingTableAdapter.ClearBeforeFill = true;
            // 
            // ScrapDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MM.Properties.Resources.backGI;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(687, 344);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.output);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.total);
            this.Controls.Add(this.dgScrapDetail);
            this.Controls.Add(this.btQuery);
            this.Controls.Add(this.__);
            this.Controls.Add(this.tbEndDate);
            this.Controls.Add(this.tbStartDate);
            this.Controls.Add(this.sttime);
            this.Controls.Add(this.cbDepName);
            this.Controls.Add(this.QScrDepName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScrapDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "报废明细";
            this.Load += new System.EventHandler(this.ScrapDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgScrapDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tScrapingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bYMMDataSetScrapDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QScrDepName;
        private System.Windows.Forms.ComboBox cbDepName;
        private System.Windows.Forms.Label sttime;
        private System.Windows.Forms.TextBox tbStartDate;
        private System.Windows.Forms.TextBox tbEndDate;
        private System.Windows.Forms.Label __;
        private System.Windows.Forms.Button btQuery;
        private System.Windows.Forms.DataGridView dgScrapDetail;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Button output;
        private BYMMDataSetScrapDetail bYMMDataSetScrapDetail;
        private System.Windows.Forms.BindingSource tScrapingBindingSource;
        private BYMMDataSetScrapDetailTableAdapters.T_ScrapingTableAdapter t_ScrapingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicantdeptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicantnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicantidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicanttelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicantdepttelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentnameDataGridViewTextBoxColumn;
    }
}