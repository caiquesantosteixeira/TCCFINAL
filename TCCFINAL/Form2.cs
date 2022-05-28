using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace TCCFINAL
{
    public partial class Form2 : Form
    {
        private decimal _val1;
        private decimal _val2;
        private decimal _val3;
        private decimal _val4;
        public Form2()
        {
            InitializeComponent();
            PopulateChart();
        }

        public Form2(decimal val1,decimal val2, decimal val3, decimal val4)
        {
            _val1 = val1;
            _val2 = val2;
            _val3 = val3;
            _val4 = val4;
            InitializeComponent();
            PopulateChart();
        }

        public void PopulateChart() 
        {
            var lista1 = new List<ObservablePoint>();

            lista1.Add(new ObservablePoint
            {
                X = 0,
                Y = 0
            });


            var lista = new List<ObservablePoint>();


            lista.Add(new ObservablePoint
            {
                X = 2.00,
                Y = 46.74
            });

            lista.Add(new ObservablePoint
            {
                X = 4.00,
                Y = 31.42
            });

            lista.Add(new ObservablePoint
            {
                X = 6.00,
                Y = 19.95
            });

            lista.Add(new ObservablePoint
            {
                X = 8.00,
                Y = 13.53
            });

            cartesianChart.Series.Add(new LineSeries
            {
                Values = new ChartValues<ObservablePoint>(lista.AsEnumerable()),
                StrokeThickness = 2,
                Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(26, 122, 192)),
                Fill = Brushes.Transparent,
                PointGeometrySize = 20,
                PointForeground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 22, 27))
            }); ;

            cartesianChart.Series.Add(new LineSeries
            {
                Values = new ChartValues<ObservablePoint>(lista1.AsEnumerable()),
               
            }); ;



            cartesianChart.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(55, 32, 49));
            cartesianChart.AxisX.Add(new Axis
            {
                IsMerged = true,
                Separator = new Separator
                {
                    StrokeThickness = 0.5,
                    StrokeDashArray = new DoubleCollection(4),
                    Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))

                },
                
            });

            cartesianChart.AxisY.Add(new Axis
            {
                IsMerged = false,
                Separator = new Separator
                {
                    StrokeThickness = 0.5,
                    StrokeDashArray = new DoubleCollection(4),
                    Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))

                }
            });

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
