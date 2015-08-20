namespace MM
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemIS = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemInStockAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemInStockModify = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemInUsing = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDataModify = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFix = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFixApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFixed = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemScrap = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemMCount = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemISCount = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemIUCount = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFixDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFixingCount = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFixedCount = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemScrapCount = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemExitSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelLinkUs = new System.Windows.Forms.Label();
            this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemIS,
            this.ToolStripMenuItem,
            this.ToolStripMenuItemFix,
            this.ToolStripMenuItemScrap,
            this.ToolStripMenuItemMCount,
            this.ToolStripMenuItemExitSystem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(745, 28);
            this.menuStrip.TabIndex = 0;
            // 
            // ToolStripMenuItemIS
            // 
            this.ToolStripMenuItemIS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemInStockAdd,
            this.ToolStripMenuItemInStockModify});
            this.ToolStripMenuItemIS.ForeColor = System.Drawing.Color.Blue;
            this.ToolStripMenuItemIS.Name = "ToolStripMenuItemIS";
            this.ToolStripMenuItemIS.Size = new System.Drawing.Size(77, 24);
            this.ToolStripMenuItemIS.Text = "物资入库";
            // 
            // ToolStripMenuItemInStockAdd
            // 
            this.ToolStripMenuItemInStockAdd.ForeColor = System.Drawing.Color.Blue;
            this.ToolStripMenuItemInStockAdd.Name = "ToolStripMenuItemInStockAdd";
            this.ToolStripMenuItemInStockAdd.Size = new System.Drawing.Size(162, 24);
            this.ToolStripMenuItemInStockAdd.Text = "入库信息添加";
            this.ToolStripMenuItemInStockAdd.Click += new System.EventHandler(this.ToolStripMenuItemInStockAdd_Click);
            // 
            // ToolStripMenuItemInStockModify
            // 
            this.ToolStripMenuItemInStockModify.ForeColor = System.Drawing.Color.Blue;
            this.ToolStripMenuItemInStockModify.Name = "ToolStripMenuItemInStockModify";
            this.ToolStripMenuItemInStockModify.Size = new System.Drawing.Size(162, 24);
            this.ToolStripMenuItemInStockModify.Text = "入库信息修改";
            this.ToolStripMenuItemInStockModify.Click += new System.EventHandler(this.ToolStripMenuItemInStockModify_Click);
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemInUsing,
            this.ToolStripMenuItemDataModify});
            this.ToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.ToolStripMenuItem.Text = "物资申领";
            // 
            // ToolStripMenuItemInUsing
            // 
            this.ToolStripMenuItemInUsing.ForeColor = System.Drawing.Color.Blue;
            this.ToolStripMenuItemInUsing.Name = "ToolStripMenuItemInUsing";
            this.ToolStripMenuItemInUsing.Size = new System.Drawing.Size(162, 24);
            this.ToolStripMenuItemInUsing.Text = "申领信息添加";
            this.ToolStripMenuItemInUsing.Click += new System.EventHandler(this.ToolStripMenuItemInUsing_Click);
            // 
            // ToolStripMenuItemDataModify
            // 
            this.ToolStripMenuItemDataModify.ForeColor = System.Drawing.Color.Blue;
            this.ToolStripMenuItemDataModify.Name = "ToolStripMenuItemDataModify";
            this.ToolStripMenuItemDataModify.Size = new System.Drawing.Size(162, 24);
            this.ToolStripMenuItemDataModify.Text = "申领信息修改";
            this.ToolStripMenuItemDataModify.Click += new System.EventHandler(this.ToolStripMenuItemDataModify_Click);
            // 
            // ToolStripMenuItemFix
            // 
            this.ToolStripMenuItemFix.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFixApplication,
            this.ToolStripMenuItemFixed});
            this.ToolStripMenuItemFix.ForeColor = System.Drawing.Color.Blue;
            this.ToolStripMenuItemFix.Name = "ToolStripMenuItemFix";
            this.ToolStripMenuItemFix.Size = new System.Drawing.Size(77, 24);
            this.ToolStripMenuItemFix.Text = "报修申请";
            // 
            // ToolStripMenuItemFixApplication
            // 
            this.ToolStripMenuItemFixApplication.ForeColor = System.Drawing.Color.Blue;
            this.ToolStripMenuItemFixApplication.Name = "ToolStripMenuItemFixApplication";
            this.ToolStripMenuItemFixApplication.Size = new System.Drawing.Size(162, 24);
            this.ToolStripMenuItemFixApplication.Text = "报修情况登记";
            this.ToolStripMenuItemFixApplication.Click += new System.EventHandler(this.ToolStripMenuItemFixApplication_Click);
            // 
            // ToolStripMenuItemFixed
            // 
            this.ToolStripMenuItemFixed.ForeColor = System.Drawing.Color.Blue;
            this.ToolStripMenuItemFixed.Name = "ToolStripMenuItemFixed";
            this.ToolStripMenuItemFixed.Size = new System.Drawing.Size(162, 24);
            this.ToolStripMenuItemFixed.Text = "修理结果处理";
            this.ToolStripMenuItemFixed.Click += new System.EventHandler(this.ToolStripMenuItemFixed_Click);
            // 
            // ToolStripMenuItemScrap
            // 
            this.ToolStripMenuItemScrap.ForeColor = System.Drawing.Color.Blue;
            this.ToolStripMenuItemScrap.Name = "ToolStripMenuItemScrap";
            this.ToolStripMenuItemScrap.Size = new System.Drawing.Size(77, 24);
            this.ToolStripMenuItemScrap.Text = "报废申请";
            this.ToolStripMenuItemScrap.Click += new System.EventHandler(this.ToolStripMenuItemScrap_Click);
            // 
            // ToolStripMenuItemMCount
            // 
            this.ToolStripMenuItemMCount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemISCount,
            this.ToolStripMenuItemIUCount,
            this.ToolStripMenuItemFixDetail,
            this.ToolStripMenuItemScrapCount});
            this.ToolStripMenuItemMCount.ForeColor = System.Drawing.Color.Blue;
            this.ToolStripMenuItemMCount.Name = "ToolStripMenuItemMCount";
            this.ToolStripMenuItemMCount.Size = new System.Drawing.Size(77, 24);
            this.ToolStripMenuItemMCount.Text = "资产概况";
            // 
            // ToolStripMenuItemISCount
            // 
            this.ToolStripMenuItemISCount.ForeColor = System.Drawing.Color.Blue;
            this.ToolStripMenuItemISCount.Name = "ToolStripMenuItemISCount";
            this.ToolStripMenuItemISCount.Size = new System.Drawing.Size(134, 24);
            this.ToolStripMenuItemISCount.Text = "当前库存";
            this.ToolStripMenuItemISCount.Click += new System.EventHandler(this.ToolStripMenuItemISCount_Click);
            // 
            // ToolStripMenuItemIUCount
            // 
            this.ToolStripMenuItemIUCount.ForeColor = System.Drawing.Color.Blue;
            this.ToolStripMenuItemIUCount.Name = "ToolStripMenuItemIUCount";
            this.ToolStripMenuItemIUCount.Size = new System.Drawing.Size(134, 24);
            this.ToolStripMenuItemIUCount.Text = "物资分布";
            this.ToolStripMenuItemIUCount.Click += new System.EventHandler(this.ToolStripMenuItemIUCount_Click);
            // 
            // ToolStripMenuItemFixDetail
            // 
            this.ToolStripMenuItemFixDetail.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFixingCount,
            this.ToolStripMenuItemFixedCount});
            this.ToolStripMenuItemFixDetail.ForeColor = System.Drawing.Color.Blue;
            this.ToolStripMenuItemFixDetail.Name = "ToolStripMenuItemFixDetail";
            this.ToolStripMenuItemFixDetail.Size = new System.Drawing.Size(134, 24);
            this.ToolStripMenuItemFixDetail.Text = "报修明细";
            // 
            // ToolStripMenuItemFixingCount
            // 
            this.ToolStripMenuItemFixingCount.ForeColor = System.Drawing.Color.Blue;
            this.ToolStripMenuItemFixingCount.Name = "ToolStripMenuItemFixingCount";
            this.ToolStripMenuItemFixingCount.Size = new System.Drawing.Size(120, 24);
            this.ToolStripMenuItemFixingCount.Text = "修理中";
            this.ToolStripMenuItemFixingCount.Click += new System.EventHandler(this.ToolStripMenuItemFixingCount_Click);
            // 
            // ToolStripMenuItemFixedCount
            // 
            this.ToolStripMenuItemFixedCount.ForeColor = System.Drawing.Color.Blue;
            this.ToolStripMenuItemFixedCount.Name = "ToolStripMenuItemFixedCount";
            this.ToolStripMenuItemFixedCount.Size = new System.Drawing.Size(120, 24);
            this.ToolStripMenuItemFixedCount.Text = "已修理";
            this.ToolStripMenuItemFixedCount.Click += new System.EventHandler(this.ToolStripMenuItemFixedCount_Click);
            // 
            // ToolStripMenuItemScrapCount
            // 
            this.ToolStripMenuItemScrapCount.ForeColor = System.Drawing.Color.Blue;
            this.ToolStripMenuItemScrapCount.Name = "ToolStripMenuItemScrapCount";
            this.ToolStripMenuItemScrapCount.Size = new System.Drawing.Size(134, 24);
            this.ToolStripMenuItemScrapCount.Text = "报废明细";
            this.ToolStripMenuItemScrapCount.Click += new System.EventHandler(this.ToolStripMenuItemScrapCount_Click);
            // 
            // ToolStripMenuItemExitSystem
            // 
            this.ToolStripMenuItemExitSystem.ForeColor = System.Drawing.Color.Blue;
            this.ToolStripMenuItemExitSystem.Name = "ToolStripMenuItemExitSystem";
            this.ToolStripMenuItemExitSystem.Size = new System.Drawing.Size(77, 24);
            this.ToolStripMenuItemExitSystem.Text = "退出系统";
            this.ToolStripMenuItemExitSystem.Click += new System.EventHandler(this.ToolStripMenuItemExitSystem_Click);
            // 
            // labelLinkUs
            // 
            this.labelLinkUs.AutoSize = true;
            this.labelLinkUs.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelLinkUs.Location = new System.Drawing.Point(177, 418);
            this.labelLinkUs.Name = "labelLinkUs";
            this.labelLinkUs.Size = new System.Drawing.Size(461, 12);
            this.labelLinkUs.TabIndex = 2;
            this.labelLinkUs.Text = "©2015 本系统由北京交通大学软件学院： 刘红华、严帅 出品，版权所有，翻版必究！";
            // 
            // pictureBoxBackground
            // 
            this.pictureBoxBackground.Image = global::MM.Properties.Resources.nmg;
            this.pictureBoxBackground.Location = new System.Drawing.Point(0, 28);
            this.pictureBoxBackground.Name = "pictureBoxBackground";
            this.pictureBoxBackground.Size = new System.Drawing.Size(745, 382);
            this.pictureBoxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackground.TabIndex = 1;
            this.pictureBoxBackground.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 439);
            this.Controls.Add(this.labelLinkUs);
            this.Controls.Add(this.pictureBoxBackground);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "物资管理系统";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.PictureBox pictureBoxBackground;
        public System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemIS;
        public System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemMCount;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExitSystem;
        private System.Windows.Forms.Label labelLinkUs;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemISCount;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemIUCount;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemScrapCount;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemScrap;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemInUsing;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDataModify;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFix;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFixDetail;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFixingCount;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFixedCount;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFixApplication;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFixed;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemInStockAdd;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemInStockModify;
    }
}