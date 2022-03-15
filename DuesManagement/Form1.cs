using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuesManagement
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            mainEntities1 context = new mainEntities1();
            if (LogintxtBox.Text != string.Empty || PasswordtextBox.Text != string.Empty)
            {

                var user = context.admin.Where(a => a.Username.Equals(LogintxtBox.Text)).FirstOrDefault();
                if (user != null)
                {
                    if (user.Password.Equals(PasswordtextBox.Text))
                    {
                       
                        MainPage main = new MainPage();
                        main.Show();
                        
                                            

                    }


                }
                else
                    MessageBox.Show("Password not correct");

            }
            else
                MessageBox.Show("Username not correct");



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        //mainEntities db = new mainEntities();





    }
}
