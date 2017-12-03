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

        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void Recorrer100Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _coche.Andar(100);
            }
            catch
            {
                MessageBox.Show("Error al andar en coche");
            }

            MessageBox.Show(CrearMensaje());
        }

        public string CrearMensaje()
        {
            return "Tengo un coche " + _coche.Color + " que ha recorrido " + _coche.KilometrosRecorridos
                + " kilómetros y tiene " + _coche.Gasolina + " litros de gasofa";
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



        //TODO: Un botón que se llame "pintar de verde" y que me pinte el coche de verde.
        //TODO: Otro botón que  se llame "pintar" y que me pinte el color con lo que el usuario ponga en una caja de texto. 
        //TODO: Si se me acaba la gasolina e intento andar, que salte una excepción en el programa. 
    }
}
