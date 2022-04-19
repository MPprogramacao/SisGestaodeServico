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
    public class LoginDAL
    {
        private MySqlDataAdapter mAdapter;
        private DataTable dt = new DataTable();

        public bool verificaLogin(Usuario usuario)
        {        

            try
            {              
                conexaoMySQL conexao1 = new conexaoMySQL();
                conexao1.conexao();

                string selectQuery = "SELECT * FROM tb_login Where ativo = '1' and usuario = '" + usuario.Login + "' and senha=" + usuario.Senha; ;
                MySqlCommand command = new MySqlCommand(selectQuery, conexao1.mConn);
                MySqlDataReader reader = command.ExecuteReader();
                dt.Load(reader);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


            if (dt.Rows.Count > 0)
            {
                //usuario.Id = dt.Rows[0].Field<int>("id"));
                usuario.Id = Convert.ToInt32(dt.Rows[0].ItemArray[0]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
