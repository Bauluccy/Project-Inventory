using DGVPrinterHelper;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
//using IronXL;

namespace Project_Inventory
{
    public partial class TelaInventarioTI : Form
    {

        #region Form
            public TelaInventarioTI()
        {
            InitializeComponent();
        }
            private void TelaInventarioTI_Activated(object sender, EventArgs e)
        {
            this.itensSeparadosPorIDTableAdapter.Fill(this.dblucianoDataSetInventarioTI.ItensSeparadosPorID);
        }
            private void Form1_Load(object sender, EventArgs e)
        {
            this.itensSeparadosPorIDTableAdapter.Fill(this.dblucianoDataSetInventarioTI.ItensSeparadosPorID);
        }
        #endregion


        #region Botoes Centrais
            private void btAddItem_Click(object sender, EventArgs e)
             {
                 TelaAdicionarItem telaAdicionarItem = new TelaAdicionarItem();
                 telaAdicionarItem.Show();
             }
            private void btCreateItem_Click(object sender, EventArgs e)
            {
                TelaCriarItem telaCriarItem = new TelaCriarItem();
                telaCriarItem.Show();
            }
            private void btDescarte_Click(object sender, EventArgs e)
            {
                TelaDescartes telaDescartes = new TelaDescartes();
                telaDescartes.Show();
            }
            
            //private void btLog_Click(object sender, EventArgs e)
            //{
            //    TelaLog telalog = new TelaLog();
            //    telalog.Show();
            //}

        #endregion

        #region Menu de Cima

            private void btConfiguracao_Click(object sender, EventArgs e)
            {
                TelaConfigurações telaconfig = new TelaConfigurações();
                telaconfig.Show();
            }
            
            private void btExportarNovoExcel_Click(object sender, EventArgs e)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Title = "Export";
            saveFileDialog.Filter = "Arquivo do Excel *.xlsx | *.xlsx";
            
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    GeraExcel(saveFileDialog.FileName);
                    MessageBox.Show("Arquivo exportado com sucesso!");
                }
            }
            
            private void btAlterarExcel_Click(object sender, EventArgs e)
            {
            string localarquivo;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivo do Excel *.xlsx | *.xlsx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                localarquivo = openFileDialog.FileName;
                EditarExcel(localarquivo);
            }

            }
            
            private void btImprimir_Click(object sender, EventArgs e)
            {
                this.printDocument1.DefaultPageSettings.Landscape = true;
                DGVPrinter printer = new DGVPrinter();
            
                printer.PrintPreviewDataGridView(dataGridView1);
            }
        #endregion

        #region DataGrid
            private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
                var x = dataGridView1.CurrentCellAddress.X;
                string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string item = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string quantidade = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            
            
                TelaAlterar telaAlterar = new TelaAlterar(item, quantidade, id);
                telaAlterar.Show();
            
            }
        #endregion
        
        #region Metodos
        public void GeraExcel(string localArquivo)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
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

            workbook.SaveAs(localArquivo, Excel.XlFileFormat.xlOpenXMLWorkbook, missValue, missValue, missValue, missValue,
            Excel.XlSaveAsAccessMode.xlExclusive, missValue, missValue, missValue, missValue, missValue);
            workbook.Close(true, missValue, missValue);
            app.Quit();
        }
            
        public void EditarExcel(string localarquivo)
        {
            //WorkBook workBook = WorkBook.Load(localarquivo);
            //WorkSheet cells = workBook.GetWorkSheet(localarquivo);

            //for(int x = 0; x < cells.Rows.Count(); x++)
            //{
                
            //    for(int y = 0; y < cells.Columns.Count(); y++)
            //    {
            //        if (x == 0 || y == 0)
            //        {
            //            continue;
            //        }

            //        //cells.Rows[x].Columns[y].Value = 
            //    }

            //}
        }

        #endregion

        
    }

}
