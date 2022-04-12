using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System;
using System.Data;

namespace DAL
{
    public class conexaoLite
    {
        //public static SQLiteConnection sqliteConnection;
        public static SQLiteConnection  conexao()
        {
            SQLiteConnection sqliteConnection = new SQLiteConnection("Data Source=C:\\Users\\Matheus\\Desktop\\Faculdade\\Estágio Curricular Supervisionado I\\Projeto\\SisGestaodeServico\\BancoLocal\\sis.db; Version=3;");
            sqliteConnection.Open();
            return sqliteConnection;
        }
        
    }
}
