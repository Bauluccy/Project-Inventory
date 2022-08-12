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
using Excel = Microsoft.Office.Interop.Excel;


namespace Project_Inventory
{
    public partial class TelaLog : Form
    {

        DataTable dt = new DataTable();
        public TelaLog()
        {
            InitializeComponent();
        }

        private void TelaLog_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dblucianoDataSet.ItensCriados'. Você pode movê-la ou removê-la conforme necessário.
            this.itensCriadosTableAdapter.Fill(this.dblucianoDataSet.ItensCriados);
            // TODO: esta linha de código carrega dados na tabela 'dblucianoDataSet1.Log_Inventario_TI'. Você pode movê-la ou removê-la conforme necessário.
            this.log_Inventario_TITableAdapter.Fill(this.dblucianoDataSet1.Log_Inventario_TI);
            //dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.log_Inventario_TITableAdapter.FillByTipo(this.dblucianoDataSet1.Log_Inventario_TI, (int) comboTipo.SelectedValue);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label2.Visible = true;
                label3.Visible = true;
                dateTimePicker1.Visible = true;
                dateTimePicker2.Visible = true;
                label2.Enabled = true;
                label3.Enabled = true;
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;

                dateTimePicker1.Value = DateTime.Now;
                dateTimePicker2.Value = DateTime.Now;
            }
            else
            {
                label2.Visible = false;
                label3.Visible = false;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
                label2.Enabled = false;
                label3.Enabled = false;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
                SaveFileDialog saveFileDialog =  new SaveFileDialog();

                Excel.Application app;
                Excel.Workbook workbook;
                Excel.Worksheet worksheet;
                object missValue = System.Reflection.Missing.Value;

                app =  new Excel.Application();
                workbook = app.Workbooks.Add(missValue);
                worksheet = (Excel.Worksheet)workbook.Worksheets.get_Item(1);
                int i = 0;
                int j = 0;


                for (int c = 1; c < dataGridView1.Columns.Count + 1; c++)
                {
                    worksheet.Cells[1, c] = dataGridView1.Columns[c - 1].HeaderText;
                }


                for (i = 0; i<= dataGridView1.RowCount - 1; i++)
                {
                    for(j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                    {
                        DataGridViewCell cell = dataGridView1[j, i];
                        worksheet.Cells[i+2,j+1] = cell.Value;
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
    }
}
