using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoODBC
{
    class Conexao
    {
        static void Main(string[] args)
        {
        }
        // public static SqlConnection Conectar()
        /* {

             string stringDeConexao = @"driver={SQL Server}; server=.\SQLEXPRESS;
                                        uid=sa;
                                        pwd=sa;
                                         database=Kanino ";
             OdbcConnection Conexao = new OdbcConnection(stringDeConexao);

             Conexao.Open();
             return Conexao;
         }*/

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
