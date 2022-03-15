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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentPanel student = new StudentPanel();
            student.Show();
           
            



        }


        private void button2_Click(object sender, EventArgs e)
        {


            Application.Exit();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            MonthSelectionPage page = new MonthSelectionPage();
            page.Show();


        }
    }
}
