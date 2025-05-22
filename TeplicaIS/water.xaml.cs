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

namespace TeplicaIS
{
    /// <summary>
    /// Логика взаимодействия для water.xaml
    /// </summary>

    public partial class water : Page
    {
        bool flagValve = false;
        bool flagCan = false;
        bool flagBarrel = false;
        bool flagHum = false;
        public water()
        {
            InitializeComponent();
        }

        public void valve_Click(object sender, RoutedEventArgs e)
        {
            flagValve = !flagValve;

            if (flagValve)
            {
                Uri uri = new Uri("pack://application:,,,/images/water_valve.png");
                img_water_valve.Source = new BitmapImage(uri);
            }
            else
            {
                Uri uri = new Uri("pack://application:,,,/images/water_valve2.png");
                img_water_valve.Source = new BitmapImage(uri);
            }



        }

        public void can_Click(object sender, RoutedEventArgs e)
        {
            flagCan = !flagCan;

            if (flagCan)
            {
                Uri uri = new Uri("pack://application:,,,/images/water_can.png");
                img_water_can.Source = new BitmapImage(uri);
            }
            else
            {
                Uri uri = new Uri("pack://application:,,,/images/water_can2.png");
                img_water_can.Source = new BitmapImage(uri);
            }



        }

        public void barrel_Click(object sender, RoutedEventArgs e)
        {

            flagBarrel = !flagBarrel;

            if (flagBarrel)
            {
                Uri uri = new Uri("pack://application:,,,/images/water_barrel.png");
                img_water_barrel.Source = new BitmapImage(uri);
            }
            else
            {
                Uri uri = new Uri("pack://application:,,,/images/water_barrel2.png");
                img_water_barrel.Source = new BitmapImage(uri);
            }

        }

        public void hum_Click(object sender, RoutedEventArgs e)
        {
            flagHum = !flagHum;

            if (flagHum)
            {
                Uri uri = new Uri("pack://application:,,,/images/water_hum.png");
                img_water_hum.Source = new BitmapImage(uri);
            }
            else
            {
                Uri uri = new Uri("pack://application:,,,/images/water_hum2.png");
                img_water_hum.Source = new BitmapImage(uri);
            }
        
        }

    
    }
}
