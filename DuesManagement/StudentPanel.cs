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
    public partial class StudentPanel : Form
    {
        public StudentPanel()
        {
            InitializeComponent();
        }


      




        private void StudentPanel_Load(object sender, EventArgs e)
        {
            read();
            

        }
        

        private void InsertBTN_Click(object sender, EventArgs e)
        {
            if(NametextBox.Text!=string.Empty && SurnametextBox.Text!=string.Empty) { 
            using (mainEntities1 db = new mainEntities1())
            {

                db.StudentInfo.Add(new StudentInfo()
                {
                    
                    StudentName=NametextBox.Text,
                    StudentSurname=SurnametextBox.Text,
                    StudentTelno=TelnotextBox.Text,
                    StudentTC=StudentTCtextBox.Text,
                    StudentBirthday=dateTimePicker1.Value.ToString("dd.MM.yyyy"),
                    StudentRegday =dateTimePicker2.Value.ToString("dd.MM.yyyy"),
                    StudentNot=NottextBox.Text,
                    
                });
                


                db.SaveChanges();
                read();
                deleteText();
            }
            }
            else
                MessageBox.Show(" Ad ve soyad girilmesi zorunldur.");

        }

        

        private void UpgradeBTN_Click(object sender, EventArgs e)
        {
               if (StudentIdTextBox.Text.Length==0)
            {

           
           
                MessageBox.Show(" Lütfen Güncellemek için bir öğrenci seçiniz ");

            }
            else {

                int id = Convert.ToInt32(StudentIdTextBox.Text);

                using (mainEntities1 db = new mainEntities1())
                {


                    var update = db.StudentInfo.FirstOrDefault(a => a.StudentID == id);
                    if (update != null)
                    {

                        update.StudentName = NametextBox.Text;
                        update.StudentSurname = SurnametextBox.Text;
                        update.StudentTC = StudentTCtextBox.Text;
                        update.StudentNot = NottextBox.Text;
                        update.StudentTelno = TelnotextBox.Text;
                        update.StudentBirthday = dateTimePicker1.Value.ToString("dd.MM.yyyy");
                        update.StudentRegday = dateTimePicker2.Value.ToString("dd.MM.yyyy");


                    }
                    db.SaveChanges();
                    read();
                    deleteText();



                }


            }



        }
        
        
        
        void read()
        {
            mainEntities1 db = new mainEntities1();
            var liste = db.StudentInfo.ToList();
            StudentInfoDataGridView.DataSource = liste;

        }
        void deleteText()
        {
            NametextBox.Text = "";
            SurnametextBox.Text = "";
            StudentTCtextBox.Text = "";
            TelnotextBox.Text = "";           
            NottextBox.Text = "";
            StudentIdTextBox.Text = "";

        }
       

        private void StudentInfoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.StudentInfoDataGridView.Rows[e.RowIndex];
                StudentIdTextBox.Text= row.Cells[0].Value.ToString();
                NametextBox.Text = row.Cells[1].Value.ToString();
                SurnametextBox.Text = row.Cells[2].Value.ToString();
                StudentTCtextBox.Text = row.Cells[3].Value.ToString();
                TelnotextBox.Text = row.Cells[4].Value.ToString();
                NottextBox.Text = row.Cells[7].Value.ToString();
                String[] a = row.Cells[6].Value.ToString().Split('.');
                String[] b = row.Cells[5].Value.ToString().ToString().Split('.');

                dateTimePicker1.Value = new DateTime(Int32.Parse(a[2]), Int32.Parse(a[1]), Int32.Parse(a[0]));
                dateTimePicker2.Value= new DateTime(Int32.Parse(b[2]), Int32.Parse(b[1]), Int32.Parse(b[0]));
            }


        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (StudentIdTextBox.Text.Length == 0)
            {

                MessageBox.Show(" Lütfen silinecek öğrenciyi seçiniz");

            }
            else
            {

                DialogResult dialogResult = MessageBox.Show(NametextBox.Text+ " "+SurnametextBox.Text+ " silmek istediğinizden emin misiniz", "Öğrenci Silme işlemi", MessageBoxButtons.YesNo);


                if (dialogResult == DialogResult.Yes)
                {

                    int id = Convert.ToInt32(StudentIdTextBox.Text);

                    using (mainEntities1 db = new mainEntities1())
                    {


                        var delete = db.StudentInfo.FirstOrDefault(a => a.StudentID == id);
                        if (delete != null)
                        {

                            db.StudentInfo.Remove(delete);



                        }
                        db.SaveChanges();
                        deleteText();
                        read();


                    }
                }

            }
        }

        private void StudenPaidInfoBTN_Click(object sender, EventArgs e)
        {
            if (StudentIdTextBox.Text.Length == 0)
            {

                MessageBox.Show(" Lütfen öğrenci seçiniz");

            }
            else
            {
                StudentPaidInfoPanel info = new StudentPaidInfoPanel();
                info.Show();
            }
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            MainPage main = new MainPage();
            main.Show();

        }
    }
}
