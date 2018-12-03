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

namespace Lecture_11___2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Dictionary<Int64, ogrenci> dicOgrenciler = new Dictionary<long, ogrenci>();

        private void addOgrenci_Click(object sender, RoutedEventArgs e)
        {
            ogrenci myOgrenci = new ogrenci();
            try
            {
                myOgrenci.irOgrenciNo = Convert.ToInt64(txtStudenNo.Text);
            }
            catch (Exception E)
            {
                MessageBox.Show("Error: " + E.Message.ToString());
                return;
            }

            myOgrenci.srOgrenciName = txtStudentName.Text;

            double outResult = 0;

          if(!double.TryParse(txtVize.Text, out outResult))
            {
                MessageBox.Show("You have entered incorrect value for the midterm score!");
                return;
            }

            myOgrenci.dblVizeNot = outResult;
        }
    }
}
