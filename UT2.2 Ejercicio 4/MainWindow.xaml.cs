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

namespace UT2._2_Ejercicio_4
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void crearRectangulo(Color c) {
            Rectangle r = new Rectangle();

            r.Fill = new SolidColorBrush(c);
            WpRectangulos.Children.Add(r);
        }

        private void Button_Click_Rojo(object sender, RoutedEventArgs e)
        {
            crearRectangulo(Colors.Red);

        }

        private void Button_Click_Verde(object sender, RoutedEventArgs e)
        {

            crearRectangulo(Colors.Green);
           
        }

        private void Button_Click_Azul(object sender, RoutedEventArgs e)
        {

            crearRectangulo(Colors.Blue);
        }

        private void Button_Click_Negro(object sender, RoutedEventArgs e)
        {

            crearRectangulo(Colors.Black);

        }
    }
}
