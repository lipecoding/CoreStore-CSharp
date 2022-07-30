using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CoreStore_CSharp.Dao
{
    class UserDao
    {
        private MySqlCommand cmd;
        private ConSql con;
        private MySqlDataReader dr;

        public String un, p, n, ln, a, z, c, b;
        public int ad;
        public void search(string id) {
            con = new ConSql();
            cmd = new MySqlCommand();

            cmd.CommandText = "select * from users where userid = @Userid";
            cmd.Parameters.AddWithValue("@Userid", id);

            try
            {
                cmd.Connection = con.connect();
                dr = cmd.ExecuteReader();

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

        public void edit(string id, string user, string pass, string name, string lname, string adress, string zip, string cpf, string birth, int adm) {
            con = new ConSql();
            cmd = new MySqlCommand();

            cmd.CommandText = "update corestore.users set username=@u,pass=@p,name=@n,lastname=@l,adress=@a,zipcode=@z,cpf=@c,birthday=@b,admin=@admin where userid=@id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@u", user);
            cmd.Parameters.AddWithValue("@p", pass);
            cmd.Parameters.AddWithValue("@n", name);
            cmd.Parameters.AddWithValue("@l", lname);
            cmd.Parameters.AddWithValue("@a", adress);
            cmd.Parameters.AddWithValue("@z", zip);
            cmd.Parameters.AddWithValue("@c", cpf);
            cmd.Parameters.AddWithValue("@b", birth);
            cmd.Parameters.AddWithValue("@admin", adm);

            try
            {
                cmd.Connection = con.connect();

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Done!");
                } else {
                    MessageBox.Show("unDone!");
                }
            }
            catch (System.Exception err)
            {
                MessageBox.Show("Erro: " + err.Message);
            }
        }
    }
}