using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PastryShop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UsernameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Information entered Incorrectly.");
            }
            else
            {
                if (UsernameTb.Text == "Admin" || PasswordTb.Text == "Password")
                {
                    VanillePastryShop obj = new VanillePastryShop();
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect password.");
                    UsernameTb.Text = "";
                    PasswordTb.Text = "";
                }
            }
        }
    }
}
