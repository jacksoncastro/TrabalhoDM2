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

namespace TrabalhoDM2.Question5
{
    /// <summary>
    /// Lógica interna para Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {

        public Window5()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            this.Checked.Content = getTextChecked();
        }

        private void CheckBox_Checked_2(object sender, RoutedEventArgs e)
        {
            this.Checked.Content = getTextChecked();
        }

        private void CheckBox_Checked_3(object sender, RoutedEventArgs e)
        {
            this.Checked.Content = getTextChecked();
        }

        private void CheckBox_Checked_4(object sender, RoutedEventArgs e)
        {
            this.Checked.Content = getTextChecked();
        }


        private string getTextChecked()
        {

            var checkeds = new List<String>();

            if ((Boolean) this.Check1.IsChecked)
            {
                checkeds.Add("Check1");
            }
            if ((Boolean) this.Check2.IsChecked)
            {
                checkeds.Add("Check2");
            }
            if ((Boolean) this.Check3.IsChecked)
            {
                checkeds.Add("Check3");
            }
            if ((Boolean) this.Check4.IsChecked)
            {
                checkeds.Add("Check4");
            }
            if (checkeds.Count == 0)
            {
                return "Nenhum check marcado";
            }
            return String.Join(", ", checkeds) + (checkeds.Count == 1 ? " foi marcado" : " foram marcados");
        }
    }
}