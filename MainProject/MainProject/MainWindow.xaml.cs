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
using System.Data;
using System.Data.Entity;
using System.ComponentModel;
//using ModirUC;

namespace MainProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Model1Container db = new Model1Container();      
        public MainWindow()
        {
            InitializeComponent();          
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            string user = txt1.Text;
            string pass = txt2.Password;
            var q = (from p in db.accesses
                     where p.username == user && p.password == pass
                     select p.work).SingleOrDefault();
            if (q == "modir")
            {
              modirpage.Visibility = Visibility.Visible;
            }
            else if (q == "nazem")
            {
              nazempage.Visibility = Visibility.Visible;
            }
            lbl1.Visibility = Visibility.Collapsed;
            lbl2.Visibility = Visibility.Collapsed;
            lbl3.Visibility = Visibility.Collapsed;
            lbl4.Visibility = Visibility.Collapsed;
            txt1.Visibility = Visibility.Collapsed;
            txt2.Visibility = Visibility.Collapsed;
            btn2.Visibility = Visibility.Collapsed;
        }
    }
}
