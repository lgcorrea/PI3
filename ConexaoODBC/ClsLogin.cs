using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoODBC
{
    class ClsLogin
    {

        SqlConnection cn = ClsConexao.Conectar();
        SqlCommand sql = new SqlCommand();

    }
}
