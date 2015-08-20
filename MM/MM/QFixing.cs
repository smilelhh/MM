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
    public partial class QFixing : Form
    {
        public QFixing()
        {
            InitializeComponent();
        }

        private void Fixing_Load(object sender, EventArgs e)
        {
            string connString = "server=172.168.16.235;Initial Catalog=BYMM;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(connString);
            string sqlString = "SELECT * FROM T_ApplyFix";
            try
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlString, conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dgFixing.DataSource = ds.Tables[0].DefaultView;
                dgFixing.BackgroundColor = Color.LightGray;
                this.dgFixing.Columns[0].HeaderText = "设备代码";
                this.dgFixing.Columns[1].HeaderText = "设备名称";
                this.dgFixing.Columns[2].HeaderText = "设备类型";
                this.dgFixing.Columns[3].HeaderText = "设备价格";
                this.dgFixing.Columns[4].HeaderText = "报修日期";
                this.dgFixing.Columns[5].HeaderText = "报修申请人";
                this.dgFixing.Columns[6].HeaderText = "工号";
                this.dgFixing.Columns[7].HeaderText = "电话号码";
                this.dgFixing.Columns[8].HeaderText = "部门";
                this.dgFixing.Columns[9].HeaderText = "部门电话";
                this.dgFixing.Columns[10].HeaderText = "经办人";
            }
            catch (Exception)
            {
                MessageBox.Show("!查询报修表失败", "友情提示");
            }
            finally
            {
                conn.Close();
            }
            //this.t_ApplyFixTableAdapter.Fill(this.bYMMDataSetFixing.T_ApplyFix);
        }

        private void btQuery_Click(object sender, EventArgs e)
        {
            double countMoney = 0;
            int RowNum = 0;
            string cbmdept = cbMDept.Text.Trim();
            string cbmname = cbMName.Text.Trim();
            string sql = "";
            if (cbmdept != string.Empty)
            {
                sql = " and applicant_dept='" + cbmdept + "'";
            }
            if (cbmname != string.Empty)
            {
                sql += " and mName='" + cbmname + "'";
            }
            string connString = "server=172.168.16.235;Initial Catalog=BYMM;uid=sa;pwd=123456";
            string _sql = "Select * from T_ApplyFix where 1=1" + sql;
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                int i;
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(_sql, conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                dgFixing.DataSource = ds.Tables[0].DefaultView;
                RowNum = dgFixing.Rows.Count - 1;
                for (i = 0; i < RowNum; i++)
                {
                    countMoney += Convert.ToDouble(dgFixing.Rows[i].Cells[3].Value);
                }
                totalPrice.Text = countMoney.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("！查询报修表失败，请重试", "提示");
            }
            finally
            {
                conn.Close();
            }  
        }

        private void output_Click(object sender, EventArgs e)
        {
            OutputExcel oe = new OutputExcel();
            oe.coutExcel(dgFixing);
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
