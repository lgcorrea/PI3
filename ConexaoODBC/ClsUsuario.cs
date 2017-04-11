using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{

    public class ClsUsuario
    {

        public int idUsuario { get; set; }
        public string loginUsuario { get; set; }
        public string senhaUsuario { get; set; }
        public string nomeUsuario { get; set; }
        public string tipoPerfil { get; set; }
        public bool usuarioAtivo { get; set; }

        public static ClsUsuario Logar(string _loginUsuario, string _senhaUsuario) {

            ClsUsuario u = null;

            string sql = (@"SELECT loginUsuario, nomeUsuario
                              FROM usuario
                              where loginUsuario = @_loginUsuario 
                              and senhaUsuario = @_senhaUsuario 
                              and usuarioAtivo = 1");
            SqlConnection cn = ClsConexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;

            SqlDataReader dr = cmd.ExecuteReader();
            u = new ClsUsuario();
            u.loginUsuario = dr.GetString(dr.GetOrdinal("loginUsuario"));
            u.nomeUsuario = dr.GetString(dr.GetOrdinal("nomeUsuario"));            

            return u;
        }




    }
}
