using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalletWise
{
    public class Transacao
    {
        public int ID { get; set; }
        public decimal Valor {  get; set; } 
        public string Descricao { get; set; }
        public string tipo_compra {  get; set; }
        public string receita_despesa {  get; set; }
        public DateTime Data { get; set; }

    }
}
