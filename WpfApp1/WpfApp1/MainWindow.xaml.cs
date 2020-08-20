using LiveCharts;
using LiveCharts.Wpf;
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

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SeriesCollection series = new SeriesCollection()
            {
                new LineSeries
                {
                    Title = "Series 1",
                    Values = new ChartValues<double> { 4, 6, 5, 2, 20 }
                },
                new LineSeries
                {
                    Title = "Series 2",
                    Values = new ChartValues<double> { 6, 7, 3, 4, 6 }
                },
                new LineSeries
                {
                    Title = "Series 3",
                    Values = new ChartValues<double> { 1, 3, 10, 4, 7 }
                },
                new LineSeries
                {
                    Title = "Series 3",
                    Values = new ChartValues<double> { 15,5, 7, 12, 4 }
                }
            };
            string[] Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May" };
            s1.Series = series;
            s1x.Labels = Labels;
        }
    }
}
