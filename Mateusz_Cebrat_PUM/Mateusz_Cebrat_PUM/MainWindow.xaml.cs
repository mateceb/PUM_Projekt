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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mateusz_Cebrat_PUM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
         
        public MainWindow()
        {
            InitializeComponent();
        }

        Database_service save = new Database_service();
        Datavalidation_service check = new Datavalidation_service();

        private void bntFirst_Click(object sender, RoutedEventArgs e)
        {
            

            string name = txtName.Text;
            if (name.Length == 0)
            {
            First first = new First();
            first.Show();
            this.Close();
            }
            else
            {
                int doctorId = Convert.ToInt16(txtDoctorID.Text);
                save.patientsSave(txtName.Text, txtSurname.Text, txtPesel.Text, txtSex.Text, txtBirth.Text, txtAdress.Text, txtCity.Text,doctorId);
                First first = new First();
                first.Show();
                this.Close();
            }
            
            
        }

        private void bntProfessional_Click(object sender, RoutedEventArgs e)
        {
            

            string name = txtName.Text;
            if (name.Length == 0)
            {
                Professional profesionald = new Professional();
                profesionald.Show();
                this.Close();
            }
            else
            {
                int doctorId = Convert.ToInt16(txtDoctorID.Text);
                save.patientsSave(txtName.Text, txtSurname.Text, txtPesel.Text, txtSex.Text, txtBirth.Text, txtAdress.Text, txtCity.Text,doctorId);
                Professional profesionald = new Professional();
                profesionald.Show();
                this.Close();
            }
            
        }

        private void bntBefore_Click(object sender, RoutedEventArgs e)
        {
            
            string name = txtName.Text;
            if (name.Length == 0)
            {
                
                Before visits = new Before();
                visits.Show();
                this.Close();
            }
            else
            {
                int doctorId = Convert.ToInt16(txtDoctorID.Text);
                save.patientsSave(txtName.Text, txtSurname.Text, txtPesel.Text, txtSex.Text, txtBirth.Text, txtAdress.Text, txtCity.Text,doctorId);
                Before before = new Before();
                before.Show();
                this.Close();
            }

           
        }

        #region text functions
        private void txtPesel_TextChanged(object sender, EventArgs e)
        {
          var checkstate = check.Checking_numbers(txtPesel.Text);
            if (checkstate == true)
            {
                MessageBox.Show("Nieprawidłowy znak!");
                txtPesel.Text = txtPesel.Text.Remove(txtPesel.Text.Length - 1);
            }
        }

        private void txtBirth_TextChanged(object sender, TextChangedEventArgs e)
        {
            var checkstate = check.Checking_data(txtBirth.Text);
            if (checkstate == true)
            {
                MessageBox.Show("Nieprawidłowy znak!");
                txtBirth.Text = txtBirth.Text.Remove(txtBirth.Text.Length - 1);
            }
        }

        private void txtSex_TextChanged(object sender, TextChangedEventArgs e)
        {
            var checkstate = check.Checking_sex(txtSex.Text);
            if (checkstate == true)
            {
                MessageBox.Show("Nieprawidłowy znak!");
                txtSex.Text = txtSex.Text.Remove(txtSex.Text.Length - 1);
            }
        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            var checkstate = check.Checking_letters(txtName.Text);
            if (checkstate == true)
            {
                MessageBox.Show("Nieprawidłowy znak!");
                txtName.Text = txtName.Text.Remove(txtName.Text.Length - 1);
            }
        }

        private void txtSurname_TextChanged(object sender, TextChangedEventArgs e)
        {
            var checkstate = check.Checking_letters(txtSurname.Text);
            if (checkstate == true)
            {
                MessageBox.Show("Nieprawidłowy znak!");
                txtSurname.Text = txtSurname.Text.Remove(txtSurname.Text.Length - 1);
            }           
        }

        private void txtAdress_TextChanged(object sender, TextChangedEventArgs e)
        {
            var checkstate = check.Checking_adress(txtAdress.Text);
            if (checkstate == true)
            {
                MessageBox.Show("Nieprawidłowy znak!");
                txtAdress.Text = txtAdress.Text.Remove(txtAdress.Text.Length - 1);
            }
        }

        private void txtCity_TextChanged(object sender, TextChangedEventArgs e)
        {
            var checkstate = check.Checking_letters(txtCity.Text);
            if (checkstate == true)
            {
                MessageBox.Show("Nieprawidłowy znak!");
                txtCity.Text = txtCity.Text.Remove(txtCity.Text.Length - 1);
            }
        }

       

        private void txtDoctorID_TextChanged(object sender, TextChangedEventArgs e)
        {
            var checkstate = check.Checking_numbers(txtDoctorID.Text);
            if (checkstate == true)
            {
                MessageBox.Show("Nieprawidłowy znak!");
                txtDoctorID.Text = txtDoctorID.Text.Remove(txtDoctorID.Text.Length - 1);
            }
        }
        #endregion
    }
}
