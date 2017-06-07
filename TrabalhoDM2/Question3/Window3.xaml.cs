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
    /// Lógica interna para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private Button DynamicButton = null;
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.DynamicButton != null)
            {
                this.grid.Children.Remove(this.DynamicButton);
            }
            this.DynamicButton = new Button();
            DynamicButton.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
            DynamicButton.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            DynamicButton.Content = this.TextBoxMessage.Text;
            DynamicButton.AddHandler(Button.ClickEvent, new RoutedEventHandler(ButtonDynamic_Click));
            this.grid.Children.Add(DynamicButton);
        }

        private void ButtonDynamic_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            MessageBox.Show("Clique do botão " + button.Content.ToString() + "!");
        }
    }
}
