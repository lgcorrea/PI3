using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
   public class ClsEstoque


    { 
        public int idProduto { get; set; }
        public int qtdMinima { get; set; }
        public int qtdDisponivel { get; set; }
        public string nomeProduto { get; set; }


        public ClsEstoque RetornaItemEstoque (int idProduto)
        {

            ClsConexao ConectaBD = new ClsConexao();
            SqlConnection cn = ConectaBD.Conectar();
            ClsEstoque item = null;

           // try
            //{
                    string sql = @"Select 
                                   A.idProduto
                                  ,nomeProduto                             
                                  ,qtdProdutoDisponivel                              
							      ,qtdMinEstoque

                            FROM PRODUTO A
                            INNER JOIN ESTOQUE C ON C.IDPRODUTO = A.IDPRODUTO
                        WHERE A.idProduto = @idProduto";

                
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = sql;

                cmd.Parameters.Add("@idProduto", SqlDbType.Int).Value = idProduto;

                SqlDataReader dr = cmd.ExecuteReader();
                item = new ClsEstoque();

                dr.Read();
                item.idProduto = dr.GetInt32(dr.GetOrdinal("idProduto"));
                item.nomeProduto = dr.GetString(dr.GetOrdinal("nomeProduto"));
                item.qtdDisponivel = dr.GetInt32(dr.GetOrdinal("qtdProdutoDisponivel"));
                item.qtdMinima = dr.GetInt32(dr.GetOrdinal("qtdMinEstoque"));
/*

            }
            catch
            {
                item = null;
            }
            finally
            {
                cn.Close();
            }*/

            return item;
        }
    }
}
