using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CoreStore_CSharp.Dao
{
    class LoginDao
    {
        private MySqlDataReader dr;
        private MySqlCommand cmd;
        private bool v;
        private ConSql con;

        public LoginDao() {
            v = false;
        }

        public bool vlogin(string User, string Pass) {
            con = new ConSql();
            cmd = new MySqlCommand();

            cmd.CommandText = "select * from users where username = @User and pass = @Pass";
            cmd.Parameters.AddWithValue("@User", User);
            cmd.Parameters.AddWithValue("@Pass", Pass);

            try
            {
                cmd.Connection = con.connect();
                dr = cmd.ExecuteReader();

                if(dr.HasRows) {
                    v = true;
                }
            }
            catch (MySqlException err)
            {
                MessageBox.Show("Erro no vlogin - " + err);
            }
            return v;
        }
    }
}