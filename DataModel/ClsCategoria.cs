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
    public class ClsCategoria
    {

        public int idCategoria { get; set; }
        public string nomeCategoria { get; set; }
        public string descCategoria { get; set; }

        public DataTable GetCategoria()
        {
            ClsConexao ConectaBD = new ClsConexao();
            SqlConnection cn = ConectaBD.Conectar();
            DataTable categoria = new DataTable();

            try
            {
                string sql = @"SELECT idCategoria,
                                      nomeCategoria,
                                      descCategoria                                     
                                      FROM CATEGORIA";
                SqlCommand cmd = new SqlCommand(sql, cn);

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;

                da.Fill(categoria);

            }

            catch
            {
                categoria = null;
            }

            finally
            {

                cn.Close();
            }

            return categoria;
        }

        public void Salvar()
        {

            ClsConexao ConectaBD = new ClsConexao();
            SqlConnection cn = ConectaBD.Conectar();

            string sql = "";
            SqlCommand cmd = new SqlCommand(sql, cn);

            // VALIDA SE NOME CATEGORIA JA EXISTE ATUALIZAR OU INSERIR
            sql = @"SELECT 1 FROM CATEGORIA
                    WHERE nomeCategoria = @nomeCategoria";

            cmd.Parameters.Add("@nomeCategoria", SqlDbType.VarChar, 50).Value = this.nomeCategoria;

            cmd.CommandText = sql;
            Boolean ExisteCategoria = Convert.ToBoolean(cmd.ExecuteScalar());

            if (!ExisteCategoria)
            {

                if (idCategoria == 0)
                {
                    sql = @"DECLARE @ID_INSERIDO TABLE (ID INT)
                            INSERT INTO CATEGORIA (nomeCategoria,descCategoria)
                            OUTPUT inserted.idCategoria into @ID_INSERIDO
                            VALUES(@nomeCategoria,@descCategoria)
                            SELECT ID FROM @ID_INSERIDO";

                    cmd.Parameters.Add("@descCategoria", SqlDbType.VarChar, 60).Value = this.descCategoria;


                    cmd.CommandText = sql;

                    idCategoria = Convert.ToInt32(cmd.ExecuteScalar());

                    MessageBox.Show("Categoria Cadastrada");
                }

                else
                {
                    sql = @"UPDATE CATEGORIA
                        SET nomeCategoria = @nomeCategoria,                            
                            descCategoria = @descCategoria                           
                        WHERE idCategoria = " + idCategoria;
                        
                        cmd.Parameters.Add("@descCategoria", SqlDbType.VarChar,200).Value = this.descCategoria;

                        cmd.CommandText = sql;

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Categoria Alterada");
                    }
                    
                }
            else {

                MessageBox.Show("Nome de categoria já existente");

            }
            
            }

        }

    }

