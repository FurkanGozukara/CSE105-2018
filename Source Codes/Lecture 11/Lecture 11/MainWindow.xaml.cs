using System;
using System.Collections.Generic;
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

namespace Lecture_11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
            System.Globalization.CultureInfo.CurrentCulture = new System.Globalization.CultureInfo("tr-TR");
        }

        private void exTask(string srTxtNumberText)
        {
            decimal dclNumb = 0;
            bool blNumber = decimal.TryParse(srTxtNumberText, out dclNumb);

            if (blNumber == true)
                lstFormatText.Items.Add(dclNumb.ToString("N2"));
        }


        private void btnComposeTextFile_Click(object sender, RoutedEventArgs e)
        {
            string srFileName = txtFileName.Text;

            File.WriteAllText(srFileName + ".txt", txtContent.Text);
        }

        private void btnStringNumberFormat_Click(object sender, RoutedEventArgs e)
        {
            if (radEN.IsChecked == true)
            {
                System.Globalization.CultureInfo.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            }

            if (radTR.IsChecked == true)
            {
                System.Globalization.CultureInfo.CurrentCulture = new System.Globalization.CultureInfo("tr-TR");
            }

            decimal dclNumb = 0;
            bool blNumber = decimal.TryParse(txtNumber.Text, out dclNumb);

            if(blNumber==true)
            lstFormatText.Items.Add(dclNumb.ToString("N2"));
            lstFormatText.Items.Add("currency: "+dclNumb.ToString("N2"));
            lstFormatText.Items.Add("custom 1: " + dclNumb.ToString("0:#.#"));
            lstFormatText.Items.Add("custom 2: " + dclNumb.ToString("0:#.###"));


            lstFormatText.Items.Add("phone 1: " + String.Format("{0:0(###) ###-####}", dclNumb));
        }

        private void exTask_Click(object sender, RoutedEventArgs e)
        {
            var task1 = Task.Factory.StartNew(() => exTask(txtNumber.Text));
        }
    }
}
