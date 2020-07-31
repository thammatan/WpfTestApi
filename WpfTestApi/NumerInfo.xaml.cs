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

namespace WpfTestApi {
    /// <summary>
    /// Interaction logic for NumerInfo.xaml
    /// </summary>
    public partial class NumerInfo : Window {
        public NumerInfo() {
            InitializeComponent();
        }

        private async void btn_Click(object sender, RoutedEventArgs e) {
              var data = await NumerProcessor.LoadNumerData();
            textBlock.Text = $"This is  { data.Success}";
        }
    }
}
