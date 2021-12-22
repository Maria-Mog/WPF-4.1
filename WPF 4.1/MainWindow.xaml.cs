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

namespace WPF_4._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDollar = rateDollar * sumDollar;
            res.Text = resDollar.ToString();
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rate1.Text);
            double sumEuro = Convert.ToDouble(sum1.Text);
            double resEuro = rateEuro*sumEuro;
            res1.Text = resEuro.ToString();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateGr= Convert.ToDouble(rate2.Text);
            double sumGr = Convert.ToDouble(sum2.Text);
            double resGr = rateGr * sumGr;
            res2.Text = resGr.ToString();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateDr = Convert.ToDouble(rate3.Text);
            double sumDr = Convert.ToDouble(sum3.Text);
            double resDr = rateDr * sumDr;
            res3.Text = resDr.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double distInch = Convert.ToDouble(dist.Text);
            double resulInch= distInch*0.0254;
            resul.Text = resulInch.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double distF = Convert.ToDouble(dist1.Text);
            double resuF = distF * 0.3048;
            resul1.Text = resuF.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double distM = Convert.ToDouble(dist2.Text);
            double resuM = distM * 1609.34;
            resul2.Text = resuM.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double distV = Convert.ToDouble(dist3.Text);
            double resuV = distV * 1066.8;
            resul3.Text = resuV.ToString();
        }
    }
}
