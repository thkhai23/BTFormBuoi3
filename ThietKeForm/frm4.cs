﻿using System;
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
    public partial class frm4 : Form
    {
        public frm4()
        {
            InitializeComponent();
        }

        private void frm4_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            int so;
            for (int i = 1; i <= 10; i++)
            {
                so = rand.Next(1, 100);
                listBox1.Items.Add(so);

            } 
                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTimSo_Click(object sender, EventArgs e)
        {
            int soCanTim = int.Parse(txtNhapSo.Text);
            lblKetQua.Text = "Không tìm thấy";
            foreach (int so in  listBox1.Items) 
            {
                if (so == soCanTim)
                {
                    lblKetQua.Text = "Tìm thấy";
                    break;
                }
          

            }
        }
    }
}
