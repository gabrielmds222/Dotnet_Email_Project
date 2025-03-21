using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class VendaMap : ClassMap<Venda>
    {
        public VendaMap()
        {
            Map(v => v.Id).Name("Código Venda");
            Map(v => v.Data).Name("Data");
            Map(v => v.IdLoja).Name("ID Loja");
            Map(v => v.Produto).Name("Produto");
            Map(v => v.Quantidade).Name("Quantidade");
            Map(v => v.ValorUnitario).Name("Valor Unitário");
            Map(v => v.ValorFinal).Name("Valor Final");
        }
    }
}
