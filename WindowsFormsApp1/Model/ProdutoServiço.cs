using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   public class ProdutoServiço
    {
        public Int32 Id { get; set; }
        public String Descricao { get; set; }
        public Categoria Categoria { get; set; }
        public TipoProdutoServico TipoProdutoServico { get; set; }
        public Decimal Peso { get; set; }
        public DateTime Validade { get; set; }
        public Decimal TMO { get; set; }


    }
}
