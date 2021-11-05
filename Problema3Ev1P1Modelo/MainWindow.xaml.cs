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

namespace Problema3Ev1P1Modelo
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

        public void crearRectangulo(Color c) {
            Rectangle r = new Rectangle();
            r.Fill = new SolidColorBrush(c);

            wp.Children.Add(r);

        }


        private void Button_Click_rojo(object sender, RoutedEventArgs e)
        {
            crearRectangulo(Colors.Red);
        }

        private void Button_Click_verde(object sender, RoutedEventArgs e)
        {
            crearRectangulo(Colors.Green);
        }

        private void Button_Click_azul(object sender, RoutedEventArgs e)
        {
            crearRectangulo(Colors.Blue);
        }
    }
}
