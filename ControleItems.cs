using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R9.DataBase;

namespace Project_Inventory
{
    public static class ControleItems
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

        public static void AdicionarItem(string item, int quantidade, string descricao, int idItem)
        {
            DataContext contexto = new DataContext("Data Source=192.168.0.176;Initial Catalog=dbluciano;User ID=siscob;Password=123456;");

            var adicionarItem = new ItemInventário()
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

        public static void RemoverItem(string item, int quantidade, string descricao, int idItem)
        {
            DataContext contexto = new DataContext("Data Source=192.168.0.176;Initial Catalog=dbluciano;User ID=siscob;Password=123456;");

            var removerItem = new ItemInventário()
            {
                Context = contexto,
                ITEM = item,
                DESCRICAO = descricao,
                QUANTIDADE = quantidade,
                ENTRASAI = 0,
                DATA = DateTime.Now,
                ID_ITEM = idItem
            };

            removerItem.Save();
        }




        [Table("Log_Inventario_TI")]
        public class ItemInventário : BaseModel
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
        
        
        
        
        
        //public string FiltrarItem()
        //{
        //    DataContext contexto = new DataContext("Data Source=192.168.0.176;Initial Catalog=dbluciano;User ID=siscob;Password=123456;");

        //    var filtros = Data.LoadAll<ChamaItensCriados>(contexto, "(ID = comboTipo.SelectedValue)");
        //    return filtros.ToString();
        //}
        public static void CriarItem(string valor)
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


        public static List<ItemInventário> BuscarTudo()
        {
            DataContext contexto = new DataContext("Data Source=192.168.0.176;Initial Catalog=dbluciano;User ID=siscob;Password=123456;");

            return Data.LoadAll<ItemInventário>(contexto);
        }

        public static List<ItemInventário> BuscarPorTipo(int IdTipo)
        {
            DataContext contexto = new DataContext("Data Source=192.168.0.176;Initial Catalog=dbluciano;User ID=siscob;Password=123456;");

            return Data.LoadAll<ItemInventário>(contexto, "ID_ITEM = " + IdTipo);
        }

    } 
    
}
