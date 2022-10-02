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

namespace Tema2_Imagen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagen_image.Opacity = .9;
        }

        private void opacidadBaja_radioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagen_image.Opacity = .3;
        }

        private void opacidadMedia_radioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagen_image.Opacity = .6;
        }

        private void fill_radioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagen_image.Stretch = Stretch.Fill;
        }

        private void uniform_radioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagen_image.Stretch = Stretch.Uniform;
        }

        private void none_radioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagen_image.Stretch = Stretch.None;
        }

        private void uniformtofill_radioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagen_image.Stretch = Stretch.UniformToFill;
        }
    }
}
