namespace MM
{
    partial class QInstocking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QInstocking));
            this.dgQIn = new System.Windows.Forms.DataGridView();
            this.mNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tInStockingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bYMMDataSetQInstockDategridView = new MM.BYMMDataSetQInstockDategridView();
            this.btQuery = new System.Windows.Forms.Button();
            this.cbMName = new System.Windows.Forms.ComboBox();
            this.Qdep = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.t_InStockingTableAdapter = new MM.BYMMDataSetQInstockDategridViewTableAdapters.T_InStockingTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgQIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tInStockingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bYMMDataSetQInstockDategridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgQIn
            // 
            this.dgQIn.AutoGenerateColumns = false;
            this.dgQIn.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgQIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgQIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgQIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mNumDataGridViewTextBoxColumn,
            this.mNameDataGridViewTextBoxColumn,
            this.mCategoryDataGridViewTextBoxColumn,
            this.mPriceDataGridViewTextBoxColumn,
            this.iSDateDataGridViewTextBoxColumn});
            this.dgQIn.DataSource = this.tInStockingBindingSource;
            resources.ApplyResources(this.dgQIn, "dgQIn");
            this.dgQIn.Name = "dgQIn";
            this.dgQIn.RowTemplate.Height = 23;
            // 
            // mNumDataGridViewTextBoxColumn
            // 
            this.mNumDataGridViewTextBoxColumn.DataPropertyName = "mNum";
            resources.ApplyResources(this.mNumDataGridViewTextBoxColumn, "mNumDataGridViewTextBoxColumn");
            this.mNumDataGridViewTextBoxColumn.Name = "mNumDataGridViewTextBoxColumn";
            // 
            // mNameDataGridViewTextBoxColumn
            // 
            this.mNameDataGridViewTextBoxColumn.DataPropertyName = "mName";
            resources.ApplyResources(this.mNameDataGridViewTextBoxColumn, "mNameDataGridViewTextBoxColumn");
            this.mNameDataGridViewTextBoxColumn.Name = "mNameDataGridViewTextBoxColumn";
            // 
            // mCategoryDataGridViewTextBoxColumn
            // 
            this.mCategoryDataGridViewTextBoxColumn.DataPropertyName = "mCategory";
            resources.ApplyResources(this.mCategoryDataGridViewTextBoxColumn, "mCategoryDataGridViewTextBoxColumn");
            this.mCategoryDataGridViewTextBoxColumn.Name = "mCategoryDataGridViewTextBoxColumn";
            // 
            // mPriceDataGridViewTextBoxColumn
            // 
            this.mPriceDataGridViewTextBoxColumn.DataPropertyName = "mPrice";
            resources.ApplyResources(this.mPriceDataGridViewTextBoxColumn, "mPriceDataGridViewTextBoxColumn");
            this.mPriceDataGridViewTextBoxColumn.Name = "mPriceDataGridViewTextBoxColumn";
            // 
            // iSDateDataGridViewTextBoxColumn
            // 
            this.iSDateDataGridViewTextBoxColumn.DataPropertyName = "iSDate";
            resources.ApplyResources(this.iSDateDataGridViewTextBoxColumn, "iSDateDataGridViewTextBoxColumn");
            this.iSDateDataGridViewTextBoxColumn.Name = "iSDateDataGridViewTextBoxColumn";
            // 
            // tInStockingBindingSource
            // 
            this.tInStockingBindingSource.DataMember = "T_InStocking";
            this.tInStockingBindingSource.DataSource = this.bYMMDataSetQInstockDategridView;
            // 
            // bYMMDataSetQInstockDategridView
            // 
            this.bYMMDataSetQInstockDategridView.DataSetName = "BYMMDataSetQInstockDategridView";
            this.bYMMDataSetQInstockDategridView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btQuery
            // 
            resources.ApplyResources(this.btQuery, "btQuery");
            this.btQuery.Name = "btQuery";
            this.btQuery.UseVisualStyleBackColor = true;
            this.btQuery.Click += new System.EventHandler(this.btQuery_Click);
            // 
            // cbMName
            // 
            this.cbMName.FormattingEnabled = true;
            this.cbMName.Items.AddRange(new object[] {
            resources.GetString("cbMName.Items"),
            resources.GetString("cbMName.Items1"),
            resources.GetString("cbMName.Items2"),
            resources.GetString("cbMName.Items3"),
            resources.GetString("cbMName.Items4"),
            resources.GetString("cbMName.Items5"),
            resources.GetString("cbMName.Items6"),
            resources.GetString("cbMName.Items7"),
            resources.GetString("cbMName.Items8"),
            resources.GetString("cbMName.Items9"),
            resources.GetString("cbMName.Items10")});
            resources.ApplyResources(this.cbMName, "cbMName");
            this.cbMName.Name = "cbMName";
            // 
            // Qdep
            // 
            resources.ApplyResources(this.Qdep, "Qdep");
            this.Qdep.BackColor = System.Drawing.Color.Transparent;
            this.Qdep.Name = "Qdep";
            // 
            // output
            // 
            resources.ApplyResources(this.output, "output");
            this.output.Name = "output";
            this.output.UseVisualStyleBackColor = true;
            this.output.Click += new System.EventHandler(this.output_Click);
            // 
            // quit
            // 
            resources.ApplyResources(this.quit, "quit");
            this.quit.Name = "quit";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // t_InStockingTableAdapter
            // 
            this.t_InStockingTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // totalPrice
            // 
            resources.ApplyResources(this.totalPrice, "totalPrice");
            this.totalPrice.BackColor = System.Drawing.Color.Transparent;
            this.totalPrice.Name = "totalPrice";
            // 
            // QInstocking
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MM.Properties.Resources.backGI;
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.output);
            this.Controls.Add(this.Qdep);
            this.Controls.Add(this.cbMName);
            this.Controls.Add(this.btQuery);
            this.Controls.Add(this.dgQIn);
            this.Name = "QInstocking";
            this.Load += new System.EventHandler(this.QInstocking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgQIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tInStockingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bYMMDataSetQInstockDategridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgQIn;
       
        private System.Windows.Forms.Button btQuery;
        private System.Windows.Forms.ComboBox cbMName;
        private System.Windows.Forms.Label Qdep;
        private System.Windows.Forms.Button output;
        private System.Windows.Forms.Button quit;
        private BYMMDataSetQInstockDategridView bYMMDataSetQInstockDategridView;
        private System.Windows.Forms.BindingSource tInStockingBindingSource;
        private BYMMDataSetQInstockDategridViewTableAdapters.T_InStockingTableAdapter t_InStockingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalPrice;
    }
}