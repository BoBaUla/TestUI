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

namespace TestUI.Controls
{
    /// <summary>
    /// Interaktionslogik für NewDataPoint.xaml
    /// </summary>
    public partial class NewDataPoint : UserControl
    {
        public delegate void ValueAdded(double x, double y);
        public event ValueAdded ValueAddedHandler;

        public NewDataPoint()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            double x = double.Parse(tbXValue.Text);
            double y = double.Parse(tbYValue.Text);

            ValueAddedHandler(x, y);
            tbXValue.Text = "";
            tbYValue.Text = "";
        }



        private void TextInput_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int val = 0;
            if (!int.TryParse(e.Text, out val))
            {
                e.Handled = true;
            }
        }

        private void tbValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            btnAdd.IsEnabled = !string.IsNullOrEmpty(tbXValue.Text) && !string.IsNullOrEmpty(tbYValue.Text);
        }
    }
}
