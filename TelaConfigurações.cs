﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Inventory
{
    public partial class TelaConfigurações : Form
    {
        public TelaConfigurações()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dataDeHoje = DateTime.Today;

            DateTime primeiroDiaDoMes = new DateTime(dataDeHoje.Year, dataDeHoje.Month, 1);

            Dispose();
        }

        private void checkBoxInventarioAutomatico_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxInventarioAutomatico.Checked)
            {
                //process
            }
        }
    }
}
