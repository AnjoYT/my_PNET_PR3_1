using System;
using System.Collections;
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

namespace my_PNET_PR3_1_Z3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Modify_Movies> Movies { get; } = new ObservableCollection<Modify_Movies>();
        ListBox list;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            list = (ListBox)this.FindName("List");
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            Modify_Movies newMovie = new Modify_Movies();
            Movies.Add(newMovie);

            (new Modify(newMovie)).Show();
        }
        private void Edit(object sender, RoutedEventArgs e)
        {
            (new Modify((Modify_Movies)list.SelectedItem)).Show();
        }
        private void Delete(object sender, RoutedEventArgs e)
        {
            Movies.Remove((Modify_Movies)list.SelectedItem);
        }
    }
}
