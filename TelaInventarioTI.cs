using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Project_Inventory
{
    public partial class TelaInventarioTI : Form
    {
        public TelaInventarioTI()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaAdicionarItem telaAdicionarItem = new TelaAdicionarItem();
            telaAdicionarItem.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TelaCriarItem telaCriarItem = new TelaCriarItem();
            telaCriarItem.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dblucianoDataSetInventarioTI.ItensSeparadosPorID'. Você pode movê-la ou removê-la conforme necessário.
            this.itensSeparadosPorIDTableAdapter.Fill(this.dblucianoDataSetInventarioTI.ItensSeparadosPorID);
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaLog telalog = new TelaLog();
            telalog.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            Excel.Application app;
            Excel.Workbook workbook;
            Excel.Worksheet worksheet;
            object missValue = System.Reflection.Missing.Value;

            app = new Excel.Application();
            workbook = app.Workbooks.Add(missValue);
            worksheet = (Excel.Worksheet)workbook.Worksheets.get_Item(1);
            int i = 0;
            int j = 0;


            for (int c = 1; c < dataGridView1.Columns.Count + 1; c++)
            {
                worksheet.Cells[1, c] = dataGridView1.Columns[c - 1].HeaderText;
            }


            for (i = 0; i <= dataGridView1.RowCount - 1; i++)
            {
                for (j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dataGridView1[j, i];
                    worksheet.Cells[i + 2, j + 1] = cell.Value;
                }
            }
            saveFileDialog.Title = "ExportLogFilter";
            saveFileDialog.Filter = "Arquivo do Excel *.xlsx | *.xlsx";
            saveFileDialog.ShowDialog();

            workbook.SaveAs(saveFileDialog.FileName, Excel.XlFileFormat.xlOpenXMLWorkbook, missValue, missValue, missValue, missValue,
            Excel.XlSaveAsAccessMode.xlExclusive, missValue, missValue, missValue, missValue, missValue);
            workbook.Close(true, missValue, missValue);
            app.Quit();

            MessageBox.Show("Success");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.printDocument1.DefaultPageSettings.Landscape = true;
            DGVPrinter printer = new DGVPrinter();

            printer.PrintPreviewDataGridView(dataGridView1);
        }

        private void TelaInventarioTI_Activated(object sender, EventArgs e)
        {
            this.itensSeparadosPorIDTableAdapter.Fill(this.dblucianoDataSetInventarioTI.ItensSeparadosPorID);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var x = dataGridView1.CurrentCellAddress.X;
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string item = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string quantidade = dataGridView1.CurrentRow.Cells[2].Value.ToString();


            TelaAlterar telaAlterar = new TelaAlterar(item,quantidade,id);
            telaAlterar.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TelaDescartes telaDescartes = new TelaDescartes();
            telaDescartes.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            TelaConfigurações telaconfig = new TelaConfigurações();
            telaconfig.Show();
        }
    }
    
}
