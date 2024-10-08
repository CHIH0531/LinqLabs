﻿using LinqLabs.作業;
using MyHomeWork;
using Starter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqLabs
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            FrmHelloLinq f = new FrmHelloLinq();
            f.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLangForLINQ frm = new FrmLangForLINQ();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmLINQ架構介紹_InsideLINQ f = new FrmLINQ架構介紹_InsideLINQ();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmLINQ_To_XXX f = new FrmLINQ_To_XXX();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmLinq_To_Entity f = new FrmLinq_To_Entity();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frm作業_1 f = new Frm作業_1();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Frm作業_2 f = new Frm作業_2();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Frm作業_3 f = new Frm作業_3();
            f.Show();
        }
    }
}
