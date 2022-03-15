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
    public partial class MonthSelectionPage : Form
    {
        public MonthSelectionPage()
        {
            InitializeComponent();
        }

        private void OcakInfoBTN_Click(object sender, EventArgs e)
        {

            mainEntities1 db = new mainEntities1();

            var query =
               from p in db.StudentInfo
               join m in db.StudentPaymentInfo on p.StudentID equals m.StudentID
               where m.Ocak == "False"
               select new { StudentName = p.StudentName, StudentSurname = p.StudentSurname, StudentTC = p.StudentTC };
            dataGridView1.DataSource = query.ToList();
        }

        private void ŞubatBTN_Click(object sender, EventArgs e)
        {
            mainEntities1 db = new mainEntities1();

            var query =
               from p in db.StudentInfo
               join m in db.StudentPaymentInfo on p.StudentID equals m.StudentID
               where m.Şubat == "False"
               select new { StudentName = p.StudentName, StudentSurname = p.StudentSurname, StudentTC =p.StudentTC };
            dataGridView1.DataSource = query.ToList();



        }

        private void MartBTN_Click(object sender, EventArgs e)
        {
            mainEntities1 db = new mainEntities1();

            var query =
               from p in db.StudentInfo
               join m in db.StudentPaymentInfo on p.StudentID equals m.StudentID
               where m.Mart == "False"
               select new { StudentName = p.StudentName, StudentSurname = p.StudentSurname, StudentTC = p.StudentTC };
            dataGridView1.DataSource = query.ToList();

        }

        private void NisanBTN_Click(object sender, EventArgs e)
        {
            mainEntities1 db = new mainEntities1();

            var query =
               from p in db.StudentInfo
               join m in db.StudentPaymentInfo on p.StudentID equals m.StudentID
               where m.Nisan == "False"
               select new { StudentName = p.StudentName, StudentSurname = p.StudentSurname, StudentTC =p. StudentTC };
            dataGridView1.DataSource = query.ToList();
        }

        private void MayısBTN_Click(object sender, EventArgs e)
        {
            mainEntities1 db = new mainEntities1();

            var query =
               from p in db.StudentInfo
               join m in db.StudentPaymentInfo on p.StudentID equals m.StudentID
               where m.Mayıs == "False"
               select new { StudentName = p.StudentName, StudentSurname = p.StudentSurname, StudentTC = p.StudentTC };
            dataGridView1.DataSource = query.ToList();

        }

        private void HaziranBTN_Click(object sender, EventArgs e)
        {
            mainEntities1 db = new mainEntities1();

            var query =
               from p in db.StudentInfo
               join m in db.StudentPaymentInfo on p.StudentID equals m.StudentID
               where m.Haziran == "False"
               select new { StudentName = p.StudentName, StudentSurname = p.StudentSurname, StudentTC =p.StudentTC };
            dataGridView1.DataSource = query.ToList();
        }

        private void TemmuzBTN_Click(object sender, EventArgs e)
        {

            mainEntities1 db = new mainEntities1();

            var query =
               from p in db.StudentInfo
               join m in db.StudentPaymentInfo on p.StudentID equals m.StudentID
               where m.Temmuz == "False"
               select new { StudentName = p.StudentName, StudentSurname = p.StudentSurname, StudentTC = p.StudentTC };
            dataGridView1.DataSource = query.ToList();

        }

        private void AğustosBTN_Click(object sender, EventArgs e)
        {
            mainEntities1 db = new mainEntities1();

            var query =
               from p in db.StudentInfo
               join m in db.StudentPaymentInfo on p.StudentID equals m.StudentID
               where m.Ağustos == "False"
               select new { StudentName = p.StudentName, StudentSurname = p.StudentSurname, StudentTC = p.StudentTC };
            dataGridView1.DataSource = query.ToList();

        }

        private void EylülBTN_Click(object sender, EventArgs e)
        {
            mainEntities1 db = new mainEntities1();

            var query =
               from p in db.StudentInfo
               join m in db.StudentPaymentInfo on p.StudentID equals m.StudentID
               where m.Eylül == "False"
               select new { StudentName = p.StudentName, StudentSurname = p.StudentSurname, StudentTC =p.StudentTC };
            dataGridView1.DataSource = query.ToList();

        }

        private void EkimBTN_Click(object sender, EventArgs e)
        {
            mainEntities1 db = new mainEntities1();

            var query =
               from p in db.StudentInfo
               join m in db.StudentPaymentInfo on p.StudentID equals m.StudentID
               where m.Ekim == "False"
               select new { StudentName = p.StudentName, StudentSurname = p.StudentSurname , StudentTC= p.StudentTC };
            dataGridView1.DataSource = query.ToList();

        }

        private void KasımBTN_Click(object sender, EventArgs e)
        {
            mainEntities1 db = new mainEntities1();

            var query =
               from p in db.StudentInfo
               join m in db.StudentPaymentInfo on p.StudentID equals m.StudentID
               where m.Kasım == "False"
               select new { StudentName = p.StudentName, StudentSurname = p.StudentSurname, StudentTC = p.StudentTC };
            dataGridView1.DataSource = query.ToList();

        }

        private void AralıkBTN_Click(object sender, EventArgs e)
        {
            mainEntities1 db = new mainEntities1();

            var query =
               from p in db.StudentInfo
               join m in db.StudentPaymentInfo on p.StudentID equals m.StudentID
               where m.Aralık == "False"
               select new { StudentName = p.StudentName, StudentSurname = p.StudentSurname, StudentTC =p.StudentTC };
            dataGridView1.DataSource = query.ToList();

        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            MainPage main = new MainPage();
            main.Show();


        }
    }
}
