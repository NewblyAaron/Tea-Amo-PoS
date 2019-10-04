using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using TeaAmoWFA.Functions;

namespace TeaAmoWFA
{
    class Database {
    
        private MySqlConnection con;

        private readonly string conStr = "SERVER=localhost;UID=root;";

        public Database()
        {
            con = new MySqlConnection(conStr);
            OpenConnection();
        }

        private void OpenConnection()
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
            }
            catch (MySqlException ex)
            {
                new Msg().Error(ex.Message);
            }
        }

        private void CloseConnection()
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                    Console.WriteLine("Database disconnection successful");
                }
            }
            catch (MySqlException ex)
            {
                new Msg().Error(ex.Message);
            }
        }

        public void ExecuteNonQuery(string sql)
        {
            try
            {
                OpenConnection();

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                CloseConnection();
            }
            catch (MySqlException ex)
            {
                new Msg().Error(ex.Message);
            }
        }

        public object ExecuteScalar(string sql)
        {
            try
            {
                OpenConnection();

                MySqlCommand cmd = new MySqlCommand(sql, con);
                return cmd.ExecuteScalar();
            }
            catch (MySqlException ex)
            {
                new Msg().Error(ex.Message);
            }
            return null;
        }

        public MySqlDataReader ExecuteReader(string sql)
        {
            try
            {
                OpenConnection();

                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch (MySqlException ex)
            {
                new Msg().Error(ex.Message);
            }
            return null;
        }

        public MySqlDataAdapter ExecuteAdapter(string sql)
        {
            try
            {
                OpenConnection();

                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, con);
                return adapter;
            }
            catch (MySqlException ex)
            {
                new Msg().Error(ex.Message);
            }
            return null;
        }
    }
}
