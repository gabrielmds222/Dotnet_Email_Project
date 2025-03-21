using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class Venda
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string IdLoja { get; set; }
        public string Produto { get; set; }
        public string Quantidade { get; set; }
        public string ValorUnitario {  get; set; }
        public string ValorFinal { get; set; }

    }
}
