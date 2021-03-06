﻿using System;
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
        //PROPRIEDADE DE ATRIBUTO

        public int idUsuario { get; set; }
        public string loginUsuario { get; set; }
        public string senhaUsuario { get; set; }
        public string nomeUsuario { get; set; }
        public string tipoPerfil { get; set; }
        public bool usuarioAtivo { get; set; }

        //METODO LOGAR
        public ClsUsuario Logar(string _loginUsuario, string _senhaUsuario)
        {

            ClsConexao ConectaBD = new ClsConexao();
            SqlConnection cn = ConectaBD.Conectar();

            ClsUsuario usuario = null;
            try
            {
                string sql = (@"SELECT idUsuario,loginUsuario, nomeUsuario, tipoPerfil
                                  FROM usuario
                              where loginUsuario = @_loginUsuario 
                              and senhaUsuario = @_senhaUsuario 
                              and usuarioAtivo = 1");

                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = sql;


                cmd.Parameters.Add("@_loginUsuario", SqlDbType.VarChar).Value = _loginUsuario;
                cmd.Parameters.Add("@_senhaUsuario", SqlDbType.VarChar).Value = _senhaUsuario;

                SqlDataReader dr = cmd.ExecuteReader();
                usuario = new ClsUsuario();

                dr.Read();
                usuario.loginUsuario = dr.GetString(dr.GetOrdinal("loginUsuario"));
                usuario.nomeUsuario = dr.GetString(dr.GetOrdinal("nomeUsuario"));
                usuario.tipoPerfil = dr.GetString(dr.GetOrdinal("tipoPerfil"));
                usuario.idUsuario = dr.GetInt32(dr.GetOrdinal("idUsuario"));

            }
            catch (InvalidOperationException e)

            {
                usuario = null;
            }

            finally
            {
                cn.Close();
            }
            return usuario;

        }

        //METODO BUSCA DADOS DE USUARIOS PARA NAVEGAÇÃO
        public DataTable NavegaUsuarios()
        {

            ClsConexao ConectaBD = new ClsConexao();

            SqlConnection cn = ConectaBD.Conectar();
            DataTable dados = new DataTable();

            try
            {
                string sql = @"SELECT idUsuario
                              ,loginUsuario                              
                              ,nomeUsuario
                              ,CASE WHEN tipoPerfil= 'A' THEN 'Administrador' ELSE 'Estoquista' END as tipoPerfil
                              ,usuarioAtivo
                          FROM Usuario";
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                da.Fill(dados);

            }

            catch
            {
                dados = null;

            }

            finally
            {

                cn.Close();
            }

            return dados;


        }

        //METODO BUSCA USUÁRIO

        public DataTable BuscaUser(string nomeUser)
        {
            ClsConexao ConectaBD = new ClsConexao();
            SqlConnection cn = ConectaBD.Conectar();
            DataTable dados = new DataTable();

            try
            {
                string sql = @"SELECT idUsuario
                              ,loginUsuario                              
                              ,nomeUsuario
                              ,CASE WHEN tipoPerfil= 'A' THEN 'Administrador' ELSE 'Estoquista' END as tipoPerfil
                              ,usuarioAtivo
                          FROM Usuario
                          WHERE nomeUsuario like @nomeUser";

                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@nomeUser", "%" + nomeUser + "%");

                SqlDataAdapter dB = new SqlDataAdapter();
                dB.SelectCommand = cmd;

                dB.Fill(dados);

            }

            catch
            {

                dados = null;
            }
            finally
            {
                cn.Close();
            }

            return dados;
        }

        //METODO SALVAR

        public void Salvar()
        {

            ClsConexao ConectaBD = new ClsConexao();
            SqlConnection cn = ConectaBD.Conectar();

            string sql = "";
            SqlCommand cmd = new SqlCommand(sql, cn);

            // VALIDA SE USUARIO OU LOGIN EXISTE NO BANCO ANTES DE ATUALIZAR OU INSERIR
            sql = @"SELECT 1 FROM USUARIO
                    WHERE loginUsuario = @loginUsuario";

            cmd.Parameters.Add("@nomeUsuario", SqlDbType.VarChar, 50).Value = this.nomeUsuario;
            cmd.Parameters.Add("@loginUsuario", SqlDbType.VarChar, 50).Value = this.loginUsuario;

            cmd.CommandText = sql;
            Boolean ExisteUsuario = Convert.ToBoolean(cmd.ExecuteScalar());

            if (!ExisteUsuario || idUsuario !=0)
            {

                if (idUsuario == 0)
                {
                    sql = @"DECLARE @ID_INSERIDO TABLE (ID INT)
                            INSERT INTO USUARIO (loginUsuario,senhaUsuario,nomeUsuario,tipoPerfil,usuarioAtivo)
                            OUTPUT inserted.idUsuario into @ID_INSERIDO
                            VALUES(@loginUsuario,@senhaUsuario,@nomeUsuario,@tipoPerfil,@usuarioAtivo)
                            SELECT ID FROM @ID_INSERIDO";
                    
                    cmd.Parameters.Add("@senhaUsuario", SqlDbType.VarChar, 50).Value = this.senhaUsuario;                    
                    cmd.Parameters.Add("@tipoPerfil", SqlDbType.VarChar, 1).Value = this.tipoPerfil;
                    cmd.Parameters.Add("@usuarioAtivo", SqlDbType.Bit).Value = this.usuarioAtivo;

                    cmd.CommandText = sql;

                    idUsuario = Convert.ToInt32(cmd.ExecuteScalar());

                    MessageBox.Show("Usuário Cadastrado");
                }

                else
                {
                    if (senhaUsuario == "")
                    {
                        sql = @"UPDATE USUARIO
                        SET loginUsuario = @loginUsuario,                            
                            nomeUsuario = @nomeUsuario,
                            tipoPerfil = @tipoPerfil,
                            usuarioAtivo = @usuarioAtivo
                        WHERE idUsuario = " + idUsuario;
                                           
                        cmd.Parameters.Add("@tipoPerfil", SqlDbType.VarChar, 1).Value = this.tipoPerfil;
                        cmd.Parameters.Add("@usuarioAtivo", SqlDbType.Bit).Value = this.usuarioAtivo;

                        cmd.CommandText = sql;

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Usuário Alterado");
                    }
                    else
                    {
                        sql = @"UPDATE USUARIO
                            SET loginUsuario = @loginUsuario,
                            senhaUsuario = @senhaUsuario,
                            nomeUsuario = @nomeUsuario,
                            tipoPerfil = @tipoPerfil,
                            usuarioAtivo = @usuarioAtivo
                        WHERE idUsuario = " + idUsuario;

                        cmd.Parameters.Add("@senhaUsuario", SqlDbType.VarChar, 50).Value = this.senhaUsuario;                        
                        cmd.Parameters.Add("@tipoPerfil", SqlDbType.VarChar, 1).Value = this.tipoPerfil;
                        cmd.Parameters.Add("@usuarioAtivo", SqlDbType.Bit).Value = this.usuarioAtivo;

                        cmd.CommandText = sql;

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Usuário Alterado");
                    }
                }
            }

            else
            {

                MessageBox.Show("Login já cadastro! Favor alterar!");
            }

        }





    }
}
       




    