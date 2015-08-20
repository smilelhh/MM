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
    public partial class InUsing : Form
    {
        public InUsing()
        {
            InitializeComponent();
        }

        private void InUsing_Load(object sender, EventArgs e)
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
         
            tbOSDate.Text = DateTime.Now.Date.ToShortDateString().Trim();
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
                tbMName.Text = ds.Tables[0].Rows[0][1].ToString();
                tbMCategory.Text = ds.Tables[0].Rows[0][2].ToString();
                tbMPrice.Text = ds.Tables[0].Rows[0][3].ToString();
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

        private void btSubmit_Click(object sender, EventArgs e)
        {
            DateTime oSDate = new DateTime();
            if(tbOSDate.Text.Trim()!=string.Empty )
            {
                oSDate = Convert.ToDateTime(tbOSDate.Text.Trim());
            }
            float mPrice = 0;
            if(tbMPrice.Text.Trim()!=string.Empty)
            {
                mPrice = float.Parse(tbMPrice.Text.Trim());
            }
            string connString = "server=172.168.16.235;Initial Catalog=BYMM;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(connString);
            string sqlString = "insert into T_InUsing values('" + cbMNum.Text.Trim() + "','" + tbMName.Text.Trim() + "','" + tbMCategory.Text.Trim() + "'," + mPrice + ",'" + oSDate + "','" + tbOwner.Text.Trim() + "','" + tbOwner_id.Text.Trim() + "','" + tbOwner_tel.Text.Trim() + "','" + tbOwner_dept.Text.Trim() + "','" + tbOwner_dept_tel.Text.Trim() + "','" + tbAgent_name.Text.Trim() + "')";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlString,conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("恭喜，申领成功", "友情提示");

            }
            catch (Exception)
            {
                MessageBox.Show("!插入申领表失败", "友情提示");
            }
            finally
            {
                conn.Close();
            }
            try
            {
                conn.Open();
                string sql = "delete from T_InStocking where mNum='"+cbMNum.Text.Trim ()+"'";
                SqlCommand cmd = new SqlCommand(sql,conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("！删除入库表失败", "友情提示");
            }
            finally
            {
                conn.Close();
                tbMName.Text = null;
                tbMCategory.Text = null;
                tbMPrice.Text = null;
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
