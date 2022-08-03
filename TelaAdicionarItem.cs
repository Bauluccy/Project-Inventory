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
            int quantidade = Int32.Parse(comboQuantidade.SelectedItem.ToString());
            string descricao = richTextBox1.Text;

            controle.AdicionarItem(item, quantidade, descricao);

            Dispose();
        }


        private void CarregaCombo()
        {
            //ControleItems controle = new ControleItems();
            //controle.ListaItens();
        }

        private void TelaAdicionarItem_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dblucianoDataSet2.ItensCriados'. Você pode movê-la ou removê-la conforme necessário.
            this.itensCriadosTableAdapter1.Fill(this.dblucianoDataSet2.ItensCriados);
            // TODO: esta linha de código carrega dados na tabela 'dblucianoDataSet1.ItensCriados'. Você pode movê-la ou removê-la conforme necessário.
            this.itensCriadosTableAdapter.Fill(this.dblucianoDataSet1.ItensCriados);
        }
    }
}
