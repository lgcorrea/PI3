using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
        public int qtdProdutoDisponivel { get; set; }
        public byte[] imagem { get; set; }
        public bool FotoCarregada { get; set; }


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
                              ,a.idCategoria
							  ,nomeCategoria
                              ,ativoProduto = CONVERT(BIT,CASE WHEN ativoProduto NOT IN (0,1) THEN 0 ELSE ativoProduto END)                 
                              ,imagem

                        FROM PRODUTO A
                        INNER JOIN CATEGORIA B ON A.IDCATEGORIA = B.IDCATEGORIA 
                        INNER JOIN ESTOQUE C ON C.IDPRODUTO = A.IDPRODUTO
                        WHERE nomeProduto LIKE @nomeProduto
                        OR precProduto LIKE @nomeProduto
                        or qtdProdutoDisponivel like @nomeProduto
                        or qtdMinEstoque like  @nomeProduto
                        or nomeCategoria like @nomeProduto
                        OR descontoPromocao LIKE @nomeProduto";

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
                              ,a.idCategoria             
                              ,ativoProduto = CONVERT(BIT,CASE WHEN ativoProduto NOT IN (0,1) THEN 0 ELSE ativoProduto END) 
                              ,IMAGEM
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

        public void Salvar()
        {
            ClsConexao ConectaBD = new ClsConexao();
            SqlConnection cn = ConectaBD.Conectar();

            string sql = "";
            SqlCommand cmd = new SqlCommand(sql, cn);

            // VALIDA SE NOME PRODUTO JA EXISTE AO ATUALIZAR OU INSERIR
            sql = @"SELECT 1 FROM PRODUTO
                    WHERE nomeProduto = @nomeProduto";

            cmd.Parameters.Add("@nomeProduto", SqlDbType.VarChar, 50).Value = this.nomeProduto;

            cmd.CommandText = sql;
            Boolean ExisteProduto = Convert.ToBoolean(cmd.ExecuteScalar());
            try
            {

                if (!ExisteProduto || idProduto != 0)
                {
                    if (idProduto == 0)
                    {
                        sql = @"DECLARE @ID_INSERIDO TABLE (ID INT)
                            INSERT INTO PRODUTO (nomeProduto,descProduto,precProduto,descontoPromocao,qtdMinEstoque,ativoProduto,idCategoria,imagem,idUsuario)
                            OUTPUT inserted.idProduto into @ID_INSERIDO
                            VALUES(@nomeProduto,@descProduto,@precProduto,@descontoPromocao,@qtdMinEstoque,@ativoProduto,@idCategoria,@imagem,@idUsuario)
                            SELECT ID FROM @ID_INSERIDO";

                        cmd.Parameters.Add("@descProduto", SqlDbType.VarChar, 60).Value = this.descProduto;
                        cmd.Parameters.Add("@precProduto", SqlDbType.Money).Value = this.precProduto;
                        cmd.Parameters.Add("@descontoPromocao", SqlDbType.Money).Value = this.descontoPromocao;
                        cmd.Parameters.Add("@qtdMinEstoque", SqlDbType.Int).Value = this.qtdMinEstoque;
                        cmd.Parameters.Add("@ativoProduto", SqlDbType.Bit).Value = this.ativoProduto;
                        cmd.Parameters.Add("@idCategoria", SqlDbType.Int).Value = this.idCategoria;
                        cmd.Parameters.Add("@idUsuario", SqlDbType.Int).Value = this.idUsuario;
                        try
                        {
                            if (imagem == null)
                            {
                                imagem = new byte[0];
                                cmd.Parameters.Add("@imagem", SqlDbType.Image, imagem.Length).Value = this.imagem;
                            }
                            else
                            {
                                cmd.Parameters.Add("@imagem", SqlDbType.Image, imagem.Length).Value = this.imagem;
                            }
                            cmd.CommandText = sql;

                            idProduto = Convert.ToInt32(cmd.ExecuteScalar());

                            MessageBox.Show("Produto Cadastrado");
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Imagem de tamanho inválido. Máximo 300kb");

                        }
                    }
                    else
                    {
                        sql = @"UPDATE PRODUTO
                        SET nomeProduto = @nomeProduto,                            
                            descProduto = @descProduto,
                            precProduto = @precProduto,
                            descontoPromocao = @descontoPromocao,
                            idCategoria = @idCategoria,
                            ativoProduto = @ativoProduto,
                            idUsuario = @idUsuario,
                            qtdMinEstoque = @qtdMinEstoque,
                            imagem = @imagem                      
                        WHERE idProduto = " + idProduto;

                        cmd.Parameters.Add("@descProduto", SqlDbType.VarChar, 60).Value = this.descProduto;
                        cmd.Parameters.Add("@precProduto", SqlDbType.Money).Value = this.precProduto;
                        cmd.Parameters.Add("@descontoPromocao", SqlDbType.Money).Value = this.descontoPromocao;
                        cmd.Parameters.Add("@qtdMinEstoque", SqlDbType.Int).Value = this.qtdMinEstoque;
                        cmd.Parameters.Add("@ativoProduto", SqlDbType.Bit).Value = this.ativoProduto;
                        cmd.Parameters.Add("@idCategoria", SqlDbType.Int).Value = this.idCategoria;
                        cmd.Parameters.Add("@idUsuario", SqlDbType.Int).Value = this.idUsuario;
                        try
                        {
                            if (imagem == null)
                            {
                                imagem = new byte[0];
                                cmd.Parameters.Add("@imagem", SqlDbType.Image, imagem.Length).Value = this.imagem;
                            }
                            else
                            {
                                cmd.Parameters.Add("@imagem", SqlDbType.Image, imagem.Length).Value = this.imagem;

                            }

                            cmd.CommandText = sql;

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Produto Alterado");
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Imagem de tamanho inválido. Máximo 300kb");

                        }
                    }


                }
                else
                {
                    MessageBox.Show("Produto já existe, cadastre outro nome");

                }
            }
            catch
            {

                MessageBox.Show("Erro salvar informações");
            }

        }
        public void Excluir(int idProduto)
        {
            ClsConexao ConectaBD = new ClsConexao();
            SqlConnection cn = ConectaBD.Conectar();

            string sql = "";
            SqlCommand cmd = new SqlCommand(sql, cn);

            

            try
            {
                sql = @"DELETE FROM PRODUTO
                        WHERE IDPRODUTO = @idProduto";
                cmd.Parameters.Add("@idProduto", SqlDbType.Int).Value = idProduto;
            cmd.CommandText = sql;

            cmd.ExecuteNonQuery();

            }

            catch
            {

                MessageBox.Show("Erro ao excluir item");               

          }
            
        }



    }



    }

