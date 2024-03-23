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

namespace Semana2
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Inicie sesion porfavor.");
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtPassword.Password;

            // Verificar las credenciales del usuario (ejemplo: usuario=admin, password=123)
            if (usuario == "jose" && password == "1234")
            {
                Menu menu = new Menu();
                menu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Por favor, inténtelo de nuevo.");
            }
        }
    }
}
