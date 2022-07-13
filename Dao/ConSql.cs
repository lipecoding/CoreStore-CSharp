using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CoreStore_CSharp.Dao
{
    class ConSql
    {
        private MySqlConnection con = new MySqlConnection();

        public ConSql() {
            con.ConnectionString = @"server=localhost;user id=root;pwd=;database=corestore";
        }

        public MySqlConnection connect() {
            if(con.State == System.Data.ConnectionState.Closed) {
                con.Open();
            }
            return con;
        }
        public void disconnect() {
            if(con.State == System.Data.ConnectionState.Open) {
                con.Close();
            }
        }
    }
}