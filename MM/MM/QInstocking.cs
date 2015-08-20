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
    public partial class QInstocking : Form
    {
        public DateTime StartDate;
        public DateTime EndDate;
        public QInstocking()
        {
            InitializeComponent();
        }

        private void QInstocking_Load(object sender, EventArgs e)
        {
            string connString = "server=172.168.16.235;Initial Catalog=BYMM;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(connString);
            string sqlString = "SELECT * FROM T_InStocking";
            try
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlString, conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dgQIn.DataSource = ds.Tables[0].DefaultView;
                dgQIn.BackgroundColor = Color.LightGray;
                this.dgQIn.Columns[0].HeaderText = "设备代码";
                this.dgQIn.Columns[1].HeaderText = "设备名称";
                this.dgQIn.Columns[2].HeaderText = "设备类型";
                this.dgQIn.Columns[3].HeaderText = "设备价格";
                this.dgQIn.Columns[4].HeaderText = "入库日期"; 
            }
            catch (Exception)
            {
                MessageBox.Show("!查询入库表失败", "友情提示");
            }
            finally
            {
                conn.Close();
            }
            //this.t_InStockingTableAdapter.Fill(this.bYMMDataSetQInstockDategridView.T_InStocking);
        }

        private void btQuery_Click(object sender, EventArgs e)
        {
            double countMoney = 0;
            int RowNum = 0;
            string cbmname = cbMName.Text.Trim();
            string connString = "server=172.168.16.235;Initial Catalog=BYMM;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(connString);

            string mnamesql = "Select * from T_InStocking where mName = '" + cbmname + "'";
            string allselsql = "Select * from T_InStocking";
            if (cbmname == string.Empty)
            {
                try
                {
                    int i;
                    conn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(allselsql, conn);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    dgQIn.DataSource = ds.Tables[0].DefaultView;
                    RowNum = dgQIn.Rows.Count - 1;
                    for (i = 0; i < RowNum; i++)
                    {
                        countMoney += Convert.ToDouble(dgQIn.Rows[i].Cells[3].Value);
                    }
                    totalPrice.Text = countMoney.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("!查询入库表失败，请重试", "提示");
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
                    SqlDataAdapter sda = new SqlDataAdapter(mnamesql, conn);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    dgQIn.DataSource = ds.Tables[0].DefaultView;
                    RowNum = dgQIn.Rows.Count - 1;
                    for (i = 0; i < RowNum; i++)
                    {
                        countMoney += Convert.ToDouble(dgQIn.Rows[i].Cells[3].Value);
                    }
                    totalPrice.Text = countMoney.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("！查询入库表失败，请重试", "提示");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void output_Click(object sender, EventArgs e)
        {
            OutputExcel oe = new OutputExcel();
            oe.coutExcel(dgQIn);
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Close();
        }

      
    }
}
