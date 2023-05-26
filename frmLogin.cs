using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_11
{
    public partial class frmLogin : Form
    {

        private User user1;
        private User user2;
        private List<User> users;

        public frmLogin()
        {
            InitializeComponent(); 
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            user1 = new User();
            user1.UserId = 1;
            user1.FullName = "Rakan";
            user1.Username = "Ad1298";
            user1.Password = "rakk21";

            user2 = new User();
            user2.UserId = 2;
            user2.FullName = "Yasser";
            user2.Username = "ae8974";
            user2.Password = "yas2005";

            users = new List<User>(); // We created the actual object for the list of users

            users.Add(user1);
            users.Add(user2);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(user1.Username != txtUsername.Text)
            {
                MessageBox.Show("wrong user format");
            }
            else
            {
                if(user1.Password == txtPassword.Text)
                {
                    MessageBox.Show("hello and welcome  " + user1.FullName);
                }
                else
                {
                    MessageBox.Show("Wrong password, please try again :) ");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
