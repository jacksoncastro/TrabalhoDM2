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

namespace TrabalhoDM2.Question2
{
    /// <summary>
    /// Lógica interna para Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        private int count = 0;
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Counter.Content = String.Format("Estamos em {0}!", ++count);
        }
    }
}
