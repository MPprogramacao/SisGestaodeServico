using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class SincBancos
    {
        private SQLiteDataAdapter da = null;
        private DataTable dtLite = new DataTable();

        private MySqlDataAdapter mAdapter;
        DataTable dtSQL = new DataTable();

        public async void Sinc_tb_login()
        {
            try
            {
                using (var cmd = conexaoLite.conexao().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM tb_login" ;
                    da = new SQLiteDataAdapter(cmd.CommandText, conexaoLite.conexao());
                    da.Fill(dtLite);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            try
            {
                conexaoMySQL conexao1 = new conexaoMySQL();
                conexao1.conexao();

                string selectQuery = "SELECT * FROM tb_login ";
                 MySqlCommand command = new MySqlCommand(selectQuery, conexao1.mConn) ;
                MySqlDataReader reader = command.ExecuteReader();
                dtSQL.Load(reader);
                
                //string linha = dtSQL.Rows.Count.ToString();
                //throw new Exception(linha);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
    }
}
