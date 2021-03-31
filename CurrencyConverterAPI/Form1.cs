﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace CurrencyConverterAPI
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

            int i = int.Parse(txtAmount.Text);

            if (fromComboBox.SelectedItem == "Rupee" && toComboBox.SelectedItem == "Dollar")
            {
                int conv = i / 103;
                txtDisplay.Text =  conv + "\t $";
            }
            if (fromComboBox.SelectedItem == "Dollar" && toComboBox.SelectedItem == "Rupee")
            {
                int conv = i * 103;
                txtDisplay.Text = conv + "\t Rupee";
            }
            if (fromComboBox.SelectedItem == "Euro" && toComboBox.SelectedItem == "Dollar")
            {
                int conv = i * 2;
                txtDisplay.Text =  conv + "\t $";
            }
            if (fromComboBox.SelectedItem == "Dollar" && toComboBox.SelectedItem == "Euro")
            {
                int conv = i / 2;
                txtDisplay.Text =  conv + "\t Euro";
            }
            if (fromComboBox.SelectedItem == "Rupee" && toComboBox.SelectedItem == "Euro")
            {
                int conv = i / 115;
                txtDisplay.Text =  conv + "\t Euro";
            }
            if (fromComboBox.SelectedItem == "Euro" && toComboBox.SelectedItem == "Rupee")
            {
                int conv = i * 115;
                txtDisplay.Text =  conv + "\t Rupee";
            } 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
