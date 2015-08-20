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
    public partial class QInUsing : Form
    {
        public DateTime startDate;
        public DateTime endDate;
        public QInUsing()
        {
            InitializeComponent();
        }

        private void QInUsing_Load(object sender, EventArgs e)
        {
            string connString = "server=172.168.16.235;Initial Catalog=BYMM;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(connString);
            string sqlString = "SELECT * FROM T_InUsing";
            try
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlString, conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dgQIU.DataSource = ds.Tables[0].DefaultView;
                dgQIU.BackgroundColor = Color.LightGray;
                this.dgQIU.Columns[0].HeaderText = "设备代码";
                this.dgQIU.Columns[1].HeaderText = "设备名称";
                this.dgQIU.Columns[2].HeaderText = "设备类型";
                this.dgQIU.Columns[3].HeaderText = "设备价格";
                this.dgQIU.Columns[4].HeaderText = "出库日期";
                this.dgQIU.Columns[5].HeaderText = "使用者";
                this.dgQIU.Columns[6].HeaderText = "工号";
                this.dgQIU.Columns[7].HeaderText = "电话号码";
                this.dgQIU.Columns[8].HeaderText = "部门";
                this.dgQIU.Columns[9].HeaderText = "部门电话";
                this.dgQIU.Columns[10].HeaderText = "经办人";
            }
            catch (Exception)
            {
                MessageBox.Show("!查询申领表失败", "友情提示");
            }
            finally
            {
                conn.Close();
            }
            //this.t_InUsingTableAdapter.Fill(this.bYMMDataSetQInUsing.T_InUsing);
            tbStartDate.Text = DateTime.Now.Date.ToShortDateString().Trim();
            tbEndDate.Text = DateTime.Now.Date.ToShortDateString().Trim();
        }

        private void btQuery_Click(object sender, EventArgs e)
        {
            double countMoney = 0;
            int RowNum = 0;
            string cbmdept = cbMDept.Text.Trim();
            string cbmname = cbMName.Text.Trim();
            string tbstartdate = tbStartDate.Text.Trim();
            string tbenddate = tbEndDate.Text.Trim();

            string sql = "";
            if (cbmdept != string.Empty)
            {
                sql = " and owner_dept='" + cbmdept + "'";
            }
            if (cbmname != string.Empty)
            {
                sql += " and mName='" + cbmname + "'";
            }
            if (tbstartdate != string.Empty && tbenddate != string.Empty)
            {
                startDate = Convert.ToDateTime(tbStartDate.Text.Trim());
                endDate = Convert.ToDateTime(tbEndDate.Text.Trim());
                sql += " and oSDate between '" + startDate + "' and '" + endDate + "'";
            }

            string connString = "server=172.168.16.235;Initial Catalog=BYMM;uid=sa;pwd=123456";
            string _sql = "Select * from T_InUsing where 1=1" + sql;
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                int i;
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                dgQIU.DataSource = ds.Tables[0].DefaultView;
                RowNum = dgQIU.Rows.Count - 1;
                for (i = 0; i < RowNum; i++)
                {
                    countMoney += Convert.ToDouble(dgQIU.Rows[i].Cells[3].Value);
                }
                totalPrice.Text = countMoney.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("！查询申领表失败，请重试", "提示");
            }
            finally
            {
                conn.Close();
            }  
        }

        private void output_Click(object sender, EventArgs e)
        {
            OutputExcel oe = new OutputExcel();
            oe.coutExcel(dgQIU);
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Close();
        }        
    }
}
