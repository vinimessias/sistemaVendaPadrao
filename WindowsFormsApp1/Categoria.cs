using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace WindowsFormsApp1
{
    public class Categoria
    {
        public Int32 Id { get; set; }
        public String Descricao { get; set; }

        public List<Categoria> ListaCategoria()
        {
            List<Categoria> listaCategoria = new List<Categoria>();
            // Criação do objeto de conexão do SQL Server
            SqlConnection sqlConnection = new SqlConnection();
            // Atribuiçã de valor da String de conexão
            sqlConnection.ConnectionString = "Data Source=DESKTOP-CIKRHCS\\SQLEXPRESS;Initial Catalog=VENDAPADRAO;Integrated Security=True";
            // Criação do comando sql (select id, descricao from Categoria)
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "select id, descricao from Categoria";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandTimeout = 3600;
            
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();

            foreach (DataRow item in dataTable.Rows)
            {
                Categoria categoria = new Categoria();
                categoria.Id = Int32.Parse(item["ID"].ToString());
                categoria.Descricao = item["descricao"].ToString();
                listaCategoria.Add(categoria);
            }

            return listaCategoria;
        }



    }
}
