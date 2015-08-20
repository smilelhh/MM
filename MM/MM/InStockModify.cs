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
    public partial class InStockModify : Form
    {
        public InStockModify()
        {
            InitializeComponent();
        }

        private void InStockModify_Load(object sender, EventArgs e)
        {
            string connString = "server=172.168.16.235;Initial Catalog=BYMM;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(connString);
            string sqlString = "SELECT mNum FROM T_InStocking";
            try
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlString, conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                cbMNum.DataSource = ds.Tables[0].DefaultView;
                cbMNum.DisplayMember = ds.Tables[0].Rows[0].ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("!查询入库表失败", "友情提示");
            }
            finally
            {
                conn.Close();
            }
        }

        private void cbMNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mNum = cbMNum.Text.Trim();
            string connString = "server=172.168.16.235;Initial Catalog=BYMM;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(connString);
            string sqlString = "SELECT * FROM T_InStocking where mNum='" + mNum + "'";
            try
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlString, conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                cbMName.Text = ds.Tables[0].Rows[0][1].ToString();
                tbCategory.Text = ds.Tables[0].Rows[0][2].ToString();
                tbPrice.Text = ds.Tables[0].Rows[0][3].ToString();
                DateTime oSDate1 = new DateTime();
                oSDate1 = Convert.ToDateTime(ds.Tables[0].Rows[0][4].ToString());
                tbDate.Text = oSDate1.ToShortDateString();
               
            }
            catch (Exception)
            {
                MessageBox.Show("!查询入库表失败", "友情提示");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btModify_Click(object sender, EventArgs e)
        {
            DateTime iSDate = new DateTime();
            if (tbDate.Text.Trim() != string.Empty)
            {
                iSDate = Convert.ToDateTime(tbDate.Text.Trim());
            }   
           
            float mPrice = 0;
            if (tbPrice.Text.Trim() != string.Empty)
            {
                mPrice = float.Parse(tbPrice.Text.Trim());
            }
            string connString = "server=172.168.16.235;Initial Catalog=BYMM;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(connString);
            string sqlString = "update T_InStocking set mNum='" + cbMNum.Text.Trim() + "',mName='" + cbMName.Text.Trim() + "',mCategory='" + tbCategory.Text.Trim() + "',mPrice=" + mPrice + ",iSDate='" + iSDate + "' where mNum='" + cbMNum.Text.Trim() + "'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlString, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("恭喜，修改入库表信息成功", "友情提示");

            }
            catch (Exception)
            {
                MessageBox.Show("!修改入库表失败", "友情提示");
            }
            finally
            {
                conn.Close();
                cbMName.Text = null;
                tbCategory.Text = null;
                tbPrice.Text = null;
                tbDate.Text = null;
            }
        }

        private void InStock_Concle_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
