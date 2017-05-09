using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DataModel
{
    public class ClsProduto
    {
        public int idProduto { get; set; }
        public string nomeProduto { get; set; }
        public string descProduto { get; set; }
        public double precProduto { get; set; }
        public double descontoPromocao { get; set; }
        public int idCategoria { get; set; }
        public bool ativoProduto { get; set; }
        public int idUsuario { get; set; }
        public int qtdMinEstoque { get; set; }
        public string imagem { get; set; }



        public DataTable ConsultaProduto(string nomeProduto)
        {

            ClsConexao ConectaBD = new ClsConexao();
            SqlConnection cn = ConectaBD.Conectar();

            DataTable consultaProduto = new DataTable();
            try
            {
                string sql = @"Select 
                               idProduto
                              ,nomeProduto
                              ,descProduto
                              ,precProduto
                              ,descontoPromocao
                              ,idCategoria
                              ,ativoProduto
                              ,idUsuario
                              ,qtdMinEstoque
                              

                        FROM PRODUTO WHERE nomeProduto LIKE '%' + @nomeProduto +'%' ";

                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = sql;

                cmd.Parameters.Add("@nomeProduto", SqlDbType.VarChar).Value = nomeProduto;

                SqlDataReader dr = cmd.ExecuteReader();



                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                da.Fill(consultaProduto);



            }
            catch
            {
                consultaProduto = null;
            }
            finally
            {
                cn.Close();
            }

            return consultaProduto;
        }

    }
}
