using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace MM
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string connString = "server=172.168.16.235;Initial Catalog=BYMM;uid=sa;pwd=123456";
           
            SqlConnection conn = new SqlConnection(connString);
            Boolean flag = false;
            try
            {
                conn.Open();
                string sqlString = "SELECT * FROM T_User";
                SqlCommand cmd = new SqlCommand(sqlString, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                
                while (rdr.Read())
                {
                    if (textBoxUsercode.Text == (string)rdr[0] && textBoxUserpass.Text == (string)rdr[2])
                    {
                        if ((string)rdr[3] == "gly")
                        {

                            MainForm mf = new MainForm();
                            this.Hide();
                            mf.ShowDialog(this);
                            flag = true;
                            this.Close();
                        }
                    }
                }
                if (!flag)
                {
                    MessageBox.Show("!对不起！您没有权限访问此系统", "友情提示");
                    flag = true;
                }
                rdr.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("!查询登录表失败", "友情提示");
            }
            finally
            {
                if (!flag)
                {
                    MessageBox.Show("!用户标识或口令键入有误，请予更正！");
                }
                conn.Close();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
