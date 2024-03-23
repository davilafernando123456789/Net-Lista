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
    /// Lógica de interacción para Camiones.xaml
    /// </summary>
    public partial class Camiones : Window
    {
        public Camiones()
        {
            InitializeComponent();
        }

        private void btnListarCamion_Click(object sender, RoutedEventArgs e)
        {
            ListarCamion listarCamion = new ListarCamion();
            listarCamion.ShowDialog();
            this.Close();
        }

        private void btnCrearCamion_Click(object sender, RoutedEventArgs e)
        {
            CrearCamion crearCamion = new CrearCamion();
            crearCamion.ShowDialog();
            this.Close();
        }
    }
}
