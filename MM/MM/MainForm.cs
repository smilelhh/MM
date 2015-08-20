using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MM
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItemInStockAdd_Click(object sender, EventArgs e)
        {
            InStockAdd isa = new InStockAdd();
            isa.ShowDialog(this);
        }

        private void ToolStripMenuItemInStockModify_Click(object sender, EventArgs e)
        {
            InStockModify ism = new InStockModify();
            ism.ShowDialog(this);
        }   

        private void ToolStripMenuItemInUsing_Click(object sender, EventArgs e)
        {
            InUsing iu = new InUsing();
            iu.ShowDialog(this);
        }

        private void ToolStripMenuItemDataModify_Click(object sender, EventArgs e)
        {
            DataModify df = new DataModify();
            df.ShowDialog(this);
        }

        private void ToolStripMenuItemFixApplication_Click(object sender, EventArgs e)
        {
            FixApplication fa = new FixApplication();
            fa.ShowDialog(this);
        }


        private void ToolStripMenuItemFixed_Click(object sender, EventArgs e)
        {
            Fixed fd = new Fixed();
            fd.ShowDialog(this);
        }

        private void ToolStripMenuItemScrap_Click(object sender, EventArgs e)
        {
            Scrap sc = new Scrap();
            sc.ShowDialog(this);
        }

        private void ToolStripMenuItemISCount_Click(object sender, EventArgs e)
        {
            QInstocking qis = new QInstocking();
            qis.ShowDialog(this);
        }

        private void ToolStripMenuItemIUCount_Click(object sender, EventArgs e)
        {
            QInUsing qiu = new QInUsing();
            qiu.ShowDialog(this);
        }

        private void ToolStripMenuItemFixingCount_Click(object sender, EventArgs e)
        {
            QFixing fi = new QFixing();
            fi.ShowDialog(this);
        }

        private void ToolStripMenuItemFixedCount_Click(object sender, EventArgs e)
        {
            QFixed qfd = new QFixed();
            qfd.ShowDialog(this);
        }

        private void ToolStripMenuItemScrapCount_Click(object sender, EventArgs e)
        {
            QScrap sd = new QScrap();
            sd.ShowDialog(this);
        }

        private void ToolStripMenuItemExitSystem_Click(object sender, EventArgs e)
        {
            Close();
        }         
    }
}
