﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c;
            c = a + b;
            textBox3.Text = Convert.ToString(c);
            label4.Text = "Сложение";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c;
            c = a - b;
            textBox3.Text = Convert.ToString(c);
            label4.Text = "Вычитание";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c;
            c = a * b;
            textBox3.Text = Convert.ToString(c);
            label4.Text = "Умножение";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c;
            c = a / b;
            textBox3.Text = Convert.ToString(c);
            label4.Text = "Деление";
        }
    }
}
