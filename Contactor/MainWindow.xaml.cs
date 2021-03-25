using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
using LiteDB;
using Microsoft.Win32;

namespace Contactor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string DBPath = String.Empty;
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
            if (UserPreferences.Default.LastDBPath != "")
            {
                this.Title = UserPreferences.Default.LastDBPath;
            }
        /// var list = new ObservableCollection<DataObject>();
        /// list.Add(new DataObject() { FirstName = "John", LastName = "Doe", Age = 35, Mail = "john.doe@example.com", Phone = "0101 010 101" });
        /// this.ContactList.ItemsSource = list;
        
    }

        private void AddUserBtn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void NewDB_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Create New DataBase";
            saveFileDialog.DefaultExt = ".db";
            saveFileDialog.Filter = "Data Base File (.db) | *.db";

            if (saveFileDialog.ShowDialog() == true)
                Console.WriteLine("coucou");
        }

        private void OpenDB_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open DataBase";
            openFileDialog.DefaultExt = ".db";
            openFileDialog.Filter = "Data Base File (.db) | *.db";
            if (openFileDialog.ShowDialog() == true)
            {
                UserPreferences.Default.LastDBPath = openFileDialog.FileName;
            }

        }
    }
}
