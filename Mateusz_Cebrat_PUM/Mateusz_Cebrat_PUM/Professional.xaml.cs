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
    /// Interaction logic for Professional.xaml
    /// </summary>
    public partial class Professional : Window
    {
       

        public Professional()
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
            var profession2 = txtProfession.Text;
            var practiced2 = txtPractised.Text;
            var disease2 = txtDisease.Text;
            var niuisance2 = txtNuisance.Text;
            var accidents2 = txtAccidents.Text;
            
            

            if (profession2.Length !=0 & practiced2.Length != 0 & disease2.Length != 0 & niuisance2.Length != 0 & accidents2.Length !=0 )
            {
                int patientid = Convert.ToInt16(txtPatientID.Text);

                save.WorkIntervievSave(txtProfession.Text, txtPractised.Text, txtDisease.Text, txtNuisance.Text, txtAccidents.Text,patientid);

                MessageBox.Show("Zapisano pomyślnie");
            
            }

            else
            {
                MessageBox.Show("Brak wypełnionych danych!");
            }

        }

        #region text functions

        private void txtProfession_TextChanged(object sender, TextChangedEventArgs e)
        {
            var checkstate = check.Checking_information(txtProfession.Text);
            if (checkstate == true)
            {
                MessageBox.Show("Nieprawidłowy znak!");
                txtProfession.Text = txtProfession.Text.Remove(txtProfession.Text.Length - 1);
            }
        }

        private void txtPractised_TextChanged(object sender, TextChangedEventArgs e)
        {
            var checkstate = check.Checking_information(txtPractised.Text);
            if (checkstate == true)
            {
                MessageBox.Show("Nieprawidłowy znak!");
                txtPractised.Text = txtPractised.Text.Remove(txtPractised.Text.Length - 1);
            }
        }

        private void txtDisease_TextChanged(object sender, TextChangedEventArgs e)
        {
            var checkstate = check.Checking_information(txtDisease.Text);
            if (checkstate == true)
            {
                MessageBox.Show("Nieprawidłowy znak!");
                txtDisease.Text = txtDisease.Text.Remove(txtDisease.Text.Length - 1);
            }
        }

        private void txtNuisance_TextChanged(object sender, TextChangedEventArgs e)
        {
            var checkstate = check.Checking_information(txtNuisance.Text);
            if (checkstate == true)
            {
                MessageBox.Show("Nieprawidłowy znak!");
                txtNuisance.Text = txtNuisance.Text.Remove(txtNuisance.Text.Length - 1);
            }
        }

        private void txtAccidents_TextChanged(object sender, TextChangedEventArgs e)
        {
            var checkstate = check.Checking_information(txtAccidents.Text);
            if (checkstate == true)
            {
                MessageBox.Show("Nieprawidłowy znak!");
                txtAccidents.Text = txtAccidents.Text.Remove(txtAccidents.Text.Length - 1);
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

        #endregion
    }
}
