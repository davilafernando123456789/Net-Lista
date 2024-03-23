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
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnSalida_Click(object sender, RoutedEventArgs e)
        {
            Salida salida = new Salida();
            salida.Show();
            this.Close();
        }

        private void btnCamiones_Click(object sender, RoutedEventArgs e)
        {
            Camiones camiones = new Camiones();
            camiones.Show();
            this.Close();
        }

        private void btnSalidas_Click(object sender, RoutedEventArgs e)
        {
            ListarSalidas listarsalidas = new ListarSalidas();
            listarsalidas.Show();
            this.Close();
        }
    }
}
