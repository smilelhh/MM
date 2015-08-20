﻿using System;
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
    public partial class Fixed : Form
    {
        public Fixed()
        {
            InitializeComponent();
        }

        private void Fixed_Load(object sender, EventArgs e)
        {
            string connString = "server=172.168.16.235;Initial Catalog=BYMM;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(connString);
            string sqlString = "SELECT mNum FROM T_ApplyFix";
            try
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlString, conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                cb_mnum.DataSource = ds.Tables[0].DefaultView;
                cb_mnum.DisplayMember = ds.Tables[0].Rows[0].ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("!查询申请修理表失败", "友情提示");
            }
            finally
            {
                conn.Close();
            }
            //this.t_ApplyFixTableAdapter.Fill(this.bYMMDataSetFixed.T_ApplyFix);
            tbmdate.Text = DateTime.Now.Date.ToShortDateString().Trim();
        }

        private void cb_mnum_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mNum = cb_mnum.Text.Trim();
            string connString = "server=172.168.16.235;Initial Catalog=BYMM;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(connString);
            string sqlString = "SELECT * FROM T_ApplyFix where mNum='" + mNum + "'";
            try
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlString, conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                tbmname.Text = ds.Tables[0].Rows[0][1].ToString();
                tbmcategory.Text = ds.Tables[0].Rows[0][2].ToString();
                tbmprice.Text = ds.Tables[0].Rows[0][3].ToString();
                tbapname.Text = ds.Tables[0].Rows[0][5].ToString();
                tbapnum.Text = ds.Tables[0].Rows[0][6].ToString();
                tbaptel.Text = ds.Tables[0].Rows[0][7].ToString();
                tbapdep.Text = ds.Tables[0].Rows[0][8].ToString();
                tbapdeptel.Text = ds.Tables[0].Rows[0][9].ToString();
                tbmagent.Text = ds.Tables[0].Rows[0][10].ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("!查询申请修理表失败", "友情提示");
            }
            finally
            {
                conn.Close();
            }
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            DateTime fixedOrScrap_date = new DateTime();
            fixedOrScrap_date = Convert.ToDateTime(tbmdate.Text.Trim());
            float mPrice = 0;
            if (tbmprice.Text.Trim() != string.Empty)
            {
                mPrice = float.Parse(tbmprice.Text.Trim());
            }
            string connString = "server=172.168.16.235;Initial Catalog=BYMM;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(connString);
            string sqlStringFixed = "insert into T_Fixed values('" + cb_mnum.Text.Trim() + "','" + tbmname.Text.Trim() + "','" + tbmcategory.Text.Trim() + "'," + mPrice + ",'" + fixedOrScrap_date + "','" + tbapname.Text.Trim() + "','" + tbapnum.Text.Trim() + "','" + tbaptel.Text.Trim() + "','" + tbapdep.Text.Trim() + "','" + tbapdeptel.Text.Trim() + "','" + tbmagent.Text.Trim() + "')";
            string sqlStringInStock = "insert into T_InStocking values('" + cb_mnum.Text.Trim() + "','" + tbmname.Text.Trim() + "','" + tbmcategory.Text.Trim() + "'," + mPrice + ",'" + fixedOrScrap_date +"')";
            string sqlStringScrap = "insert into T_Scraping values('" + cb_mnum.Text.Trim() + "','" + tbmname.Text.Trim() + "','" + tbmcategory.Text.Trim() + "'," + mPrice + ",'" + fixedOrScrap_date + "','" + tbapname.Text.Trim() + "','" + tbapnum.Text.Trim() + "','" + tbaptel.Text.Trim() + "','" + tbapdep.Text.Trim() + "','" + tbapdeptel.Text.Trim() + "','" + tbmagent.Text.Trim() + "')";
            
            if (cbFixed.Text.Trim() == "修好")
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlStringFixed, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("恭喜，修理成功", "友情提示");

                }
                catch (Exception)
                {
                    MessageBox.Show("!插入已修理表失败", "友情提示");
                }
                finally
                {
                    conn.Close();
                }
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlStringInStock, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("恭喜，修好重新入库", "友情提示");

                }
                catch (Exception)
                {
                    MessageBox.Show("!插入入库表失败", "友情提示");
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
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlStringScrap, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("哎，报废一台设备啦，不开心！", "友情提示");

                }
                catch (Exception)
                {
                    MessageBox.Show("!插入报废表失败", "友情提示");
                }
                finally
                {
                    conn.Close();
                }
            }
            try
            {
                conn.Open();
                string sql = "delete from T_ApplyFix where mNum='" + cb_mnum.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("！删除报修情况表失败", "友情提示");
            }
            finally
            {
                conn.Close();
                tbmname.Text = null;
                tbmcategory.Text = null;
                tbmprice.Text = null;
                tbmagent.Text = null;
                tbapname.Text = null;
                tbapnum.Text = null;
                tbaptel.Text = null;
                tbapdep.Text = null;
                tbapdeptel.Text = null;
                cbFixed.Text = null;
            } 
        }

        private void button_concle_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
