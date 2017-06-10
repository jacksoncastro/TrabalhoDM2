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

namespace TrabalhoDM2.Question10
{
    /// <summary>
    /// Lógica interna para Window10.xaml
    /// </summary>
    public partial class Window10 : Window
    {
        public int FontSizeText { get; set; }

        public Window10()
        {
            InitializeComponent();
        }

        //private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        //{
        //    var slider = sender as Slider;
        //    this.FontSizeText = Int32.Parse(slider.Value.ToString());
        //}
    }
}
