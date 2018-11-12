using System;
using System.Collections.Generic;
using System.Globalization;
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

            if(srPassword.Contains(":"))
            {
                MessageBox.Show("error you can not use : in password");
                return;
            }

            List<string> lstNotAllowedCharacters =
                new List<string> { "$", ":", "+" };

            foreach (var item in lstNotAllowedCharacters)
            {
                if (srPassword.Contains(item))
                {
                    MessageBox.Show("error you can not use "+ item + " in password");
                    return;
                }
            }



            string srTextToWrite = srUserName + ":" + srPassword + "\r\n";

            File.WriteAllText("fresh_info.txt", srTextToWrite, Encoding.UTF8);

            File.AppendAllText("historic_info.txt", srTextToWrite, Encoding.UTF8);

            readText();
        }

        private void btnReadText_Click(object sender, RoutedEventArgs e)
        {
            readText();
        }

        private void readText()
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

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            string tempExample = "I always go: to the s:chool: everyday";
            string[] lstSplit = tempExample.Split(':');
            string[] lstSplit2 = tempExample.Split(' ');
            string[] lstSplit3 = tempExample.Split('a');
            string[] lstSplit4 = tempExample.Split('c');

            string elemt2 = lstSplit2[1];

            Dictionary<string, string> dicUsers = new Dictionary<string, string>();

            if (File.Exists("historic_info.txt"))
            {
                foreach (var vrLine in File.ReadLines("historic_info.txt"))
                {
                    string srUserName = vrLine.Split(':')[0];
                    string srPassword = vrLine.Split(':')[1];

                    if (dicUsers.Keys.Contains(srUserName) == false)
                    {
                        dicUsers.Add(srUserName, srPassword);
                    }
                }
            }

            string srPassofFurkan7 = dicUsers["furkan7"];

            if (dicUsers.ContainsKey(txttextTocheck.Text))
            {
                MessageBox.Show("this user already exists");
            }
            else
                MessageBox.Show("this username is free");
            //here we loop through the items of dictionary dicUsers
            foreach (var vrItem in dicUsers)
            {
                string srKey = vrItem.Key;
                string srPass = vrItem.Value;

                //this is used to generate a random number
                Random rand = new Random();

                string srTextFileName = srKey + ".txt";
                //rand.Next generates a random number between the given range
                string srTextToWRite = rand.Next(100, 1000).ToString() + Environment.NewLine;
               
                File.AppendAllText(srTextFileName, srTextToWRite);
            }

        }

        private void btnExample_Click(object sender, RoutedEventArgs e)
        {
            string s1 = "Furkan";
            string s2 = "fuRkan";

            if(s1==s2)
            {
                MessageBox.Show("s1 is equal to s2 - without lower");
            }

            CultureInfo myTurkishCulture = new CultureInfo("TR-tr");

            s1 = s1.ToLower(myTurkishCulture);
            s2 = s2.ToLower(myTurkishCulture);

            if (s1 == s2)
            {
                MessageBox.Show("s1 is equal to s2 - with lower case");
            }

            string s3 = "  Furkan 3";
            string s4 = " Furkan 3 ";

            if (s3 == s4)
            {
                MessageBox.Show("s3 is equal to s4 - without trimming");
            }

            s3 = s3.Trim();//removes leading and trailing white space (in front and at the end)
            s4 = s4.Trim();

            if (s3 == s4)
            {
                MessageBox.Show("s3 is equal to s4 - with trimming");
            }

        }
    }
}
