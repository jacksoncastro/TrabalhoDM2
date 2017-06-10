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

namespace TrabalhoDM2.Question13
{
    /// <summary>
    /// Lógica interna para Window13.xaml
    /// </summary>
    public partial class Window13 : Window
    {

        protected class ListViewPersonVO
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public ListViewPersonVO(string Name, int Age)
            {
                this.Name = Name;
                this.Age = Age;
            }
        }

        public Window13()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.TextBox_Name.Text.Equals(String.Empty))
            {
                MessageBox.Show("The name field is required");
            } else
            {
                this.listView.Items.Add(new ListViewPersonVO(this.TextBox_Name.Text, Int32.Parse(this.Slide_Age.Value.ToString())));
                this.TextBox_Name.Text = "";
                this.Slide_Age.Value = 1;
            }
        }
    }
}
