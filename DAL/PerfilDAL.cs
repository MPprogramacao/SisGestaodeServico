using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class PerfilDAL
    {
        private conexaoMySQL conn = new conexaoMySQL();

        public void SalvarImagem(Perfil perfil)
        {            
            
            try
            {
                conn.conexao();

                //string salvarI = (String.Format("UPDATE tb_user_config SET valor='{0}', plano_de_fundo='{1}' WHERE login = '{2}'", perfil.Image, "I", perfil.Login));
                //MySqlCommand command = new MySqlCommand(salvarI, conn.mConn);

                MySqlCommand command = conn.mConn.CreateCommand();

                command.CommandText = "UPDATE tb_user_config SET valor = @valor, plano_de_fundo = @plano_de_fundo WHERE login = @login";

                command.Parameters.AddWithValue("@login", perfil.Login);
                command.Parameters.AddWithValue("@valor", perfil.Image);
                command.Parameters.AddWithValue("@plano_de_fundo", "I");

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao atulizar a Imagem! " + ex.Message);
            }
            finally
            {
                conn.fechar();
            }
        }

        public void SalvarCor(Perfil perfil)
        {            
            try
            {
                conn.conexao();

                //String salvaC = (String.Format("UPDATE tb_user_config SET valor='{0}', plano_de_fundo = '{1}' WHERE login = '{2}' ", perfil.Cor, 'C', perfil.Login));
                //MySqlCommand command = new MySqlCommand(tese, conexao1.mConn);

                MySqlCommand command = conn.mConn.CreateCommand();

                command.CommandText = "UPDATE tb_user_config SET valor = @valor, plano_de_fundo = @plano_de_fundo WHERE login = @login";

                command.Parameters.AddWithValue("@login", perfil.Login);
                command.Parameters.AddWithValue("@valor", perfil.Cor);
                command.Parameters.AddWithValue("@plano_de_fundo", "C");

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao atualizar a COR! " + ex.Message);
            }
            finally
            {
                conn.fechar();
            }
        }

        public String VerificarCoreFundo(Perfil perfil)
        {
            try
            {
                DataTable dt = new DataTable();
                conn.conexao();

                string verifica = (String.Format("SELECT plano_de_fundo FROM tb_user_config WHERE login = '{0}'", perfil.Login));
                MySqlCommand command = new MySqlCommand(verifica, conn.mConn);                
                

                MySqlDataReader reader = command.ExecuteReader();
                dt.Load(reader);

                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0]["plano_de_fundo"].ToString();
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao verificar campo na base de dados! " + ex.Message);
            }
            finally
            {
                conn.fechar();
            }
        }

        public String RetornaCoreFundo(Perfil perfil)
        {
            try
            {
                DataTable dt = new DataTable();
                conn.conexao();

                string retorna = (String.Format("SELECT valor FROM tb_user_config WHERE login = '{0}'", perfil.Login));
                MySqlCommand command = new MySqlCommand(retorna, conn.mConn);

                MySqlDataReader reader = command.ExecuteReader();
                dt.Load(reader);

                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0]["valor"].ToString();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.fechar();
            }
        }
    }
}
