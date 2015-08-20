namespace MM
{
    partial class QFixing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QFixing));
            this.Qdep = new System.Windows.Forms.Label();
            this.cbMName = new System.Windows.Forms.ComboBox();
            this.btQuery = new System.Windows.Forms.Button();
            this.cbMDept = new System.Windows.Forms.ComboBox();
            this.labelMDept = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.quit = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Button();
            this.dgFixing = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgFixing)).BeginInit();
            this.SuspendLayout();
            // 
            // Qdep
            // 
            this.Qdep.AutoSize = true;
            this.Qdep.BackColor = System.Drawing.Color.Transparent;
            this.Qdep.Font = new System.Drawing.Font("宋体", 10.5F);
            this.Qdep.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Qdep.Location = new System.Drawing.Point(264, 20);
            this.Qdep.Name = "Qdep";
            this.Qdep.Size = new System.Drawing.Size(77, 14);
            this.Qdep.TabIndex = 15;
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
            this.cbMName.Location = new System.Drawing.Point(347, 19);
            this.cbMName.Name = "cbMName";
            this.cbMName.Size = new System.Drawing.Size(94, 20);
            this.cbMName.TabIndex = 14;
            // 
            // btQuery
            // 
            this.btQuery.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btQuery.Location = new System.Drawing.Point(513, 12);
            this.btQuery.Name = "btQuery";
            this.btQuery.Size = new System.Drawing.Size(75, 32);
            this.btQuery.TabIndex = 13;
            this.btQuery.Text = "查 询";
            this.btQuery.UseVisualStyleBackColor = true;
            this.btQuery.Click += new System.EventHandler(this.btQuery_Click);
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
            this.cbMDept.Location = new System.Drawing.Point(131, 19);
            this.cbMDept.Name = "cbMDept";
            this.cbMDept.Size = new System.Drawing.Size(112, 20);
            this.cbMDept.TabIndex = 12;
            // 
            // labelMDept
            // 
            this.labelMDept.AutoSize = true;
            this.labelMDept.BackColor = System.Drawing.Color.Transparent;
            this.labelMDept.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMDept.Location = new System.Drawing.Point(76, 20);
            this.labelMDept.Name = "labelMDept";
            this.labelMDept.Size = new System.Drawing.Size(49, 14);
            this.labelMDept.TabIndex = 11;
            this.labelMDept.Text = "部门：";
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSize = true;
            this.totalPrice.BackColor = System.Drawing.Color.Transparent;
            this.totalPrice.Font = new System.Drawing.Font("宋体", 10.5F);
            this.totalPrice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.totalPrice.Location = new System.Drawing.Point(229, 295);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(14, 14);
            this.totalPrice.TabIndex = 21;
            this.totalPrice.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(31, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 14);
            this.label1.TabIndex = 20;
            this.label1.Text = "当前修理中设备资产总计：";
            // 
            // quit
            // 
            this.quit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.quit.Location = new System.Drawing.Point(513, 287);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(75, 32);
            this.quit.TabIndex = 19;
            this.quit.Text = "退 出";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // output
            // 
            this.output.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.output.Location = new System.Drawing.Point(366, 287);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(75, 32);
            this.output.TabIndex = 18;
            this.output.Text = "导 出";
            this.output.UseVisualStyleBackColor = true;
            this.output.Click += new System.EventHandler(this.output_Click);
            // 
            // dgFixing
            // 
            this.dgFixing.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgFixing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFixing.Location = new System.Drawing.Point(2, 50);
            this.dgFixing.Name = "dgFixing";
            this.dgFixing.RowTemplate.Height = 23;
            this.dgFixing.Size = new System.Drawing.Size(684, 231);
            this.dgFixing.TabIndex = 22;
            // 
            // QFixing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MM.Properties.Resources.backGI;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(687, 344);
            this.Controls.Add(this.dgFixing);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.output);
            this.Controls.Add(this.Qdep);
            this.Controls.Add(this.cbMName);
            this.Controls.Add(this.btQuery);
            this.Controls.Add(this.cbMDept);
            this.Controls.Add(this.labelMDept);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QFixing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修理中";
            this.Load += new System.EventHandler(this.Fixing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFixing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Qdep;
        private System.Windows.Forms.ComboBox cbMName;
        private System.Windows.Forms.Button btQuery;
        private System.Windows.Forms.ComboBox cbMDept;
        private System.Windows.Forms.Label labelMDept;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Button output;
        private System.Windows.Forms.DataGridView dgFixing;
    }
}