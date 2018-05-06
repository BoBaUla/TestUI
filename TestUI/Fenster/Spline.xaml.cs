using MyMath;
using MyMath.SplineCondition;
using MyMath.Typen;
using OxyPlot;
using OxyPlot.Series;
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
using System.Windows.Shapes;
using TestUI.Controls;

namespace TestUI.Fenster
{
    /// <summary>
    /// Interaktionslogik für Spline.xaml
    /// </summary>
    public partial class Spline : Window
    {
        Interpolation _interpol = new Interpolation();
        List<DataPointViewModel> _DataPoints = new List<DataPointViewModel>();
        public Spline()
        {
            InitializeComponent();
            
            CtrlDataPoints.ValueAddedHandler += CtrlDataPoints_ValueAddedHandler;
            LineSeries ser = new LineSeries();
            for (int i = 0; i < 50; i++)
                //ser.Points.Add(new DataPoint(i, _interpol.GetValue(i)));
                ser.Points.Add(new DataPoint(i, (i)));
            ((PlotterViewModel)CtrlPlotterSpline.DataContext).MyModel.Series.Add(ser);
            rbNatural.IsChecked = true;

        }

        public double ValueOnGrid(int iValue, int gridWidth)
        {
            return _interpol.Xmin + (_interpol.Xmax - _interpol.Xmin) / gridWidth * iValue;
        }

        private void CtrlDataPoints_ValueAddedHandler(double x, double y)
        {
            DataPointViewModel dataPoint = new DataPointViewModel() { XValue = x, YValue = y };
            var xList = from xValue in _DataPoints select xValue.XValue;
            if (xList.Contains(dataPoint.XValue))
            {
                MessageBox.Show("You already entered a value for this position");
                return;
            }

            

            _DataPoints.Add(dataPoint);
            _DataPoints.Sort();

            _interpol.AddValue(new TDataPoint(x, y));
            if (_interpol.Count > 1)
            {
                Interpolate();
            }
            else
            {
                LineSeries ser = new LineSeries();
                ser.Points.Add(new DataPoint(0, 0));
                ser.Points.Add(new DataPoint(x, y));
                ((PlotterViewModel)CtrlPlotterSpline.DataContext).MyModel.Series.Add(ser);
                ((PlotterViewModel)CtrlPlotterSpline.DataContext).MyModel.InvalidatePlot(true);
            }

            lvDataPoints.Items.Clear();
            foreach (DataPointViewModel data in _DataPoints)
            {
                lvDataPoints.Items.Add(data);
            }


        }
        
        private void btnClearValues_Click(object sender, RoutedEventArgs e)
        {
            ((PlotterViewModel)CtrlPlotterSpline.DataContext).MyModel.Series.Clear();
            ((PlotterViewModel)CtrlPlotterSpline.DataContext).MyModel.InvalidatePlot(true);
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void rb_Checked(object sender, RoutedEventArgs e)
        {
            if(((RadioButton)sender).Name == "rbNatural")
                _interpol = new Interpolation();
            else if (((RadioButton)sender).Name == "rbClamped1")
                _interpol = new Interpolation(new ClampedSpline(),1,1);
            else if (((RadioButton)sender).Name == "rbClamped2")
                _interpol = new Interpolation(new ClampedSpline(), 4, 4);
            SetValues();
        }

        private void btnRedraw_Click(object sender, RoutedEventArgs e)
        {
            Interpolate();
        }

        private void Interpolate()
        {
           
                _interpol.Interpolate();
                ((PlotterViewModel)CtrlPlotterSpline.DataContext).MyModel.Series.Clear();
                LineSeries ser = new LineSeries();
                for (int i = 0; i < _interpol.Count * 10; i++)
                {
                    double val = _interpol.GetValue(ValueOnGrid(i, _interpol.Count * 10));
                    DataPoint data = new DataPoint(ValueOnGrid(i, _interpol.Count * 10), val);
                    ser.Points.Add(data);
                }
               ((PlotterViewModel)CtrlPlotterSpline.DataContext).MyModel.Series.Add(ser);
                ((PlotterViewModel)CtrlPlotterSpline.DataContext).MyModel.InvalidatePlot(true);
           
        }

        private void SetValues()
        {
            foreach(DataPointViewModel data in _DataPoints)
            {
                _interpol.AddValue(new TDataPoint(data.XValue, data.YValue));
            }
        }
    }
}
