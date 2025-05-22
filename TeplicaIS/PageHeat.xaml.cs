using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    /// Логика взаимодействия для PageHeat.xaml
    /// </summary>
    public partial class PageHeat : Page
    {
        bool flagHeat = false;
        double angle = 0;
        public PageHeat()
        {
            InitializeComponent();
        }

        public void Heat_Click(object sender, RoutedEventArgs e)
        {
            flagHeat = !flagHeat;
            if (flagHeat)
            {
                Uri uri = new Uri("pack://application:,,,/images/heat_battery_on.png");
                img_heat_heat.Source = new BitmapImage(uri);
            }
            else
            {
                Uri uri = new Uri("pack://application:,,,/images/scale_2400 (2).png");
                img_heat_heat.Source = new BitmapImage(uri);
            }
           
        } 
        bool flagAlarm = false;

        public void Alarm2_Click(object sender, RoutedEventArgs e)
        {
            flagAlarm = !flagAlarm;
            if (flagAlarm)
            {
                Uri uri = new Uri("pack://application:,,,/images/heat_alarm.png");
                img_heat_alarm.Source = new BitmapImage(uri);
            }
            else
            {
                Uri uri = new Uri("pack://application:,,,/images/heat_alarm2.png");
                img_heat_alarm.Source = new BitmapImage(uri);
            }
        }
            
                public void Manometr_Click(object sender, RoutedEventArgs e)
        {
            // Повернуть heat_pressure на 45 градусов
            RotateImage(45);


        }
        public void RotateImage(double rotate)
        {
            angle += rotate;
            // Создаем новый RotateTransform с заданным углом
            RotateTransform rotateTransform = new RotateTransform(angle);

            // Применяем трансформацию к элементу heat_pressure
            img_heat_strelka.RenderTransform = rotateTransform;

            // Устанавливаем центр вращения в середину изображения
            img_heat_strelka.RenderTransformOrigin = new Point(0.5, 0.5);
        }

        

    }

}
