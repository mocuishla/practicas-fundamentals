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
        Coche _coche = new Coche("azul");//Cuando hago new, c# busca un constructor con los mismos parámetros que he pasado, y lo llamada
                                         //para construir una instancia. 

        List<Coche> _coches = new List<Coche>();

        public MainWindow()
        {
            InitializeComponent();

            //Coche coche = new Coche("azul");
            //_coches.Add(coche);

            _coches.Add(new Coche("azul"));//Lo hago en un solo paso en lugar de en dos como arriba
            _coches.Add(new Coche("rojo"));
            _coches.Add(new Coche("verde"));

           // Coche coche = _coches[1];

        }



        private void Recorrer100Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                GetCocheSeleccionado().Andar(100);
              }
            catch
            {
                MessageBox.Show("Error al andar en coche");
            }

            MessageBox.Show(CrearMensaje());
        }

        public string CrearMensaje()
        {
            Coche cocheSeleccionado = GetCocheSeleccionado();

            return "Tengo un coche " + cocheSeleccionado.Color + " que ha recorrido " + cocheSeleccionado.KilometrosRecorridos
                + " kilómetros y tiene " + cocheSeleccionado.Gasolina + " litros de gasofa";
        }

        private void Recorrer200Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _coche.Andar(200);
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
                _coche.Andar(distancia);
            }
            catch
            {
                MessageBox.Show("Error al andar en coche");
            }

            MessageBox.Show(CrearMensaje());
        }

        private void PintarVerdeButton_Click(object sender, RoutedEventArgs e)
        {
            _coche.CambiarColor("verde");

            MessageBox.Show(CrearMensaje());

        }

        private void PintarButton_Click(object sender, RoutedEventArgs e)
        {
            string texto = ColorTextBox.Text;
            _coche.CambiarColor(texto);

            MessageBox.Show(CrearMensaje());

        }

        private void MostrarCocheButton_Click(object sender, RoutedEventArgs e)
        {
            Coche cocheSeleccionado = GetCocheSeleccionado();

            MessageBox.Show("Ha seleccionado el coche: " + cocheSeleccionado.Color);
        }

        private Coche GetCocheSeleccionado()
        {
            int seleccion = -1;
            if (CocheAzulRadio.IsChecked == true)
            {
                seleccion = 0;
            }
            else
                if (CocheRojoRadio.IsChecked == true)
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

        private void MOstrarPrimerCocheButton_Click(object sender, RoutedEventArgs e)
        {
            Coche primerCoche = GetCocheSeleccionado();
            MessageBox.Show(primerCoche.Color);
        }
    }
}
