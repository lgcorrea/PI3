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
        public byte[] imagem { get; set; }


        //BUSCA PRODUTO A PARTIR DE UMA STRING
        public DataTable ConsultaProduto(string nomeProduto)
        {

            ClsConexao ConectaBD = new ClsConexao();
            SqlConnection cn = ConectaBD.Conectar();
            DataTable consultaProduto = new DataTable();

            try
            {
                 string sql = @"Select 
                               A.idProduto
                              ,nomeProduto
                              ,descProduto
                              ,precProduto
                              ,qtdProdutoDisponivel
                              ,descontoPromocao
							  ,qtdMinEstoque
							  ,nomeCategoria
                              ,ativoProduto = CONVERT(BIT,CASE WHEN ativoProduto NOT IN (0,1) THEN 0 ELSE ativoProduto END)                 

                        FROM PRODUTO A
                        INNER JOIN CATEGORIA B ON A.IDCATEGORIA = B.IDCATEGORIA 
                        INNER JOIN ESTOQUE C ON C.IDPRODUTO = A.IDPRODUTO
                        WHERE nomeProduto LIKE @nomeProduto";

                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@nomeProduto", "%" + nomeProduto + "%");

                SqlDataAdapter dB = new SqlDataAdapter();
                dB.SelectCommand = cmd;

                dB.Fill(consultaProduto);
                              
            
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

        public DataTable ListaProduto()
        {

            ClsConexao ConectaBD = new ClsConexao();
            SqlConnection cn = ConectaBD.Conectar();
            DataTable consultaProduto = new DataTable();

            try
            {
                string sql = @"Select 
                               A.idProduto
                              ,nomeProduto
                              ,descProduto
                              ,precProduto
                              ,qtdProdutoDisponivel
                              ,descontoPromocao
							  ,qtdMinEstoque
							  ,nomeCategoria                
                              ,ativoProduto = CASE WHEN ativoProduto NOT IN (0,1) THEN 0 ELSE ativoProduto END 
                              ,imagem
                        FROM PRODUTO A
                        INNER JOIN CATEGORIA B ON A.IDCATEGORIA = B.IDCATEGORIA 
                        INNER JOIN ESTOQUE C ON C.IDPRODUTO = A.IDPRODUTO";
                        
                SqlCommand cmd = new SqlCommand(sql, cn);

                SqlDataAdapter dB = new SqlDataAdapter();
                dB.SelectCommand = cmd;

                dB.Fill(consultaProduto);

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
