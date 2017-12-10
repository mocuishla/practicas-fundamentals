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

namespace practicas_fundamentals
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Coche _cocheSeleccionado;

        List<Coche> _coches = new List<Coche>();

        public MainWindow()
        {
            _coches.Add(new Coche("azul"));//Lo hago en un solo paso en lugar de en dos como arriba
            _coches.Add(new Coche("rojo"));
            _coches.Add(new Coche("verde"));

            InitializeComponent();

            _cocheSeleccionado = GetCocheSeleccionado();
        }



        private void Recorrer100Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _cocheSeleccionado.Andar(100);
              }
            catch
            {
                MessageBox.Show("Error al andar en coche");
            }

            MessageBox.Show(CrearMensaje());
        }

        public string CrearMensaje()
        {
            return "Tengo un coche " + _cocheSeleccionado.Color + " que ha recorrido " + _cocheSeleccionado.KilometrosRecorridos
                + " kilómetros y tiene " + _cocheSeleccionado.Gasolina + " litros de gasofa";
        }

        private void Recorrer200Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _cocheSeleccionado.Andar(200);
            }
            catch
            {
                MessageBox.Show("Error al andar en coche");
            }
            

            MessageBox.Show(CrearMensaje());
        }

        private void RecorrerButton_Click(object sender, RoutedEventArgs e)
        {
            string texto = DistanciaTextBox.Text;
            int distancia;
            distancia = int.Parse(texto);

            try
            {
                _cocheSeleccionado.Andar(distancia);
            }
            catch
            {
                MessageBox.Show("Error al andar en coche");
            }

            MessageBox.Show(CrearMensaje());
        }

        private void PintarVerdeButton_Click(object sender, RoutedEventArgs e)
        {
            _cocheSeleccionado.CambiarColor("verde");

            MessageBox.Show(CrearMensaje());

        }

        private void PintarButton_Click(object sender, RoutedEventArgs e)
        {
            string texto = ColorTextBox.Text;
            _cocheSeleccionado.CambiarColor(texto);

            MessageBox.Show(CrearMensaje());

        }

        private void MostrarCocheButton_Click(object sender, RoutedEventArgs e)
        {
            Coche cocheSeleccionado = _cocheSeleccionado;

            MessageBox.Show("Ha seleccionado el coche: " + cocheSeleccionado.Color);
        }

        private Coche GetCocheSeleccionado()
        {
            int seleccion = -1;
            if (CocheRadio1.IsChecked == true)
            {
                seleccion = 0;
            }
            else
                if (CocheRadio2.IsChecked == true)
            {
                seleccion = 1;
            }
            else
            {
                seleccion = 2;
            }

            Coche cocheSeleccionado;
            cocheSeleccionado = _coches[seleccion];

            return cocheSeleccionado;
        }

        private void CocheRadio_Checked(object sender, RoutedEventArgs e)
        {
            _cocheSeleccionado = GetCocheSeleccionado();
        }
    }
}
