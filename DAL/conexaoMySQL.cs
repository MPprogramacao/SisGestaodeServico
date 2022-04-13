using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;


namespace DAL
{
    public class conexaoMySQL
    {        
        public MySqlConnection mConn;

        //Conexão com bando
        public void conexao()
        {
            //defina string de conexao e cria a conexao
            mConn = new MySqlConnection("Persist Security Info=False;server=127.0.0.1;database=sisgestaodeservico;uid=root");

            try
            {
                //abre a conexao
                mConn.Open();
            }
            catch (System.Exception e)
            {
                e.Message.ToString();
            }
        }

        //Fechar Banco
        public void fechar()
        {
            if (mConn != null && mConn.State == ConnectionState.Open)
            {
                mConn.Close();
            }
        }
    }
}
