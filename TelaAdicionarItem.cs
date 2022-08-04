using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using R9.DataBase;

namespace Project_Inventory
{
    public partial class TelaAdicionarItem : Form
    {
        public TelaAdicionarItem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControleItems controle = new ControleItems();

            string item = comboItem.Text;
            //int idItem = 
            int quantidade = Int32.Parse(comboQuantidade.SelectedItem.ToString());
            string descricao = richTextBox1.Text;

            Console.WriteLine(comboItem.SelectedValue);

            controle.AdicionarItem(item, quantidade, descricao);

            Dispose();
        }

        private void TelaAdicionarItem_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dblucianoDataSet.ItensCriados'. Você pode movê-la ou removê-la conforme necessário.
            this.itensCriadosTableAdapter.Fill(this.dblucianoDataSet.ItensCriados);
        }


    }
}
