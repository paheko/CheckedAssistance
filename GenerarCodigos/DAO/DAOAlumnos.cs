using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerarCodigos.DAO
{
    public class DAOAlumnos
    {
        public List<DTOAlumnos> GetAlumnos()
        {
            List<DTOAlumnos> cliente = new List<DTOAlumnos>();
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=C:\DB\Pascuita.sdf");
            conn.Open();

            //commands represent a query or a stored procedure
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Alumnos;";
            SqlCeDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cliente.Add(new DTOAlumnos(
                    reader["Codigo"].ToString(),
                    reader["Nombre"].ToString(),
                   reader["Grado"].ToString(),
                   reader["Catecismo"].ToString()                   
                   ));
            }
            return cliente;
        }
        public DTOAlumnos GetAlumno(string id)
        {
            DTOAlumnos cliente = null;
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=C:\DB\Pascuita.sdf");
            conn.Open();

            //commands represent a query or a stored procedure
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Alumnos WHERE Codigo='" + id + "';";
            SqlCeDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cliente = new DTOAlumnos(
                    reader["Codigo"].ToString(),
                    reader["Nombre"].ToString(),
                   reader["Grado"].ToString(),
                   reader["Catecismo"].ToString()
                   );
            }
            conn.Close();
            return cliente;
        }
        public void InsertAlumno(DTOAlumnos cliente)
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=C:\DB\Pascuita.sdf");
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Alumnos ([Codigo],[Nombre],[Grado],[Catecismo]) Values('"+cliente.codigo+"','" + cliente.Nombre + "','" + cliente.grado + "','" + cliente.catecismo + "')";

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        public void ModifyAlumno(DTOAlumnos cliente)
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\Pascuita.sdf");
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE Alumnos SET Nombre='" + cliente.Nombre + "',Grado='" + cliente.grado + "',Catecismo='" + cliente.catecismo + "' WHERE Codigo=" + cliente.codigo;

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
        public void DeleteAlumno(string id)
        {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\DB\Pascuita.sdf");
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Alumnos WHERE Codigo=" + id;

                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
