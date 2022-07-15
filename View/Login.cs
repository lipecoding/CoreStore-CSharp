using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreStore_CSharp.View
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();

            this.loginbtn.Parent = this.loginpnl;

            this.loginbtn.Left = (this.loginbtn.Parent.Width - this.loginbtn.Width) / 2;
            
            this.usertxt.Left = (this.loginbtn.Parent.Width - this.usertxt.Width) / 2;
            this.userlbl.Left = (this.loginbtn.Parent.Width - this.userlbl.Width) / 2;

            this.passtxt.Left = (this.loginbtn.Parent.Width - this.passtxt.Width) / 2;
            this.passlbl.Left = (this.loginbtn.Parent.Width - this.passlbl.Width) / 2;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            Model.UserDTO objUserDto = new Model.UserDTO();
            Dao.LoginDao objLoginDao = new Dao.LoginDao();

            objUserDto.User = this.usertxt.Text;
            objUserDto.Pass = this.passtxt.Text;

            bool r = objLoginDao.vlogin(objUserDto.User, objUserDto.Pass);

            if(r == true) {
                Main m = new Main();
                m.Show();

                this.Hide();
                
            } else {
                MessageBox.Show("Senha/email incorretos!");
            }




        }
    }
}
