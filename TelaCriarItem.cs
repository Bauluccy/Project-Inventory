using System;
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
    public partial class TelaCriarItem : Form
    {
        public TelaCriarItem()
        {
            InitializeComponent();
        }
            public static string novoItem;

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            novoItem = textBox1.Text;

            ControleItems.CriarItem(novoItem);
            Dispose();
        }
    }
}
