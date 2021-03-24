using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Contactor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class DataObject
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string Mail { get; set; }
            public string Phone { get; set; }
        }

        public MainWindow()
        {
            InitializeComponent();
            var list = new ObservableCollection<DataObject>();
            list.Add(new DataObject() { FirstName = "John", LastName = "Doe", Age = 35, Mail = "john.doe@example.com", Phone = "0101 010 101" });
            this.ContactList.ItemsSource = list;
        }
        
    }
}
