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
    /// Interaction logic for Login.xaml
    /// </summary>8
    /// 

        ///login mateusz
        /// hasło 123

    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bntSubmit_Click(object sender, RoutedEventArgs e)
        {
            var Login = txtName.Text;
            var Password = txtPassword.Password;

            if (Login.Length != 0)
            {

                if (Password.Length != 0)
                {

                    using (Kartoteka_Entities1 context = new Kartoteka_Entities1())
                    {

                        var user = context.Nurse.FirstOrDefault(w => w.login == Login);
                        if (user != null)
                        {
                            var hasło = context.Nurse.FirstOrDefault(w => w.password == Password);
                            if (hasło != null)
                            {
                                MainWindow main = new MainWindow();
                                main.Show();
                                this.Close();

                            }
                            else
                            {
                                MessageBox.Show("Login lub hasło nierawidłowe!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Login lub hasło nierawidłowe!");
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Brak hasła!");
                }

            }
            else

            {
                MessageBox.Show("Brak loginu!");
            }
        }
    }
}
