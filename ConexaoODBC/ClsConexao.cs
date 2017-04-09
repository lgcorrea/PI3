using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoODBC
{
    class ClsConexao
    {
        public static SqlConnection Conectar()
        {
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
            sb.UserID = "sa";
            sb.Password = "123";
            sb.DataSource = @"USER-PC\SQLEXPRESS";
            sb.InitialCatalog = "Kanino";

            SqlConnection cn = new SqlConnection(sb.ConnectionString);
            cn.Open();


            return cn;
        }

    }
}
