using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Inventory
{
    class Items
    {
        public int ID_item { get; set; }
        public String nomeItem { get; set; }
        public String descricaoItem { get; set; }
        public DateTime horaItem { get; set; }
        public DateTime dataItem { get; set; }
        public int quantidade { get; set; }
        public int entradaSaida { get; set; }


        //Construtor vazio
        public Items()
        {

        }

        //Construtor tabela
        public Items(string nomeItem, int quantidade)
        {
            this.nomeItem = nomeItem;
            this.quantidade = quantidade;
        }


        //Construtor LOG
        public Items(string nomeItem, string descricaoItem, DateTime horaItem, DateTime dataItem, int quantidade)
        {
            this.nomeItem = nomeItem;
            this.descricaoItem = descricaoItem;
            this.horaItem = horaItem;
            this.dataItem = dataItem;
            this.quantidade = quantidade;
        }
    }
}
