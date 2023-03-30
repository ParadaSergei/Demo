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
using WpfApplocDemoExamenPARADASERGEI.ViewModel;

namespace WpfApplocDemoExamenPARADASERGEI.View
{
    /// <summary>
    /// Логика взаимодействия для WindowTableProduct.xaml
    /// </summary>
    public partial class WindowTableProduct : Window
    {
        public WindowTableProduct()
        {
            InitializeComponent();
            this.DataContext = new TableProductMV();
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as TableProductMV).DeleteData();
        }
    }
}
