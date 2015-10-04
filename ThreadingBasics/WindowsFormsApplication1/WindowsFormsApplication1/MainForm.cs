﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnThreadBasics_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThreadSamples sample = new ThreadSamples();
            sample.FormClosing += Sample_FormClosing;
            sample.Show(this);
        }

        private void Sample_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show(); ;
        }
    }
}
