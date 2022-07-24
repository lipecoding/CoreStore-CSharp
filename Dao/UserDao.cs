using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CoreStore_CSharp.Dao
{
    class UserDao
    {
        private MySqlCommand cmduser;
        private ConSql con;
        private MySqlDataReader dr;
        public void search(string id) {
            con = new ConSql();
            cmduser = new MySqlCommand();

            View.User objuser = new View.User();

            cmduser.CommandText = "select * from users where userid = @Userid";
            cmduser.Parameters.AddWithValue("@Userid", id);

            try
            {
                cmduser.Connection = con.connect();
                dr = cmduser.ExecuteReader();

                if(dr.Read()) {
                    objuser.usertxt.Text = Char.ToString(dr.GetChar("username"));
                    MessageBox.Show("teste!");
                } else {
                    MessageBox.Show("UserId não Existe!");
                }
            
            }
            catch (System.Exception err)
            {
                MessageBox.Show("Erro: " + err.Message);
            }
        }
    }
}