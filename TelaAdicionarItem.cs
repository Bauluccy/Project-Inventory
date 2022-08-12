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


        private void TelaAdicionarItem_Load(object sender, EventArgs e)
        {
            //comboItem.Items.Insert(0, "Selecione...");
            // TODO: esta linha de código carrega dados na tabela 'dblucianoDataSet.ItensCriados'. Você pode movê-la ou removê-la conforme necessário.
            this.itensCriadosTableAdapter.Fill(this.dblucianoDataSet.ItensCriados);
            if(comboItem.Text.Equals("Teste"))
            {
                comboItem.Text = "Selecione...";
            }

            comboQuantidade.Text = ("0");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string item = comboItem.Text;
            int quantidade = Int32.Parse(comboQuantidade.Text);
            string descricao = richTextBox1.Text;

            if (item.Equals("Selecione...") && comboItem.SelectedValue == null || item.Equals("Selecione..."))
            {
                System.Windows.Forms.MessageBox.Show("Selecione um item antes de adicionar...");
            }
            else if (quantidade == 0)
            {
                System.Windows.Forms.MessageBox.Show("Selecione ao menos uma quantidade antes de adicionar...");
            }
            else
            {
                int idItem = (int)comboItem.SelectedValue;
                ControleItems.AdicionarItem(item, quantidade, descricao, idItem);
                Dispose();
            }


        }
    }
}
