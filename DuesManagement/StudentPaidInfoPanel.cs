using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuesManagement
{
   


    public partial class StudentPaidInfoPanel : Form
    {
        public StudentPaidInfoPanel()
        {
            InitializeComponent();
        }

       

        private void StudentPaidInfoPanel_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["StudentPanel"];

            IdtestTextBox.Text = ((StudentPanel)f).StudentIdTextBox.Text;
            NameSurnameLabel.Text= ((StudentPanel)f).NametextBox.Text+" "+ ((StudentPanel)f).SurnametextBox.Text+"'nın ödeme bilgileri"; 
            read();

        }   
        void read()
        {


            if (IdtestTextBox.Text.Length != 0)
            {
                int x = Convert.ToInt32(IdtestTextBox.Text);
                using (var ctx = new mainEntities1())
                {



                    var month = ctx.StudentPaymentInfo.Where(s => s.StudentID == x).ToList();
                    for (int i = 0; i < month.Count; i++)
                    {
                        if (month[i].Ocak.Equals("True"))
                        {
                            OcakcheckBox.Checked = true;
                        }
                        if (month[i].Ocak.Equals("False"))
                        {
                            OcakcheckBox.Checked = false;
                        }
                        if (month[i].Şubat.Equals("True"))
                        {
                            ŞubatcheckBox.Checked = true;
                        }
                        if (month[i].Şubat.Equals("False"))
                        {
                            ŞubatcheckBox.Checked = false;
                        }
                        if (month[i].Mart.Equals("True"))
                        {
                            MartcheckBox.Checked = true;
                        }
                        if (month[i].Mart.Equals("False"))
                        {
                            MartcheckBox.Checked = false;
                        }
                        if (month[i].Nisan.Equals("True"))
                        {
                            NisancheckBox.Checked = true;
                        }
                        if (month[i].Nisan.Equals("False"))
                        {
                            NisancheckBox.Checked = false;
                        }
                        if (month[i].Mayıs.Equals("True"))
                        {
                            MayıscheckBox.Checked = true;
                        }
                        if (month[i].Mayıs.Equals("False"))
                        {
                            MayıscheckBox.Checked = false;
                        }
                        if (month[i].Haziran.Equals("True"))
                        {
                            HazirancheckBox.Checked = true;
                        }
                        if (month[i].Haziran.Equals("False"))
                        {
                            HazirancheckBox.Checked = false;
                        }
                        if (month[i].Temmuz.Equals("True"))
                        {
                            TemmuzcheckBox.Checked = true;
                        }
                        if (month[i].Temmuz.Equals("False"))
                        {
                            TemmuzcheckBox.Checked = false;
                        }
                        if (month[i].Ağustos.Equals("True"))
                        {
                            AğustoscheckBox.Checked = true;
                        }
                        if (month[i].Ağustos.Equals("False"))
                        {
                            AğustoscheckBox.Checked = false;
                        }
                        if (month[i].Eylül.Equals("True"))
                        {
                            EylülcheckBox.Checked = true;
                        }
                        if (month[i].Eylül.Equals("False"))
                        {
                            EylülcheckBox.Checked = false;
                        }
                        if (month[i].Ekim.Equals("True"))
                        {
                            EkimcheckBox.Checked = true;
                        }
                        if (month[i].Ekim.Equals("False"))
                        {
                            EkimcheckBox.Checked = false;
                        }
                        if (month[i].Kasım.Equals("True"))
                        {
                            KasımcheckBox.Checked = true;
                        }
                        if (month[i].Kasım.Equals("False"))
                        {
                            KasımcheckBox.Checked = false;
                        }
                        if (month[i].Aralık.Equals("True"))
                        {
                            AralıkcheckBox.Checked = true;
                        }
                        if (month[i].Aralık.Equals("False"))
                        {
                            AralıkcheckBox.Checked = false;
                        }



                    }


                }



                

            }
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show(" Kaydetmek istediğinizden emin misiniz", "Ödeme bilgisi kaydetme ", MessageBoxButtons.YesNo);


            if (dialogResult == DialogResult.Yes)
            {

                int id = Convert.ToInt32(IdtestTextBox.Text);
                using (mainEntities1 db = new mainEntities1())
                {


                    var update = db.StudentPaymentInfo.FirstOrDefault(a => a.StudentID == id);
                    if (update != null)
                    {

                        update.Haziran = HazirancheckBox.Checked.ToString();
                        update.Ocak = OcakcheckBox.Checked.ToString();
                        update.Şubat = ŞubatcheckBox.Checked.ToString();
                        update.Mart = MartcheckBox.Checked.ToString();
                        update.Nisan = NisancheckBox.Checked.ToString();
                        update.Mayıs = MayıscheckBox.Checked.ToString();
                        update.Haziran = HazirancheckBox.Checked.ToString();
                        update.Temmuz = TemmuzcheckBox.Checked.ToString();
                        update.Ağustos = AğustoscheckBox.Checked.ToString();
                        update.Eylül = EylülcheckBox.Checked.ToString();
                        update.Ekim = EkimcheckBox.Checked.ToString();
                        update.Kasım = KasımcheckBox.Checked.ToString();
                        update.Aralık = AralıkcheckBox.Checked.ToString();





                    }
                    db.SaveChanges();
                    MessageBox.Show(" Öğrenci ödeme bilgileri başarıyla kaydedildi ");
                    



                }
            }
            read();

        }
    }

   



}
