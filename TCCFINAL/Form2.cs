using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace TCCFINAL
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Location = new Point(5, 5);
            this.TopMost = true;
            this.StartPosition = FormStartPosition.Manual;
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

            var lista2 = new List<ObservablePoint>();


            lista2.Add(new ObservablePoint
            {
                X = 0,
                Y = 62
            });

            var lista3 = new List<ObservablePoint>();

            lista3.Add(new ObservablePoint
            {
                X = 10,
                Y = 0
            });

            var lista4 = new List<ObservablePoint>();

            lista4.Add(new ObservablePoint
            {
                X = 2.8,
                Y = 42.43
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
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(26, 122, 192)),
                Fill = System.Windows.Media.Brushes.Transparent,
                PointGeometrySize = 20,
                PointForeground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 22, 27))
            }); ;

            cartesianChart.Series.Add(new LineSeries
            {
                Values = new ChartValues<ObservablePoint>(lista1.AsEnumerable()),
               
            }); ;

            cartesianChart.Series.Add(new LineSeries
            {
                Values = new ChartValues<ObservablePoint>(lista2.AsEnumerable()),

            });

            cartesianChart.Series.Add(new LineSeries
            {
                Values = new ChartValues<ObservablePoint>(lista3.AsEnumerable()),

            });

            cartesianChart.Series.Add(new LineSeries
            {
                Values = new ChartValues<ObservablePoint>(lista4.AsEnumerable()),
                StrokeThickness = 2,
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(51, 102, 0)),
                Fill = System.Windows.Media.Brushes.Transparent,
                PointGeometrySize = 20,
                PointForeground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(51, 102, 0))
            }); ;

            //parte de colorir
            cartesianChart.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(55, 32, 49));
            cartesianChart.AxisX.Add(new Axis
            {
                IsMerged = true,
                Separator = new Separator
                {
                    StrokeThickness = 0.5,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(4),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))

                },
                
            });

            cartesianChart.AxisY.Add(new Axis
            {
                IsMerged = false,
                Separator = new Separator
                {
                    StrokeThickness = 0.5,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(4),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))

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
