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

namespace Bank_Management_System
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

        private void click_new_form(object sender, RoutedEventArgs e)
        {
            string password,name;
            password = psw_user.Password;
            name = name_user.Text;
            if (name == "abc" && password == "123" )
            {
                Window1 wn = new Window1();
                wn.Show();
                this.Close();
            }
            else
            {
                txb_msg.Text = "Wrong Password. Try Again!!";
            }

        } 
    }
}
