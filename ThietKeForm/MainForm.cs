using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKeForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tsmi1_Click(object sender, EventArgs e)
        {
            var form = new frm1();
            form.ShowDialog();
        }

        private void tsmi2_Click(object sender, EventArgs e)
        {
            var form = new frm2();
            form.ShowDialog();
        }

        private void tsmi3_Click(object sender, EventArgs e)
        {
            var form = new frm3();
            form.ShowDialog();
        }

        private void bài4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frm4();
            form.ShowDialog();
        }
    }
}
