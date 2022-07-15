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
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        public Main()
        {
            InitializeComponent();

            User user = new User();

            user.TopLevel = false;
            mainpnl.Controls.Add(user);
            user.Show();
        }

        private void userbtn_Click(object sender, EventArgs e)
        {

        }

        private void providerbtn_Click(object sender, EventArgs e)
        {

        }

        private void miscbtn_Click(object sender, EventArgs e)
        {

        }

        private void productbtn_Click(object sender, EventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
