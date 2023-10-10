using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_C_.Models
{
    internal class CervezaBD
    {
        
        private string connectionString = "Data Source=localhost;Initial Catalog=FundamentosCSharp;Integrated Security=True;";

        public List<Cerveza> Get()
        {
            List<Cerveza> cervezas = new List<Cerveza>();
            string query = "select nombre, marca, alcohol, cantidad from cerveza";
            using (SqlConnection connection = new(connectionString))
            {
                SqlCommand command = new(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int Cantidad = reader.GetInt32(3);
                    string Nombre = reader.GetString(0);
                    Cerveza cerveza = new Cerveza(Cantidad, Nombre);
                    cerveza.Alcohol = reader.GetInt32(2);
                    cerveza.Marca = reader.GetString(1);
                    cervezas.Add(cerveza);
                }
                reader.Close();
                connection.Close();

            }
                return cervezas;
        }
    }
}
