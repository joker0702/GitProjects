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

namespace PixelArts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private ImageSize _imageSize;

        public MainWindow()
        {
            InitializeComponent();
        }

        public ImageSize ImagsSize
        {
            get
            {
                return _imageSize;
            }
            set
            {
                _imageSize = value;
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            WindowNew windowNew = new WindowNew();
            windowNew.Show();
        }
    }
}
