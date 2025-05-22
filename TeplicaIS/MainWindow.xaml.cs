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
using TeplicaIS.Database;

namespace TeplicaIS
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DBadapter dbadapter = new DBadapter();

        public MainWindow()
        {
            InitializeComponent();
            dbadapter.Conn();

        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            List<Person> list = dbadapter.GetPersonList();

            foreach (Person person in list)
            {
                if(tb_login.Text == person.name && tb_pass.Text == person.password)
                {
                    
                    MessageBox.Show("Authorized!");
                    return;
                }
            }
            MessageBox.Show("NOT Authorized!");
        }

        private void btn_registr_Click(object sender, RoutedEventArgs e)
        {
            string str = tb_login.Text;
            MessageBox.Show(str);


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
           
            Person person = new Person();
            person.name = "ivan";
            person.surname = "ivanov";
            person.patronymic = "ivanovich";
            person.login = "mail@mail.com";
            person.password = "password";
            person.role_id = 1;

            //dbadapter.InsertPerson(person);

           


        }
    }
}
