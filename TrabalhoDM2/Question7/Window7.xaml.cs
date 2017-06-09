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

namespace TrabalhoDM2.Question7
{
    /// <summary>
    /// Lógica interna para Window7.xaml
    /// </summary>
    public partial class Window7 : Window
    {
        protected class ListViewVO
        {
            public int Id { get; set; }
            public bool IsChecked { get; set; }
            public string Value { get; set; }

            public ListViewVO(int id, Boolean isChecked, string value)
            {
                this.Id = id;
                this.IsChecked = isChecked;
                this.Value = value;
            }
        }

        public Window7()
        {
            InitializeComponent();

            this.listView.Items.Add(new ListViewVO(1, true, "Sou um item que está marcado"));
            this.listView.Items.Add(new ListViewVO(2, false, "Estou desmarcado"));
            this.listView.Items.Add(new ListViewVO(3, true, "Também estou marcado"));
        }
    }
}
