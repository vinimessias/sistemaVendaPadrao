using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class TipoCliente
    {
        public int Id { get; set; }
        public String Descricao { get; set; }

        public void inserir(TipoCliente tipoCliente)
        { 
        
        }
        public void alterar(TipoCliente tipoCliente)
        {

        }
        public void deletar(TipoCliente tipoCliente)
        {

        }

        public TipoCliente consultar(String pesquisa)
        {
            TipoCliente tipoCliente = new TipoCliente();

            return tipoCliente;
        }
    }
}
