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
using System.Text.RegularExpressions;

namespace FF
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


        public void btnSubmit(object sender, RoutedEventArgs e)

        {
            if (txtemail.Text.Length == 0 )
            {
                errormessage.Text = "Enter an email and password";
                txtemail.Focus();
            }
            else if (!Regex.IsMatch(txtemail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                errormessage.Text = "Enter a valid email.";
                txtemail.Select(0, txtemail.Text.Length);
                txtemail.Focus();
            }
            else if (Regex.IsMatch(txtPassword.Password, @"^(.{0,7}|[^0-9]*|[^A-Z])$"))
            {
                errormessage.Text = "Enter a valid password.";
                txtemail.Select(0, txtemail.Text.Length);
                txtPassword.Focus();
            }
            else if(Regex.IsMatch(txtemail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                errormessage.Text = "WELCOME";
                txtemail.Select(0, txtemail.Text.Length);
                HELLO hel = new HELLO();
                hel.ShowDialog();
               
            }

        }
    }
}
