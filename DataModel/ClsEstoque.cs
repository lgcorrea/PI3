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
    public class ClsEstoque


    {
        public int idProduto { get; set; }
        public int qtdMinima { get; set; }
        public int qtdDisponivel { get; set; }
        public string nomeProduto { get; set; }
        public int qtd { get; set; }
        public bool AtualizaProdutos { get; set; }


        public ClsEstoque RetornaItemEstoque(int idProduto)
        {

            ClsConexao ConectaBD = new ClsConexao();
            SqlConnection cn = ConectaBD.Conectar();
            ClsEstoque item = null;

            try
            {
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


            }
            catch
            {
                item = null;
            }
            finally
            {
                cn.Close();
            }

            return item;
        }

        public void atualizaEstoqueEntrada()
        {

            ClsConexao ConectaBD = new ClsConexao();
            SqlConnection cn = ConectaBD.Conectar();
            string sql = "";
            SqlCommand cmd = new SqlCommand(sql, cn);

            try
            {

                sql = @"UPDATE ESTOQUE
                               SET qtdProdutoDisponivel = qtdProdutoDisponivel+ @qtd
                               WHERE idProduto = @idProduto";

                cmd.Parameters.Add("@qtd", SqlDbType.Int).Value = this.qtd;
                cmd.Parameters.Add("@idProduto", SqlDbType.Int).Value = this.idProduto;

                cmd.CommandText = sql;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Estoque Atualizado");
            }

            catch (SqlException ex)
            {

                MessageBox.Show("Tente novamente mais tarde.");

            }

            finally
            {
                cn.Close();
            }
        }

        public void atualizaEstoqueSaida()
        {

            ClsConexao ConectaBD = new ClsConexao();
            SqlConnection cn = ConectaBD.Conectar();
            string sql = "";
            SqlCommand cmd = new SqlCommand(sql, cn);

            sql = @"SELECT 1 FROM ESTOQUE A 
                    INNER JOIN PRODUTO B ON A.IDPRODUTO = B.IDPRODUTO
                    WHERE A.idProduto = @idProduto
                    AND qtdMinEstoque < (qtdProdutoDisponivel- @qtd)";

            cmd.Parameters.Add("@qtd", SqlDbType.Int).Value = this.qtd;
            cmd.Parameters.Add("@idProduto", SqlDbType.Int).Value = this.idProduto;

            cmd.CommandText = sql;
            Boolean qtdMinimaOK = Convert.ToBoolean(cmd.ExecuteScalar());

            if (qtdMinimaOK)
            {
                try
                {

                    sql = @"UPDATE ESTOQUE
                               SET qtdProdutoDisponivel = qtdProdutoDisponivel- @qtd
                               WHERE idProduto = @idProduto";

                    cmd.CommandText = sql;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Estoque Atualizado");
                }

                catch (SqlException ex)
                {

                    MessageBox.Show("Tente novamente mais tarde.");

                }

                finally
                {
                    cn.Close();
                }
            }
            else {

                MessageBox.Show("Quantidade de saída inválida, seu estoque ficará abaixo da qtd Minima permitida");

            }
        }
    }
}
