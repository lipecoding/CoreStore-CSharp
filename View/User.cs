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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            Model.UserDTO ObjDto = new Model.UserDTO();
            Dao.UserDao ObjDao = new Dao.UserDao();

            ObjDto.Id = useridtxt.Text;

            ObjDao.search(ObjDto.Id);

            this.usertxt.Text = ObjDao.un;
            this.passtxt.Text = ObjDao.p;
            this.nametxt.Text = ObjDao.n;
            this.lnametxt.Text = ObjDao.ln;
            this.birtgtxt.Text = ObjDao.b;
            this.adresstxt.Text = ObjDao.a;
            this.ziptxt.Text = ObjDao.z;
            this.cpftxt.Text = ObjDao.c;
            this.admtxt.Text = ObjDao.ad.ToString();
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            Model.UserDTO ObjDto = new Model.UserDTO();
            Dao.UserDao ObjDao = new Dao.UserDao();

            ObjDto.Id = useridtxt.Text;
            ObjDto.User = usertxt.Text;
            ObjDto.Pass = passtxt.Text;
            ObjDto.Name = nametxt.Text;
            ObjDto.Lname = lnametxt.Text;
            ObjDto.B = birtgtxt.Text;
            ObjDto.L = adresstxt.Text;
            ObjDto.Cep = ziptxt.Text;
            ObjDto.Cpf = cpftxt.Text;

            ObjDao.edit(ObjDto.Id, ObjDto.User, ObjDto.Pass, ObjDto.Name, ObjDto.Lname, ObjDto.L, ObjDto.Cep, ObjDto.Cpf, ObjDto.B, Int16.Parse(admtxt.Text));
        }

        private void createbtn_Click(object sender, EventArgs e)
        {

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

        }
    }
}
