﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kullaniciogrencihocaform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string skulladi = "admin";
        string ssifre = "123456";
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == skulladi && textBox2.Text == ssifre)
            {

            this.Hide();//küçük ekranı gizliyoruz
                Form2 form2 = new Form2();
                form2.WindowState=FormWindowState.Maximized; //ekran maksimum olsun
                form2.Show();
            }
            else
                MessageBox.Show("Kullanıcı giriş bilgileri hatalıdır");
        }
    }
}
