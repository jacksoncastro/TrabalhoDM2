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

namespace TrabalhoDM2.Question4
{
    /// <summary>
    /// Lógica interna para Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void TextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (this.SelectedLabel != null)
            {
                var TextBoxSelected = sender as TextBox;
                if (TextBoxSelected.Text.Equals(String.Empty))
                {
                    this.SelectedLabel.Content = "Digite um texto e selecione um trecho";
                } else if (TextBoxSelected.SelectedText.Equals(String.Empty))
                {
                    this.SelectedLabel.Content = "Vamos lá, agora só selecionar o texto";
                } else
                {
                    this.SelectedLabel.Content = TextBoxSelected.SelectedText;
                }
            }
        }
    }
}
