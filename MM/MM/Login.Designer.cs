namespace MM
{
    partial class FormLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxUserpass = new System.Windows.Forms.TextBox();
            this.labelUserpass = new System.Windows.Forms.Label();
            this.textBoxUsercode = new System.Windows.Forms.TextBox();
            this.labelUsercode = new System.Windows.Forms.Label();
            this.gbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLogin
            // 
            this.gbLogin.BackColor = System.Drawing.Color.Transparent;
            this.gbLogin.Controls.Add(this.buttonExit);
            this.gbLogin.Controls.Add(this.buttonLogin);
            this.gbLogin.Controls.Add(this.textBoxUserpass);
            this.gbLogin.Controls.Add(this.labelUserpass);
            this.gbLogin.Controls.Add(this.textBoxUsercode);
            this.gbLogin.Controls.Add(this.labelUsercode);
            this.gbLogin.ForeColor = System.Drawing.Color.White;
            this.gbLogin.Location = new System.Drawing.Point(12, 12);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(282, 163);
            this.gbLogin.TabIndex = 0;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "用户登录！";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonExit.Location = new System.Drawing.Point(171, 118);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 32);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "退 出";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonLogin.Location = new System.Drawing.Point(27, 118);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 32);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "登 录";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxUserpass
            // 
            this.textBoxUserpass.Location = new System.Drawing.Point(110, 72);
            this.textBoxUserpass.Name = "textBoxUserpass";
            this.textBoxUserpass.PasswordChar = '*';
            this.textBoxUserpass.Size = new System.Drawing.Size(121, 23);
            this.textBoxUserpass.TabIndex = 3;
            // 
            // labelUserpass
            // 
            this.labelUserpass.AutoSize = true;
            this.labelUserpass.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelUserpass.ForeColor = System.Drawing.Color.White;
            this.labelUserpass.Location = new System.Drawing.Point(41, 75);
            this.labelUserpass.Name = "labelUserpass";
            this.labelUserpass.Size = new System.Drawing.Size(63, 14);
            this.labelUserpass.TabIndex = 2;
            this.labelUserpass.Text = "密  码：";
            // 
            // textBoxUsercode
            // 
            this.textBoxUsercode.Location = new System.Drawing.Point(110, 36);
            this.textBoxUsercode.Name = "textBoxUsercode";
            this.textBoxUsercode.Size = new System.Drawing.Size(121, 23);
            this.textBoxUsercode.TabIndex = 1;
            // 
            // labelUsercode
            // 
            this.labelUsercode.AutoSize = true;
            this.labelUsercode.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelUsercode.ForeColor = System.Drawing.Color.White;
            this.labelUsercode.Location = new System.Drawing.Point(41, 39);
            this.labelUsercode.Name = "labelUsercode";
            this.labelUsercode.Size = new System.Drawing.Size(63, 14);
            this.labelUsercode.TabIndex = 0;
            this.labelUsercode.Text = "用户名：";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::MM.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(306, 187);
            this.Controls.Add(this.gbLogin);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "欢迎使用！";
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxUserpass;
        private System.Windows.Forms.Label labelUserpass;
        private System.Windows.Forms.TextBox textBoxUsercode;
        private System.Windows.Forms.Label labelUsercode;
    }
}

