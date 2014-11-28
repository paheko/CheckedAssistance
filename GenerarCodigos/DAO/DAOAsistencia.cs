using GenerarCodigos.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerarCodigos.DAO
{
    public class DAOAsistencia
    {
        public void InsertAsistencia(DTOAsistencia cliente)
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=C:\DB\Pascuita.sdf");
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO asistencia ([id],[codigo_alumno]) Values('"+cliente.id+"','" + cliente.codigo_alumno + "')";

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        public List<DTOAsistencia> GetAsistencia()
        {
            List<DTOAsistencia> cliente = new List<DTOAsistencia>();
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=C:\DB\Pascuita.sdf");
            conn.Open();

            //commands represent a query or a stored procedure
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM asistencia;";
            SqlCeDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cliente.Add(new DTOAsistencia(
                    reader["id"].ToString(),
                    reader["codigo_alumno"].ToString()
                   ));
            }
            return cliente;
        }
    }
}
