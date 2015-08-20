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
    public partial class QFixed : Form
    {
        public DateTime startDate;
        public DateTime endDate;
        public QFixed()
        {
            InitializeComponent();
        }

        private void QFixed_Load(object sender, EventArgs e)
        {
            string connString = "server=172.168.16.235;Initial Catalog=BYMM;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(connString);
            string sqlString = "SELECT * FROM T_Fixed";
            try
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlString, conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dgQFixed.DataSource = ds.Tables[0].DefaultView;
                dgQFixed.BackgroundColor = Color.LightGray;
                this.dgQFixed.Columns[0].HeaderText = "设备代码";
                this.dgQFixed.Columns[1].HeaderText = "设备名称";
                this.dgQFixed.Columns[2].HeaderText = "设备类型";
                this.dgQFixed.Columns[3].HeaderText = "设备价格";
                this.dgQFixed.Columns[4].HeaderText = "修好日期";
                this.dgQFixed.Columns[5].HeaderText = "修理申请人";
                this.dgQFixed.Columns[6].HeaderText = "工号";
                this.dgQFixed.Columns[7].HeaderText = "电话号码";
                this.dgQFixed.Columns[8].HeaderText = "部门";
                this.dgQFixed.Columns[9].HeaderText = "部门电话";
                this.dgQFixed.Columns[10].HeaderText = "经办人";
            }
            catch (Exception)
            {
                MessageBox.Show("!查询已修理表失败", "友情提示");
            }
            finally
            {
                conn.Close();
            }
           //this.t_FixedTableAdapter.Fill(this.bYMMDataSetQFixed.T_Fixed);
           tbStartDate.Text = DateTime.Now.Date.ToShortDateString().Trim();
           tbEndDate.Text = DateTime.Now.Date.ToShortDateString().Trim();
        }

        private void btQuery_Click(object sender, EventArgs e)
        {
            double countMoney = 0;
            int RowNum = 0;
            string cbmdept = cbDepName.Text.Trim();
            string tbstartdate = tbStartDate.Text.Trim();
            string tbenddate = tbEndDate.Text.Trim();
           

            string sql = "";
            if (cbmdept != string.Empty)
            {
                sql = " and applicant_dept='" + cbmdept + "'";
            }
            if (tbstartdate != string.Empty && tbenddate !=string.Empty)
            {
                startDate = Convert.ToDateTime(tbStartDate.Text.Trim());
                endDate = Convert.ToDateTime(tbEndDate.Text.Trim());
                sql += " and mDate between '" + startDate + "'and '"+endDate+"'";
            }
            string connString = "server=172.168.16.235;Initial Catalog=BYMM;uid=sa;pwd=123456";
            string _sql = "Select * from T_Fixed where 1=1" + sql;
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                int i;
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                dgQFixed.DataSource = ds.Tables[0].DefaultView;
                RowNum = dgQFixed.Rows.Count - 1;
                for (i = 0; i < RowNum; i++)
                {
                    countMoney += Convert.ToDouble(dgQFixed.Rows[i].Cells[3].Value);
                }
                totalPrice.Text = countMoney.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("！查询已修理表失败，请重试", "提示");
            }
            finally
            {
                conn.Close();
            }  
        }

        private void output_Click(object sender, EventArgs e)
        {
            OutputExcel oe = new OutputExcel();
            oe.coutExcel(dgQFixed);
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
