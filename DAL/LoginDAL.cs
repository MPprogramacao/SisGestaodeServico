using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;
using System.Data.SQLite;

namespace DAL
{
    public class LoginDAL
    {
        private SQLiteDataAdapter da = null;
        private DataTable dt = new DataTable();

        public bool verificaLogin(Usuario usuario)
        {        

            try
            {
                using (var cmd = conexaoLite.conexao().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM tb_login Where usuario = '"+ usuario.Login + "' and senha="+usuario.Senha;
                    da = new SQLiteDataAdapter(cmd.CommandText, conexaoLite.conexao());
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
