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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace my_PNET_PR3_1_Z3
{
    /// <summary>
    /// Interaction logic for Modify.xaml
    /// </summary>
    public partial class Modify : Window
    {
        public Modify(Modify_Movies movie)
        {
            InitializeComponent();
            DataContext = movie;
            
        }
        private void Ok(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
