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
        Coche _coche = new Coche();//Cuando hago new, c# busca un constructor con los mismos parámetros que he pasado, y lo llamada
                                  //para construir una instancia. 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void VerCocheButton_Click(object sender, RoutedEventArgs e)
        {
            //coche._kilometrosRecorridos = 44; No puedo establecer a un campo porque lo tengo privado.
            //MessageBox.Show(coche._kilometrosRecorridos); No puedo acceder a un campo porque lo tengo privado.
            // coche.KilometrosRecorridos = 55; No puedo, aunque la propiedad sea pública, su setter es privado. 
            MessageBox.Show("Tengo un coche que ha recorrido " + _coche.KilometrosRecorridos 
                + " kilómetros y tiene " + _coche.Gasolina + " litros de gasofa");
        }

        private void Recorrer100Button_Click(object sender, RoutedEventArgs e)
        {
            _coche.Andar100Km();
        }

        private void Recorrer200Button_Click(object sender, RoutedEventArgs e)
        {
            _coche.Andar200Km();
        }
    }
}
