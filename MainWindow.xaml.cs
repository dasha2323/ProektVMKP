using System.Text;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    ///shotrs stripes  Magrin = 1155,-195,200,0 (+)    50,270,1300,455  (-)
    ///shorts short    Margin = 1150,-200,193,0 (+)    250,270,1093,470 (-)
    ///skirt           Margin = 1115,-140,195,0 (+)    430,300,910,440  (-)
    ///shorts long     Margin = 1100,-110,195,0 (+)    600,-110,695,0   (-)


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        static bool weared_on_legs = false;
        private void shorts_stripes_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!weared_on_legs)
            {
                shorts_stripes.Margin = new Thickness(1150, -195, 195, 0);
                weared_on_legs |= true;
            }
            else
            {
                if (shorts_stripes.Margin == new Thickness(1150, -195, 195, 0))
                {
                    shorts_stripes.Margin = new Thickness(50, 270, 1300, 455);
                    weared_on_legs = false;
                }
            }
        }
        private void shorts_short_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!weared_on_legs)
            {
                shorts_short.Margin = new Thickness(1148, -200, 187, 0);
                weared_on_legs = true;
            }
            else
            {
                if (shorts_short.Margin == new Thickness(1148, -200, 187, 0))
                {
                    shorts_short.Margin = new Thickness(250, 270, 1093, 470);
                    weared_on_legs = false;
                }
            }
        }
        private void skirt_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!weared_on_legs)
            {
                skirt.Margin = new Thickness(1115, -140, 195, 0);
                weared_on_legs = true;
            }
            else
            {
                if (skirt.Margin == new Thickness(1115, -140, 195, 0))
                {
                    skirt.Margin = new Thickness(430, 300, 910, 440);
                    weared_on_legs = false;
                }
            }
        }
        private void shorts_long_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!weared_on_legs)
            {
                shorts_long.Margin = new Thickness(1100, -110, 195, 0);
                weared_on_legs = true;
            }
            else
            {
                if (shorts_long.Margin == new Thickness(1100, -110, 195, 0))
                {
                    shorts_long.Margin = new Thickness(600, -110, 695, 0);
                    weared_on_legs = false;
                }
            }
        }
        }
}