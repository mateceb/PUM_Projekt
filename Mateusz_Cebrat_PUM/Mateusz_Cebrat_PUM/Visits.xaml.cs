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
    /// Interaction logic for Before.xaml
    /// </summary>
    public partial class Before : Window
    {
        public Before()
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
            int patientID = Convert.ToInt16(txtPatientID.Text); 
            
            int doctorID = Convert.ToInt16(txtDoctor.Text); 
            var date = txtDate.Text;
            var time = txtTime.Text;
            var pressure = txtPressure.Text;
            var pulse = txtPulse.Text;
            var temperature = txtTemperature.Text;
            var symptoms = txtSymptoms.Text;
            var diagnosis = txtDiagnosis.Text;
            var recommedations = txtRecommendations.Text;
            var medicines = txtMedicines.Text;
            var information = txtInformations.Text;

            if ( date.Length != 0 & time.Length != 0 & pressure.Length != 0 & pulse.Length != 0 & temperature.Length != 0  & symptoms.Length !=0 & diagnosis.Length !=0 & recommedations.Length !=0 & medicines.Length != 0 & information.Length !=0 )
            {
                save.VisitsSave(txtDate.Text, txtTime.Text, txtPressure.Text, txtPulse.Text, txtTemperature.Text, txtSymptoms.Text, txtDiagnosis.Text, txtRecommendations.Text, txtMedicines.Text, txtInformations.Text,patientID,doctorID);

                MessageBox.Show("Zapisano pomyślnie");
            
            }
            else
            {
                MessageBox.Show("Brak wypełnionych danych!");
            }
            
        }

        #region text functions

        private void txtDoctor_TextChanged(object sender, TextChangedEventArgs e)
        {
            var checkstate = check.Checking_numbers(txtDoctor.Text);
            if (checkstate == true)
            {
                MessageBox.Show("Nieprawidłowy znak!");
                txtDoctor.Text = txtDoctor.Text.Remove(txtDoctor.Text.Length - 1);
            }
        }

        private void txtDate_TextChanged(object sender, TextChangedEventArgs e)
        {
            var checkstate = check.Checking_data(txtDate.Text);
            if (checkstate == true)
            {
                MessageBox.Show("Nieprawidłowy znak!");
                txtDate.Text = txtDate.Text.Remove(txtDate.Text.Length - 1);
            }
        }

        private void txtTime_TextChanged(object sender, TextChangedEventArgs e)
        {
            var checkstate = check.Checking_time(txtTime.Text);
            if (checkstate == true)
            {
                MessageBox.Show("Nieprawidłowy znak!");
                txtTime.Text = txtTime.Text.Remove(txtTime.Text.Length - 1);
            }
        }

        private void txtPressure_TextChanged(object sender, TextChangedEventArgs e)
        {
            var checkstate = check.Checking_measurements(txtPressure.Text);
            if (checkstate == true)
            {
                MessageBox.Show("Nieprawidłowy znak!");
                txtPressure.Text = txtPressure.Text.Remove(txtPressure.Text.Length - 1);
            }
        }

        private void txtPulse_TextChanged(object sender, TextChangedEventArgs e)
        {
            var checkstate = check.Checking_measurements(txtPulse.Text);
            if (checkstate == true)
            {
                MessageBox.Show("Nieprawidłowy znak!");
                txtPulse.Text = txtPulse.Text.Remove(txtPulse.Text.Length - 1);
            }
        }

        private void txtTemperature_TextChanged(object sender, TextChangedEventArgs e)
        {
            var checkstate = check.Checking_measurements(txtTemperature.Text);
            if (checkstate == true)
            {
                MessageBox.Show("Nieprawidłowy znak!");
                txtTemperature.Text = txtTemperature.Text.Remove(txtTemperature.Text.Length - 1);
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

       
        private void txtSymptoms_TextChanged(object sender, TextChangedEventArgs e)
        {
            var checkstate = check.Checking_information(txtSymptoms.Text);
            if (checkstate == true)
            {
                MessageBox.Show("Nieprawidłowy znak!");
                txtSymptoms.Text = txtSymptoms.Text.Remove(txtSymptoms.Text.Length - 1);
            }
        }

        private void txtDiagnosis_TextChanged(object sender, TextChangedEventArgs e)
        {
            var checkstate = check.Checking_information(txtDiagnosis.Text);
            if (checkstate == true)
            {
                MessageBox.Show("Nieprawidłowy znak!");
                txtDiagnosis.Text = txtDiagnosis.Text.Remove(txtDiagnosis.Text.Length - 1);
            }
        }

        private void txtRecommendations_TextChanged(object sender, TextChangedEventArgs e)
        {
            var checkstate = check.Checking_information(txtRecommendations.Text);
            if (checkstate == true)
            {
                MessageBox.Show("Nieprawidłowy znak!");
                txtRecommendations.Text = txtRecommendations.Text.Remove(txtRecommendations.Text.Length - 1);
            }
        }

        private void txtMedicines_TextChanged(object sender, TextChangedEventArgs e)
        {
            var checkstate = check.Checking_information(txtMedicines.Text);
            if (checkstate == true)
            {
                MessageBox.Show("Nieprawidłowy znak!");
                txtMedicines.Text = txtMedicines.Text.Remove(txtMedicines.Text.Length - 1);
            }
        }

        private void txtInformations_TextChanged(object sender, TextChangedEventArgs e)
        {
            var checkstate = check.Checking_information(txtInformations.Text);
            if (checkstate == true)
            {
                MessageBox.Show("Nieprawidłowy znak!");
                txtInformations.Text = txtInformations.Text.Remove(txtInformations.Text.Length - 1);
            }
        }
        #endregion
    }
}
