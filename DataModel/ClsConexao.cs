using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    class ClsConexao
    {
        public SqlConnection Conectar()
        {
            /*SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
            sb.UserID = "TSI";
            sb.Password = "SistemasInternet123";
            sb.DataSource = @"delta-pi.database.windows.net";
            sb.InitialCatalog = "Delta";*/

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
