using Microsoft.Win32;
using System;
using System.Collections;
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
        private void Import(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files (*.txt)|*.txt"; 
            if (openFile.ShowDialog() == true)
            {
                string filePath = openFile.FileName;
                ImportTxt(filePath);
            }
        }
        private void ImportTxt(string filePath) 
        {
            string[] strings = File.ReadAllLines(filePath);
            try
            {
                foreach (string line in strings)
                {
                    string[] component = line.Split(';');
                    if (component.Length == 5)
                    {
                        Modify_Movies movie = new Modify_Movies
                        {

                            Title = component[0],
                            Director = component[1],
                            Producer = component[2],
                            DataCT = component[3]
                        };
                    
                        DateTime releaseDate;
                        if (DateTime.TryParse(component[4], out releaseDate))
                        {
                            movie.ReleaseDate = releaseDate;
                        }

                        Movies.Add(movie);

                    }
                    else {
                        MessageBox.Show("ERROR: please implement full information, for example: DAVE;John Krasinsky;John Krasinsky;10/05/2000");
                    }
                }
            }
            catch(Exception e) 
            {
                MessageBox.Show("ERROR: Change format, for example: DAVE;John Krasinsky;John Krasinsky;10/05/2000");
            }
        
        }
        private void Export(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text Files (*.txt)|*.txt";
            if (saveFile.ShowDialog() == true)
            {
                string filePath = saveFile.FileName;
                ExportTxt(filePath);
            }
        }
        private void ExportTxt(string filePath)
        {
            try
            {
                List<string> strings = new List<string>();
                foreach (Modify_Movies movie in Movies)
                {
                    string line = $"{movie.Title};{movie.Director};{movie.Producer};{movie.DataCT};{movie.ReleaseDate?.ToString() ?? string.Empty}";
                    strings.Add(line);
                }
                File.WriteAllLines(filePath, strings);
            }
            catch(Exception e ) 
            {
                MessageBox.Show($"Error occurred while exporting data: {0}", e.Message);
            }
        }
    }
}
