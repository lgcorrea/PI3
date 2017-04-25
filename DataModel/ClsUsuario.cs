using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public ClsUsuario Logar(string _loginUsuario, string _senhaUsuario) {

            ClsConexao ConectaBD = new ClsConexao();

            ClsUsuario u = null;
            try
            {
                string sql = (@"SELECT loginUsuario, nomeUsuario, tipoPerfil
                                  FROM usuario
                              where loginUsuario = @_loginUsuario 
                              and senhaUsuario = @_senhaUsuario 
                              and usuarioAtivo = 1");
                SqlConnection cn = ConectaBD.Conectar();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = sql;


                cmd.Parameters.Add("@_loginUsuario", SqlDbType.VarChar).Value = _loginUsuario;
                cmd.Parameters.Add("@_senhaUsuario", SqlDbType.VarChar).Value = _senhaUsuario;

                SqlDataReader dr = cmd.ExecuteReader();
                u = new ClsUsuario();

                dr.Read();
                u.loginUsuario = dr.GetString(dr.GetOrdinal("loginUsuario"));
                u.nomeUsuario = dr.GetString(dr.GetOrdinal("nomeUsuario"));
                u.tipoPerfil = dr.GetString(dr.GetOrdinal("tipoPerfil"));


            }
            catch (InvalidOperationException e)

            {
                //Console.WriteLine("Usuário ou senha incorreto");
                u = null;
            }

              return u;           

        }

        public void Salvar() {


        }

        public static BindingSource NavegaUsuarios() {

            ClsConexao ConectaBD = new ClsConexao();
            BindingSource navega = null;

            //try {
                string sql = @"SELECT ROW_NUMBER() over(order by idusuario) id,
		                       loginUsuario,
	                           nomeUsuario,    
		                       CASE WHEN tipoPerfil= 'A' THEN 'Administrador' ELSE 'Estoquista' END as tipoPerfil
                               FROM usuario";
                SqlConnection cn = ConectaBD.Conectar();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = sql;
                navega = new BindingSource();

                DataTable dados = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                da.Fill(dados);
                navega.DataSource = dados;

                
            //}

            //catch
            //{

            //    navega = null;

            //}

            return navega;




        }
        }
       




    }