using GenerarCodigos.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerarCodigos.DAO
{
    public class DAOCatecismo
    {
        public void InsertCatecismo(DTOCatecismo cliente)
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=C:\DB\Pascuita.sdf");
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO catecismo ([catecismo]) Values('" + cliente.catecismo +"')";

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
        public List<DTOCatecismo> GetCatecismo()
        {
            List<DTOCatecismo> cliente = new List<DTOCatecismo>();
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=C:\DB\Pascuita.sdf");
            conn.Open();

            //commands represent a query or a stored procedure
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM catecismo;";
            SqlCeDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cliente.Add(new DTOCatecismo(
                    int.Parse(reader["id_catecismo"].ToString()),
                    reader["catecismo"].ToString()                   
                   ));
            }
            return cliente;
        }
        public void DeleteCatecismo(int id)
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=C:\DB\Pascuita.sdf");
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM catecismo WHERE id_catecismo=" + id;

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
