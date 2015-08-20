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
    public partial class InStockAdd : Form
    {
        public InStockAdd()
        {
            InitializeComponent();
        }
        private void InStock_Load(object sender, EventArgs e)
        {
            tbDate.Text = DateTime.Now.Date.ToShortDateString().Trim();
        }
        

        private void InStock_Save_Click(object sender, EventArgs e)
        {
            string connString = "server=172.168.16.235;Initial Catalog=BYMM;uid=sa;pwd=123456";

            SqlConnection conn = new SqlConnection(connString);

            string tbmnum =tbMNum.Text.Trim();
            string tbcategory = tbCategory.Text.Trim();
            string cbmname = cbMName.Text.Trim();
            float tbprice = 0;
            if (tbPrice.Text.Trim() != string.Empty)
            {
                tbprice = float.Parse(tbPrice.Text.Trim());
            }
            
            DateTime InStock_date = new DateTime();
            InStock_date = Convert.ToDateTime(tbDate.Text);
            string sqlString = "INSERT INTO T_InStocking VALUES('" + tbmnum + "','" + cbmname + "','" + tbcategory + "'," + tbprice + ",'" + InStock_date + "')";
            if (tbmnum != string.Empty)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlString, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("添加设备信息成功！", "友情提示");
                }
                catch (Exception)
                {
                    MessageBox.Show("!插入设备记录失败，请重试", "友情提示");
                }
                finally
                {
                    conn.Close();
                    tbMNum.Text = "";
                    tbCategory.Text = "";
                    cbMName.Text = "";
                    tbPrice.Text = "";
                }
            }
            else
            {
                MessageBox.Show("设备代码不能为空！请重新输入", "友情提示");

            }
        }

        private void InStock_Concle_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
