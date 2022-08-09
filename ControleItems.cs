using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R9.DataBase;

namespace Project_Inventory
{
    class ControleItems
    {
        //public void ReceberItens(List lista)
        //{
        //    DataContext contexto = new DataContext("Data Source=192.168.0.176;Initial Catalog=dbluciano;User ID=siscob;Password=123456;");

        //    lista = Data.LoadAll<ChamaInventario>(contexto);

        //    //List<Items> items = new List<Items>();
        //    //items.Add(new Items()
        //    //{
        //    //    //nomeItem = ,
        //    //    //descricaoItem = "",
        //    //    //quantidade = 1,
        //    //    //entradaSaida = ,
        //    //    ////dataItem = new DateTime(2022,07,29)
        //    //});
        //}

        public void AdicionarItem(string item, int quantidade, string descricao, int idItem)
        {
            DataContext contexto = new DataContext("Data Source=192.168.0.176;Initial Catalog=dbluciano;User ID=siscob;Password=123456;");

            var adicionarItem = new ChamaInventario()
            {
                Context = contexto,
                ITEM = item,
                DESCRICAO = descricao,
                QUANTIDADE = quantidade,
                ENTRASAI = 1,
                DATA = DateTime.Now,
                ID_ITEM = idItem
            };

            adicionarItem.Save();
        }




        [Table("Log_Inventario_TI")]
        public class ChamaInventario : BaseModel
        {
            [ID]
            public int ID { get; set; }
            [Column]
            public string ITEM { get; set; }
            [Column]
            public string DESCRICAO { get; set; }
            [Column]
            public int QUANTIDADE { get; set; }
            [Column]
            public int ENTRASAI { get; set; }
            [Column]
            public DateTime DATA { get; set; }
            [Column]
            public int ID_ITEM { get; set; }
        }
        
        
        
        
        
        
        public void CriarItem(string valor)
        {
            DataContext contexto = new DataContext("Data Source=192.168.0.176;Initial Catalog=dbluciano;User ID=siscob;Password=123456;");

            var criarItem = new ChamaItensCriados()
            {
                Context = contexto,
                NOME_ITEM = valor
            };

            criarItem.Save();
        }

        [Table("ItensCriados")]
        public class ChamaItensCriados : BaseModel
        {
            [ID]
            public int ID { get; set; }
            [Column]
            public string NOME_ITEM { get; set; }
        }
    } 
    
}
