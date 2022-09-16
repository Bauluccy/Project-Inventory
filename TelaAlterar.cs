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
    public partial class TelaAlterar : Form
    {
        public TelaAlterar()
        {
            InitializeComponent();
        }

        public TelaAlterar(string item,string quantidade, string id)
        {
            InitializeComponent();

            //int quantidade = ;
            textBox1.Text = item;
            textBox2.Text = id;
            carregaCombo(int.Parse(quantidade));
            comboQNT.SelectedIndex = 0;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            int resultadoFinal;
            int resultadoAntigo = 0;
            

            for (int i = 0; i < comboQNT.Items.Count; i++)
            {
                resultadoAntigo = i;
            }
            
            if (comboQNT.Text.Equals(""))
            {
                comboQNT.Text = "0";
            }

            int resultadoNovo = Int32.Parse(comboQNT.Text);

            if (resultadoNovo == resultadoAntigo)
            {
                MessageBox.Show("Nada alterado, Tudo certo por aqui!!!");
                Dispose();
            }
            else if(resultadoNovo > resultadoAntigo){
                MessageBox.Show("Por favor, insira um valor válido. Você não pode tirar algo que ja não existe!" +
                    "\nPara adicionar itens USE a opção de ADICIONAR ITEM!!!");
            }
            else
            {
                resultadoFinal = resultadoAntigo - resultadoNovo;

                if (txDesc.Text.Equals(""))
                {
                    MessageBox.Show("Específique por que o item está saindo!!!");
                }
                else
                {
                    string item = textBox1.Text;
                    int quantidade;
                    quantidade = -resultadoFinal;
                    string descricao = txDesc.Text;
                    int idItem = Int32.Parse(textBox2.Text);

                    ControleItems.RemoverItem(item, quantidade, descricao, idItem);

                    MessageBox.Show("Quantidade Atualizada!!!" +
                        "\nVerifique o grid inicial!");

                    Dispose();
                }

            }
        }


        private void TelaAlterar_Load(object sender, EventArgs e)
        {
            int numero = Int32.Parse(comboQNT.Text);

            TransformaNumero(numero);
        }

        public void carregaCombo(int valor)
        {
            for (int i = valor; i >= 0; i--)
            {
                comboQNT.Items.Add(i);
            }
        }

        public static int TransformaNumero(int numero)
        {
            return numero;
        }
    }

    
}
