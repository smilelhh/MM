using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace MM
{
    class OutputExcel
    {
        public void coutExcel(DataGridView dataGridView1)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "导出Excel (*.xls)|*.xls";
                saveFileDialog.FilterIndex = 0;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.CreatePrompt = true;
                saveFileDialog.Title = "导出文件保存路径";
                saveFileDialog.ShowDialog();
                string strName = saveFileDialog.FileName;
                if (strName.Length != 0)
                {
                    //无数据则不再执行
                    if (dataGridView1.Rows.Count == 0)
                    {
                        return;
                    }
                    //实例化Excel.Application对象
                    System.Reflection.Missing miss = System.Reflection.Missing.Value;
                    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                    excel.Application.Workbooks.Add(true);
                    excel.Visible = false;//为TRUE在导出时显示EXCEL界面
                    if (excel == null)
                    {
                        MessageBox.Show("EXCEL无法启动！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    Microsoft.Office.Interop.Excel.Workbooks books = excel.Workbooks;
                    Microsoft.Office.Interop.Excel.Workbook book = (Microsoft.Office.Interop.Excel.Workbook)(books.Add(miss));
                    Microsoft.Office.Interop.Excel.Worksheet sheet = (Microsoft.Office.Interop.Excel.Worksheet)book.ActiveSheet;
                    sheet.Name = "test";
                    //int m = 0, n = 0;
                    //生成EXCEL列名
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        excel.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;//输出DataGridView列头名 
                    }
                    //存储数据
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {

                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {

                            if (dataGridView1[j, i].ValueType == typeof(string))
                            {

                                excel.Cells[i + 2, j + 1] = "'" + dataGridView1[j, i].Value.ToString();

                            }

                            else
                            {

                                excel.Cells[i + 2, j + 1] = dataGridView1[j, i].Value.ToString();

                            }

                        }

                    }
                    sheet.SaveAs(strName, miss, miss, miss, miss, miss, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, miss, miss, miss);
                    book.Close(false, miss, miss);
                    books.Close();
                    excel.Quit();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(sheet);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(book);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(books);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);
                    GC.Collect();
                    MessageBox.Show("数据已经成功导出!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Diagnostics.Process.Start(strName);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "错误提示");

            }
        }
    }
}
