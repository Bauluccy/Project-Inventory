using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using R9.DataBase;


namespace Project_Inventory
{
    partial class ServiçoDeImportação : ServiceBase
    {
        public ServiçoDeImportação()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            //TimeSpan time = new TimeSpan

            DateTime dataDeHoje = DateTime.Now;
            string localLog = $"C:\\Users\\luciano.oliveira\\Inventario TI\\Desktop\\Automatic Log {dataDeHoje}";

            StreamWriter streamWriter = new StreamWriter(localLog, true);
            DateTime dataAtual = DateTime.Now;
            streamWriter.WriteLine($"Serviço iniciado: {dataAtual}");
            streamWriter.Flush();

            DateTime primeiroDiaDoMes = new DateTime(dataDeHoje.Year, dataDeHoje.Month, 1);

            string data = dataDeHoje.Date.ToString("dd-MM-yyyy");

            string arquivo = $"C:\\Users\\luciano.oliveira\\Desktop\\InventarioTI\\Inventario Automatico {data}.xlsx";

            if (DateTime.Now.Date.Equals(primeiroDiaDoMes))
            {
                if (File.Exists(arquivo))
                {

                }
                else
                {
                    try
                    {
                        TelaInventarioTI telaInventarioTI = new TelaInventarioTI();
                        telaInventarioTI.GeraExcel(arquivo);
                    }
                    catch
                    {

                    }
                }

            }
        }

        protected override void OnStop()
        {
            // TODO: Adicione aqui o código para realizar qualquer desmontagem necessária para interromper seu serviço.
        }

    }
}
