//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.SqlClient;
//using System.Data;

//namespace DAL
//{
//    public class Accesos
//    {
//        public SqlConnection cn = new SqlConnection();

//        public string conexion()
//        {

//            var cs = new SqlConnectionStringBuilder();



//            if (Environment.MachineName == "DESKTOP-HS26TFQ")
//            {

//                cs.ConnectionString = @"Data Source = DESKTOP-HS26TFQ\SQLEXPRESS; Initial Catalog =Odontologia; Integrated Security = True";


//            }
//            else
//            {
//                cs.ConnectionString = @"Data Source =.; Initial Catalog =Odontologia; Integrated Security = True";

//            }

//            return cs.ConnectionString;



//        }

//        public void Conectar()
//        {
//            cn.ConnectionString = conexion();
//            cn.Open();
//        }

//         public void Desconectar()
//        {
//            cn.Close();
//        }


//        public DataTable Leer(string procedimiento, SqlParameter[]parametros)
//        {

//            SqlConnection sql = new SqlConnection();
//            sql.ConnectionString = conexion(); // instancia de clase SQlConnection y le paso la cadena de conexion          
//            sql.Open();
//            DataTable tabla = new DataTable(); //crea nueva tabla
//            SqlDataAdapter adaptador = new SqlDataAdapter();
//            adaptador.SelectCommand = new SqlCommand();
//            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
//            adaptador.SelectCommand.CommandText = procedimiento;
//            if (parametros != null)
//            {
//                adaptador.SelectCommand.Parameters.AddRange(parametros);
//            }
//            adaptador.SelectCommand.Connection = sql;
//            adaptador.Fill(tabla);
//            sql.Close();

//            return tabla;

//        }

//        public string Escribir(string NombreProcedimiento, SqlParameter[] parametros)
//        {
//            string mensaje;
//            SqlConnection sql = new SqlConnection();
//            sql.ConnectionString = conexion();
//            sql.Open();
//            SqlCommand cmd = new SqlCommand();
//            cmd.CommandType = CommandType.StoredProcedure;
//            cmd.CommandText = NombreProcedimiento;
//            cmd.Connection = sql;
//            cmd.Parameters.AddRange(parametros);
//            try
//            {

//                cmd.ExecuteNonQuery();
//                mensaje = "Operación Realizada con Exito";
//            }

//            catch (Exception Ex)
//            {
//                mensaje = Ex.Message;
//            }
//            sql.Close();
//            return mensaje;
//        }




//    }





//}

using System;
using System.Data.SqlClient;

namespace DAL
{
    public class Accesos
    {
        private static Accesos _instancia;
        private static readonly object _lock = new object();
        private readonly string _connectionString;

        private Accesos()
        {
            var cs = new SqlConnectionStringBuilder();

            if (Environment.MachineName == "DESKTOP-HS26TFQ")
            {
                cs.ConnectionString = @"Data Source=DESKTOP-HS26TFQ\SQLEXPRESS;Initial Catalog=Odontologia;Integrated Security=True";
            }
            else
            {
                cs.ConnectionString = @"Data Source=.;Initial Catalog=Odontologia;Integrated Security=True";
            }

            _connectionString = cs.ConnectionString;
        }

        public static Accesos Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    lock (_lock)
                    {
                        if (_instancia == null)
                        {
                            _instancia = new Accesos();
                        }
                    }
                }
                return _instancia;
            }
        }

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
