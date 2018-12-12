using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Mateusz_Cebrat_PUM
{
    /// <summary>
    /// Interaction logic for First.xaml
    /// </summary>
    public partial class First : Window
    {
        public First()
        {
            InitializeComponent();
        }


        Database_service save = new Database_service();
        Datavalidation_service check = new Datavalidation_service();

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
        

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            var height = txtHeight.Text;
            var weight = txtWeight.Text;
            var treatment = txtTreatment.Text;
            var information = txtInformation.Text;
            var patientID = txtPatientID.Text;
            var diseases = txtDisases.Text;
            var medicines = txtMedicine.Text;
            var alergy = txtAlergy.Text;
            var group = txtGroup.Text;
            var rh = txtRh.Text;
            var alcohol = txtAlcohol.Text;
            var cigarets = txtCigarets.Text;
            int patienid = Convert.ToInt16(txtPatientID.Text);
            

            if (height.Length != 0 & weight.Length != 0 & treatment.Length != 0 & information.Length != 0  & diseases.Length !=0 & medicines.Length != 0 & alergy.Length != 0 & group.Length !=0 & rh.Length !=0 & alcohol.Length != 0 & cigarets.Length != 0  )
            {
                save.anamnesisSave(txtWeight.Text, txtHeight.Text, txtTreatment.Text, txtInformation.Text, txtDisases.Text, txtAlergy.Text, txtMedicine.Text, txtGroup.Text, txtRh.Text,txtAlcohol.Text,txtCigarets.Text,patienid);

                    MessageBox.Show("Zapisano pomyślnie");
                
            }
            else
            {
                MessageBox.Show("Brak wypełnionych danych!");
            }
           
        }   

       
        #region text functions

        private void txtHeight_TextChanged(object sender, TextChangedEventArgs e)
        {
            var checkstate = check.Checking_numbers(txtHeight.Text);
            if (checkstate == true)
            {
                MessageBox.Show("Nieprawidłowy znak!");
                txtHeight.Text = txtHeight.Text.Remove(txtHeight.Text.Length - 1);
            }
        }

        private void txtWeight_TextChanged(object sender, TextChangedEventArgs e)
        {
            var checkstate = check.Checking_numbers(txtWeight.Text);
            if (checkstate == true)
            {
                MessageBox.Show("Nieprawidłowy znak!");
                txtWeight.Text = txtWeight.Text.Remove(txtWeight.Text.Length - 1);
            }
        }

        private void txtTreatment_TextChanged(object sender, TextChangedEventArgs e)
        {
            var checkstate = check.Checking_information(txtTreatment.Text);
            if (checkstate == true)
            {
                MessageBox.Show("Nieprawidłowy znak!");
                txtTreatment.Text = txtTreatment.Text.Remove(txtTreatment.Text.Length - 1);
            }
        }

        private void txtInformation_TextChanged(object sender, TextChangedEventArgs e)
        {
            var checkstate = check.Checking_information(txtInformation.Text);
            if (checkstate == true)
            {
                MessageBox.Show("Nieprawidłowy znak!");
                txtInformation.Text = txtInformation.Text.Remove(txtInformation.Text.Length - 1);
            }
        }

        private void txtPatientID_TextChanged(object sender, TextChangedEventArgs e)
        {
            var checkstate = check.Checking_numbers(txtPatientID.Text);
            if (checkstate == true)
            {
                MessageBox.Show("Nieprawidłowy znak!");
                txtPatientID.Text = txtPatientID.Text.Remove(txtPatientID.Text.Length - 1);
            }
        }
        

        private void txtGroup_TextChanged(object sender, TextChangedEventArgs e)
        {
            var checkstate = check.Checking_group(txtGroup.Text);
            if (checkstate == true)
            {
                MessageBox.Show("Nieprawidłowy znak!");
                txtGroup.Text = txtGroup.Text.Remove(txtGroup.Text.Length - 1);
            }
        }

        private void txtRh_TextChanged(object sender, TextChangedEventArgs e)
        {
            var checkstate = check.Checking_rh(txtRh.Text);
            if (checkstate == true)
            {
                MessageBox.Show("Nieprawidłowy znak!");
                txtRh.Text = txtRh.Text.Remove(txtRh.Text.Length - 1);
            }
        }

        private void txtMedicine_TextChanged(object sender, TextChangedEventArgs e)
        {
            var checkstate = check.Checking_datainformation(txtMedicine.Text);
            if (checkstate == true)
            {
                MessageBox.Show("Nieprawidłowy znak!");
                txtMedicine.Text = txtMedicine.Text.Remove(txtMedicine.Text.Length - 1);
            }
        }

        private void txtAlergy_TextChanged(object sender, TextChangedEventArgs e)
        {
            var checkstate = check.Checking_datainformation(txtAlergy.Text);
            if (checkstate == true)
            {
                MessageBox.Show("Nieprawidłowy znak!");
                txtAlergy.Text = txtAlergy.Text.Remove(txtAlergy.Text.Length - 1);
            }
        }

        private void txtDisases_TextChanged(object sender, TextChangedEventArgs e)
        {
            var checkstate = check.Checking_datainformation(txtDisases.Text);
            if (checkstate == true)
            {
                MessageBox.Show("Nieprawidłowy znak!");
                txtDisases.Text = txtDisases.Text.Remove(txtDisases.Text.Length - 1);
            }
        }
       

        private void txtAlcohol_TextChanged(object sender, TextChangedEventArgs e)
        {
            var checkstate = check.Checking_confirm(txtAlcohol.Text);
            if (checkstate == true)
            {
                MessageBox.Show("Nieprawidłowy znak!");
                txtAlcohol.Text = txtAlcohol.Text.Remove(txtAlcohol.Text.Length - 1);
            }
        }

        private void txtCigarets_TextChanged(object sender, TextChangedEventArgs e)
        {
            var checkstate = check.Checking_confirm(txtCigarets.Text);
            if (checkstate == true)
            {
                MessageBox.Show("Nieprawidłowy znak!");
                txtCigarets.Text = txtCigarets.Text.Remove(txtCigarets.Text.Length - 1);
            }
        }
 #endregion
    }
}
