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

        public String un, p, n, ln, a, z, c, b;
        public int ad;
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

                    if(dr.HasRows)
                    {
                        un = dr.GetString("username");
                        p = dr.GetString("pass");
                        n = dr.GetString("name");
                        ln = dr.GetString("lastname");
                        a = dr.GetString("adress");
                        z = dr.GetString("zipcode");
                        c = dr.GetString("cpf");
                        b = dr.GetString("birthday");
                        ad = dr.GetInt16("admin");
                    }
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