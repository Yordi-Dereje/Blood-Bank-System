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
using LiveCharts.Definitions.Charts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;

namespace BloodManagementSystem
{
    public partial class BloodStockChart : Form
    {
        public BloodStockChart()
        {
            InitializeComponent();
        }

        private void BloodStockChart_Load(object sender, EventArgs e)
        {
            Func<ChartPoint, string> labelPoint = chartPoint => String.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "A+",
                    Values = new ChartValues<double> {6450},
                    DataLabels = true,
                    LabelPoint = labelPoint,
                },
                new PieSeries
                {
                    Title = "A-",
                    Values = new ChartValues<double> {6450},
                    DataLabels = true,
                    LabelPoint = labelPoint,
                },
                new PieSeries
                {
                    Title = "B+",
                    Values = new ChartValues<double> {6450},
                    DataLabels = true,
                    LabelPoint = labelPoint,
                },
                new PieSeries
                {
                    Title = "B-",
                    Values = new ChartValues<double> {6450},
                    DataLabels = true,
                    LabelPoint = labelPoint,
                },
                new PieSeries
                {
                    Title = "AB+",
                    Values = new ChartValues<double> {6450},
                    DataLabels = true,
                    LabelPoint = labelPoint,
                },
                new PieSeries
                {
                    Title = "AB-",
                    Values = new ChartValues<double> {6450},
                    DataLabels = true,
                    LabelPoint = labelPoint,
                },
                new PieSeries
                {
                    Title = "O+",
                    Values = new ChartValues<double> {6450},
                    DataLabels = true,
                    LabelPoint = labelPoint,
                },
                new PieSeries
                {
                    Title = "O-",
                    Values = new ChartValues<double> {6450},
                    DataLabels = true,
                    LabelPoint = labelPoint,
                }
            };
            pieChart1.LegendLocation = LegendLocation.Bottom;
        }

        private void pieChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
