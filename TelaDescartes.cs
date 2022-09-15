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
    public partial class TelaDescartes : Form
    {
        public TelaDescartes()
        {
            InitializeComponent();
        }

        private void TelaDescartes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dblucianoDataSetDescarte.Descarte'. Você pode movê-la ou removê-la conforme necessário.
            this.descarteTableAdapter.Fill(this.dblucianoDataSetDescarte.Descarte);
        }

        private void TelaDescartes_Activated(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxFones.Checked)
            {
                if (checkBoxData.Checked)
                {
                    this.descarteTableAdapter.FillByFonesPorData(this.dblucianoDataSetDescarte.Descarte, dateTimePicker1.Value.Date, dateTimePicker2.Value.Date.Add(new TimeSpan(23, 59, 59)));
                }
                else
                {
                    this.descarteTableAdapter.FillByFonesSemData(this.dblucianoDataSetDescarte.Descarte);
                }
            }
            else
            {
                if (checkBoxData.Checked)
                {
                    this.descarteTableAdapter.FillBySemFonePorData(this.dblucianoDataSetDescarte.Descarte, dateTimePicker1.Value.Date, dateTimePicker2.Value.Date.Add(new TimeSpan(23, 59, 59)));
                }
                else
                {
                    this.descarteTableAdapter.Fill(this.dblucianoDataSetDescarte.Descarte);
                }
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxData.Checked)
            {
                label2.Visible = true;
                label3.Visible = true;
                dateTimePicker1.Visible = true;
                dateTimePicker2.Visible = true;
                label2.Enabled = true;
                label3.Enabled = true;
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;

                dateTimePicker1.Value = DateTime.Now ;
                dateTimePicker2.Value = DateTime.Now;

                if (checkboxFones.Checked)
                {
                    this.descarteTableAdapter.FillByFonesPorData(this.dblucianoDataSetDescarte.Descarte, dateTimePicker1.Value.Date, dateTimePicker2.Value.Date.Add(new TimeSpan(23, 59, 59)));
                }
                else
                {
                     this.descarteTableAdapter.FillBySemFonePorData(this.dblucianoDataSetDescarte.Descarte, dateTimePicker1.Value.Date, dateTimePicker2.Value.Date.Add(new TimeSpan(23, 59, 59)));
                }
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

                if (checkboxFones.Checked)
                {
                    this.descarteTableAdapter.FillByFonesSemData(this.dblucianoDataSetDescarte.Descarte);
                }
                else
                {
                    this.descarteTableAdapter.Fill(this.dblucianoDataSetDescarte.Descarte);
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (checkboxFones.Checked)
            {
                this.descarteTableAdapter.FillByFonesPorData(this.dblucianoDataSetDescarte.Descarte, dateTimePicker1.Value.Date, dateTimePicker2.Value.Date.Add(new TimeSpan(23,59,59)));
            }
            else
            {
                this.descarteTableAdapter.FillBySemFonePorData(this.dblucianoDataSetDescarte.Descarte, dateTimePicker1.Value.Date, dateTimePicker2.Value.Date.Add(new TimeSpan(23, 59, 59)));
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (checkboxFones.Checked)
            {
                this.descarteTableAdapter.FillByFonesPorData(this.dblucianoDataSetDescarte.Descarte, dateTimePicker1.Value.Date, dateTimePicker2.Value.Date.Add(new TimeSpan(23, 59, 59)));
            }
            else
            {
                this.descarteTableAdapter.FillBySemFonePorData(this.dblucianoDataSetDescarte.Descarte, dateTimePicker1.Value.Date, dateTimePicker2.Value.Date.Add(new TimeSpan(23, 59, 59)));
            }
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
            saveFileDialog.Title = "";
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
    }
}
