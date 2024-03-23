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
    public partial class ListarSalidas : Window
    {
        // Clase para representar una salida
        public class Salida
        {
            public string Fecha { get; set; }
            public string Peso { get; set; }
            public string TipoAuto { get; set; }
            public string NombreTransportista { get; set; }
            public string PesoIngreso { get; set; }
            public string PesoSalida { get; set; }
            public string FechaYHora { get; set; }
        }

        // Lista de salidas (datos de ejemplo)
        private List<Salida> listaSalidas = new List<Salida>
        {
            new Salida { Fecha = "2024-03-23", Peso = "500 kg", TipoAuto = "Ferrar", NombreTransportista = "Jose", PesoIngreso = "400 kg", PesoSalida = "480 kg", FechaYHora = "2024-03-23 10:30:00" },
            new Salida { Fecha = "2024-02-23", Peso = "70 kg", TipoAuto = "Hyunday", NombreTransportista = "Davila", PesoIngreso = "400 kg", PesoSalida = "480 kg", FechaYHora = "2024-02-23 10:30:00" },
            new Salida { Fecha = "2024-01-23", Peso = "20 kg", TipoAuto = "Xiaomi", NombreTransportista = "Bravo", PesoIngreso = "400 kg", PesoSalida = "480 kg", FechaYHora = "2024-01-23 10:30:00" },
            // Agrega más salidas de ejemplo según sea necesario
        };

        public ListarSalidas()
        {
            InitializeComponent();

            // Establecer la lista de salidas como origen de datos para el DataGrid
            dataGrid.ItemsSource = listaSalidas;
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            // Obtener las fechas seleccionadas en los DatePicker
            DateTime fechaInicio = datePickerInicio.SelectedDate ?? DateTime.MinValue;
            DateTime fechaFin = datePickerFin.SelectedDate ?? DateTime.MaxValue;

            // Filtrar las salidas según las fechas seleccionadas
            List<Salida> salidasFiltradas = new List<Salida>();
            foreach (var salida in listaSalidas)
            {
                // Convertir la fecha de string a DateTime para comparar
                DateTime fechaSalida = DateTime.Parse(salida.Fecha);
                if (fechaSalida >= fechaInicio && fechaSalida <= fechaFin)
                {
                    salidasFiltradas.Add(salida);
                }
            }

            // Actualizar el origen de datos del DataGrid con las salidas filtradas
            dataGrid.ItemsSource = salidasFiltradas;
        }
    }
}