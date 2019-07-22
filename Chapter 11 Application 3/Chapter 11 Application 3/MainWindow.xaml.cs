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

namespace Chapter_11_Application_3
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Class1 klasa;
        public MainWindow()
        {
            InitializeComponent();
            klasa = new Class1();
            Console.WriteLine(klasa.i);
            klasa.zmieni();
            Console.WriteLine(klasa.i);

        }
    }
}
