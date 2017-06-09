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

namespace TrabalhoDM2.Question6
{
    /// <summary>
    /// Lógica interna para Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
        {
            InitializeComponent();
        }
       
        private void ComboBoxItems_DropDownClosed(object sender, EventArgs e)
        {
            var comboxBox = sender as ComboBox;
            this.LabelComboBoxItem.Content = String.Format("{0} selecionado", comboxBox.Text);
        }
    }
}
