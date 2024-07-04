using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAEPClass;

namespace TAEPClass
{
    public static class Banco
    {
        public static MySqlCommand Abrir()
        {
            MySqlCommand cmd = new MySqlCommand();
            // dados da conexão
            string strconn = @"server=127.0.0.1;database=TudoAcabaEmPizzaDB;user id=root;password=";
            MySqlConnection cn = new MySqlConnection(strconn);
            try
            {
                cn.Open();
                cmd.Connection = cn;

            }
            catch (Exception)
            {
                throw;
            }
            return cmd;
        }
    }
}
