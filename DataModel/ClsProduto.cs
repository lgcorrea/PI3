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



        public DataTable ConsultaProduto(//string nomeProduto
            )
        {

            ClsConexao ConectaBD = new ClsConexao();
            SqlConnection cn = ConectaBD.Conectar();
            DataTable consultaProduto = new DataTable();

            /*SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = @"Select top 1
                               idProduto
                              ,nomeProduto
                              ,precProduto
                              ,descontoPromocao                    

                        FROM PRODUTO";

            SqlDataReader dr = cmd.ExecuteReader();

            List<ClsProduto> listaProduto = new List<ClsProduto>();

            while (dr.Read())
            {
                ClsProduto produto = new ClsProduto();

                produto.idProduto = Convert.ToInt32(dr.GetOrdinal("idProduto"));
                produto.nomeProduto = dr.GetOrdinal("nomeProduto").ToString();
                produto.precProduto = Convert.ToDouble(dr.GetOrdinal("precProduto"));
                produto.descontoPromocao = Convert.ToDouble(dr.GetOrdinal("descontoPromocao"));

                listaProduto.Add(produto);
            }
            */



            try
            {
                 string sql = @"Select 
                               idProduto
                              ,nomeProduto
                              ,precProduto
                              ,descontoPromocao                    

                        FROM PRODUTO";
                         //WHERE nomeProduto LIKE '%' + @nomeProduto +'%' ";

                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = sql;


                //cmd.Parameters.Add("@nomeProduto", SqlDbType.VarChar).Value = nomeProduto;

                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                da.Fill(consultaProduto);
                

            
            }
            catch
            {
                Console.WriteLine("erro");
                //consultaProduto = null;
            }
            finally
            {
                cn.Close();
            }
            return consultaProduto;
            //return consultaProduto;
        }

    }
}
