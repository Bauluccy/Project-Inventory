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
    public partial class TelaLog : Form
    {
        public TelaLog()
        {
            InitializeComponent();
        }

        private void TelaLog_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dblucianoDataSet1.Log_Inventario_TI'. Você pode movê-la ou removê-la conforme necessário.
            this.log_Inventario_TITableAdapter.Fill(this.dblucianoDataSet1.Log_Inventario_TI);

        }
    }
}
