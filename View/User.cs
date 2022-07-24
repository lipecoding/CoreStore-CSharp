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
        }
    }
}
