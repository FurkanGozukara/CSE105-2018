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
using System.IO;
using System.Globalization;

namespace Lecture_12
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

        private void txtNumber_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "enter a number")
                txtNumber.Text = "";
        }

        private void txtNumber_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text.Length < 1)
                txtNumber.Text = "enter a number";
        }

        CultureInfo TRCulture = new CultureInfo("tr-TR");
        CultureInfo ENCulture = new CultureInfo("en-EN");

        private void btnWriteToFile_Click(object sender, RoutedEventArgs e)
        {
            double dblNumber = 0;

            File.WriteAllText("number.txt", "");
            File.WriteAllText("number2.txt", "");
            File.WriteAllText("number3.txt", "");
            List<string> lstAllLines = new List<string>();

            for (int i = 0; i < 10; i++)
            {
                try
                {
                    dblNumber = Convert.ToDouble(txtNumber.Text, ENCulture);
                }
                catch (Exception E)
                {
                    MessageBox.Show("Error: " + E.Message.ToString());
                    return;
                }

                string srEngText = $"N{i} - English - input text: "
                    + txtNumber.Text +
                    " , output number: "
                    + dblNumber.ToString($"N{i}", ENCulture);

                w1(srEngText, true);
                lstAllLines.Add(srEngText);

                try
                {
                    dblNumber = Convert.ToDouble(txtNumber.Text, TRCulture);
                }
                catch (Exception E)
                {
                    MessageBox.Show("Error: " + E.Message.ToString());
                    return;
                }

                string srTrText = $"N{i} - Turkish - input text: "
                + txtNumber.Text +
                " , output number: "
                + dblNumber.ToString($"N{i}", TRCulture);

                w1(srTrText, true);
                lstAllLines.Add(srTrText);
            }

            File.WriteAllLines("number3.txt", lstAllLines);
       
            //w2(dblNumber.ToString("N2"), true);
        }

        private void w1(string srNumber, bool blAppend = false)
        {
            StreamWriter swWrite = new StreamWriter("number.txt", blAppend);
            swWrite.AutoFlush = true;
            swWrite.WriteLine(srNumber);
            swWrite.Close();

            if (blAppend == true)
            {
                File.AppendAllText("number2.txt", srNumber + Environment.NewLine);
            }
            else
            {
                File.WriteAllText("number2.txt", srNumber + Environment.NewLine);
            }
        }

        private void w2(string srNumber, bool blAppend = false)
        {   //after leaving USING code block {} all objects are automatically disposed and closed
            using (StreamWriter swWrite = new StreamWriter("number.txt", blAppend))
            {
                swWrite.AutoFlush = true;
                swWrite.WriteLine(srNumber);
            }
        }

        private void readnumbertxt_Click(object sender, RoutedEventArgs e)
        {
            if (!File.Exists("number.txt"))
                return;

            lstWrittenLines.Items.Clear();

            using (StreamReader reader = new StreamReader("number.txt"))
            {                      
                while (true)
                {
                    string srLine = reader.ReadLine();
                    if (srLine == null)
                        break;
                    lstWrittenLines.Items.Add(srLine);                 
                }
            }
        }

        private void readAllLines_Click(object sender, RoutedEventArgs e)
        {
            if (!File.Exists("number.txt"))
                return;

            lstWrittenLines.Items.Clear();

            //method 1. reads a single line each for each turn
            foreach (var vrLine in File.ReadLines("number.txt"))
            {
                lstWrittenLines.Items.Add(vrLine);
            }

            //method 2. reads all lines into memory then enters the foreach
            foreach (var vrLine in File.ReadAllLines("number.txt"))
            {
                lstWrittenLines.Items.Add(vrLine);
            }

            //method 2 equilavent
            var vrList = File.ReadAllLines("number.txt");
            foreach (var vritem in vrList)
            {
                lstWrittenLines.Items.Add(vritem);
            }  
        }
    }
}
