using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R9.DataBase;

namespace Project_Inventory
{
    class ControleItems
    {

        public List<Items> ReceberItems()
        {

            List<Items> items = new List<Items>();
            items.Add(new Items()
            {
                //nomeItem = ,
                //descricaoItem = "",
                //quantidade = 1,
                //entradaSaida = ,
                ////dataItem = new DateTime(2022,07,29)
            });

            


            return items; 
        }

        


        public void Connect()
        {
            DataContext contexto = new DataContext("Data Source=192.168.0.176;Initial Catalog=dbluciano;User ID=siscob;Password=123456;");

            var dadosInventario = Data.LoadAll<ChamaInventario>(contexto);
        }

        public void AdicionarItem(string item, int quantidade, string descricao)
        {
            DataContext contexto = new DataContext("Data Source=192.168.0.176;Initial Catalog=dbluciano;User ID=siscob;Password=123456;");

            var adicionarItem = new ChamaInventario()
            {
                Context = contexto,
                ITEM = item,
                DESCRICAO = descricao,
                QUANTIDADE = quantidade,
                ENTRASAI = 1,
                DATA = DateTime.Now
            };

            adicionarItem.Save();
        }




        [Table("Inventario_TI")]
        public class ChamaInventario : BaseModel
        {
            [ID]
            public int ID_ITEM { get; set; }
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
