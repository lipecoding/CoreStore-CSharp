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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
