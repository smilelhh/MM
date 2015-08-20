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
    public partial class QScrap : Form
    {
        public DateTime startDate;
        public DateTime endDate;
        public QScrap()
        {
            InitializeComponent();
        }
        private void ScrapDetail_Load(object sender, EventArgs e)
        {
            string connString = "server=172.168.16.235;Initial Catalog=BYMM;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(connString);
            string sqlString = "SELECT * FROM T_Scraping";
            try
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlString, conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dgScrapDetail.DataSource = ds.Tables[0].DefaultView;
                dgScrapDetail.BackgroundColor = Color.LightGray;
                this.dgScrapDetail.Columns[0].HeaderText = "设备代码";
                this.dgScrapDetail.Columns[1].HeaderText = "设备名称";
                this.dgScrapDetail.Columns[2].HeaderText = "设备类型";
                this.dgScrapDetail.Columns[3].HeaderText = "设备价格";
                this.dgScrapDetail.Columns[4].HeaderText = "报废日期";
                this.dgScrapDetail.Columns[5].HeaderText = "报废申请人";
                this.dgScrapDetail.Columns[6].HeaderText = "工号";
                this.dgScrapDetail.Columns[7].HeaderText = "电话号码";
                this.dgScrapDetail.Columns[8].HeaderText = "部门";
                this.dgScrapDetail.Columns[9].HeaderText = "部门电话";
                this.dgScrapDetail.Columns[10].HeaderText = "经办人";
            }
            catch (Exception)
            {
                MessageBox.Show("!查询报废表失败", "友情提示");
            }
            finally
            {
                conn.Close();
            }
            //this.t_ScrapingTableAdapter.Fill(this.bYMMDataSetScrapDetail.T_Scraping);
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
                sql = " and applicant_dept ='" + cbmdept + "'";
            }
            if (tbstartdate != string.Empty && tbenddate != string.Empty)
            {
                startDate = Convert.ToDateTime(tbStartDate.Text.Trim());
                endDate = Convert.ToDateTime(tbEndDate.Text.Trim());
                sql += " and mDate between '" + startDate + "' and '" + endDate + "'";
            }
            string connString = "server=172.168.16.235;Initial Catalog=BYMM;uid=sa;pwd=123456";
            string _sql = "Select * from T_Scraping where 1=1" + sql;
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                int i;
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                dgScrapDetail.DataSource = ds.Tables[0].DefaultView;
                RowNum = dgScrapDetail.Rows.Count - 1;
                for (i = 0; i < RowNum; i++)
                {
                    countMoney += Convert.ToDouble(dgScrapDetail.Rows[i].Cells[3].Value);
                }
                totalPrice.Text = countMoney.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("！查询报废表失败，请重试", "提示");
            }
            finally
            {
                conn.Close();
            }
            /*double countMoney = 0;
            int RowNum = 0;
            string cbdepname = cbDepName.Text.Trim();
            string connString = "Data Source=.;Initial Catalog=BYMM;Integrated Security=True;Pooling=False";
            SqlConnection conn = new SqlConnection(connString);
            if (tbStartDate.Text.Trim() != string.Empty && tbEndDate.Text.Trim() != string.Empty)
            {
                startDate = Convert.ToDateTime(tbStartDate.Text.Trim());
                endDate = Convert.ToDateTime(tbEndDate.Text.Trim());
            }
            else
            {
                MessageBox.Show("起止日期不允许为空，请重新输入！", "提示");
            }
            string dateSql = "select * from T_Scraping where mDate between '" + startDate + "'and '" + endDate + "'";
            string depNameSql = "Select * from T_Scraping where applicant_dept ='" + cbdepname + "' AND mDate between '" + startDate + "' and '" + endDate + "'";

            if (cbdepname == string.Empty)
            {
                try
                {
                    int i;
                    conn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(dateSql, conn);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    dgScrapDetail.DataSource = ds.Tables[0].DefaultView;
                    RowNum = dgScrapDetail.Rows.Count - 1;
                    for (i = 0; i < RowNum; i++)
                    {
                        countMoney += Convert.ToDouble(dgScrapDetail.Rows[i].Cells[3].Value);
                    }
                    totalPrice.Text = countMoney.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("查询失败，请重试！", "提示");
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                try
                {
                    int i;
                    conn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(depNameSql, conn);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    dgScrapDetail.DataSource = ds.Tables[0].DefaultView;
                    RowNum = dgScrapDetail.Rows.Count - 1;
                    for (i = 0; i < RowNum; i++)
                    {
                        countMoney += Convert.ToDouble(dgScrapDetail.Rows[i].Cells[3].Value);
                    }
                    totalPrice.Text = countMoney.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("查询失败，请重试！", "提示");
                }
                finally
                {
                    conn.Close();
                }
            }*/
        }

        private void output_Click(object sender, EventArgs e)
        {
            OutputExcel oe = new OutputExcel();
            oe.coutExcel(dgScrapDetail);
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}