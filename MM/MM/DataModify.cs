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
    public partial class DataModify : Form
    {
        public DataModify()
        {
            InitializeComponent();
        }

        private void DataModify_Load(object sender, EventArgs e)
        {
            string connString = "server=172.168.16.235;Initial Catalog=BYMM;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(connString);
            string sqlString = "SELECT mNum FROM T_InUsing";
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
                MessageBox.Show("!查询申领表失败", "友情提示");
            }
            finally
            {
                conn.Close();
            }
            //this.t_InUsingTableAdapter.Fill(this.bYMMDataSetDataModify.T_InUsing);
            //tbOSDate.Text = DateTime.Now.Date.ToShortDateString().Trim();
        }

        private void cbMNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mNum = cbMNum.Text.Trim();
            string connString = "server=172.168.16.235;Initial Catalog=BYMM;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(connString);
            string sqlString = "SELECT * FROM T_InUsing where mNum='" + mNum + "'";
            try
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlString, conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                tbMName.Text = ds.Tables[0].Rows[0][1].ToString();
                tbMCategory.Text = ds.Tables[0].Rows[0][2].ToString();
                tbMPrice.Text = ds.Tables[0].Rows[0][3].ToString();
                DateTime oSDate1 = new DateTime();
                oSDate1 = Convert.ToDateTime(ds.Tables[0].Rows[0][4].ToString());
                tbOSDate.Text = oSDate1.ToShortDateString();
                //tbOSDate.Text = ds.Tables[0].Rows[0][4].ToString();
                tbOwner.Text = ds.Tables[0].Rows[0][5].ToString();
                tbOwner_id.Text = ds.Tables[0].Rows[0][6].ToString();
                tbOwner_tel.Text = ds.Tables[0].Rows[0][7].ToString();
                tbOwner_dept.Text = ds.Tables[0].Rows[0][8].ToString();
                tbOwner_dept_tel.Text = ds.Tables[0].Rows[0][9].ToString();
                tbAgent_name.Text = ds.Tables[0].Rows[0][10].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("!查询申领表失败", "友情提示");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btModify_Click(object sender, EventArgs e)
        {
            DateTime oSDate = new DateTime();
            if (tbOSDate.Text.Trim() != string.Empty)
            {
                oSDate = Convert.ToDateTime(tbOSDate.Text.Trim());
            }   
            float mPrice = 0;
            if (tbMPrice.Text.Trim() != string.Empty)
            {
                mPrice = float.Parse(tbMPrice.Text.Trim());
            }
            string connString = "server=172.168.16.235;Initial Catalog=BYMM;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(connString);
            string sqlString = "update T_InUsing set mNum='" + cbMNum.Text.Trim() + "',mName='" + tbMName.Text.Trim() + "',mCategory='" + tbMCategory.Text.Trim() + "',mPrice=" + mPrice + ",oSDate='" + oSDate + "',owner='" + tbOwner.Text.Trim() + "',owner_id='" + tbOwner_id.Text.Trim() + "',owner_tel='" + tbOwner_tel.Text.Trim() + "',owner_dept='" + tbOwner_dept.Text.Trim() + "',owner_dept_tel='" + tbOwner_dept_tel.Text.Trim() + "',agent_name='" + tbAgent_name.Text.Trim() + "' where mNum='"+cbMNum.Text.Trim ()+"'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlString, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("恭喜，修改申领表信息成功", "友情提示");

            }
            catch (Exception)
            {
                MessageBox.Show("!修改申领表失败", "友情提示");
            }
            finally
            {
                conn.Close();
                tbMName.Text = null;
                tbMCategory.Text = null;
                tbMPrice.Text = null;
                tbOSDate.Text = null;
                tbAgent_name.Text = null;
                tbOwner.Text = null;
                tbOwner_id.Text = null;
                tbOwner_tel.Text = null;
                tbOwner_dept.Text = null;
                tbOwner_dept_tel.Text = null;
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
