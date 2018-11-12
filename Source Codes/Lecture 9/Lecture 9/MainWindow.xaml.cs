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

namespace Lecture_9
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

        private void btnWrite_Click(object sender, RoutedEventArgs e)
        {
            string srUserName = txtUserName.Text;
            string srPassword = txtPassword.Password.ToString();

            string srTextToWrite = srUserName + ":" + srPassword + "\n";

            File.WriteAllText("fresh_info.txt", srTextToWrite, Encoding.UTF8);

            File.AppendAllText("historic_info.txt", srTextToWrite, Encoding.UTF8);
        }

        private void btnReadText_Click(object sender, RoutedEventArgs e)
        {
            lstFresh.Items.Clear();
            lstHistoric.Items.Clear();

            if (File.Exists("fresh_info.txt"))
            {
                foreach (var vrLine in File.ReadLines("fresh_info.txt"))
                {
                    if (vrLine.Length > 1)
                    {
                        lstFresh.Items.Add(vrLine);
                    }
                }
            }

            if (File.Exists("historic_info.txt"))
            {
                string[] tempHistoric = File.ReadAllLines("historic_info.txt");

                foreach (string srLine in tempHistoric)
                {
                    lstHistoric.Items.Add(srLine);
                }
            }
        }
    }
}
