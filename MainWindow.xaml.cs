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
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Interaction logic for MainWindow.xaml
        /// </summary>
        
        public MainWindow()
        {
            InitializeComponent();
        }
        private void shorts_stripes_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!Character.weared_on_legs) //поменять координаты в Character.cs
            {
                shorts_stripes.Margin = Character.shorts_stripes_on;
                Character.weared_on_legs = true;
                Character.shorts_stripes_weared = true;
            }
            else
            {
                if (Character.shorts_stripes_weared)
                {
                    shorts_stripes.Margin = Character.shorts_stripes_off;
                    Character.weared_on_legs = false;
                    Character.shorts_stripes_weared = false;
                }
            }
        }
        private void shorts_short_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(!Character.weared_on_legs)
            {
                shorts_short.Margin = Character.shorts_short_on;
                Character.weared_on_legs = true;
                Character.shorts_short_weared = true;
            }
            else
            {
                if (Character.shorts_short_weared)
                {
                    shorts_short.Margin = Character.shorts_short_off;
                    Character.weared_on_legs = false;
                    Character.shorts_short_weared = false;
                }
            }
        }
        private void shorts_long_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!Character.weared_on_legs)
            {
                shorts_long.Margin = Character.shorts_long_on;
                Character.weared_on_legs = true;
                Character.shorts_long_weared = true;
            }
            else
            {
                if (Character.shorts_long_weared)
                {
                    shorts_long.Margin = Character.shorts_long_off;
                    Character.weared_on_legs = false;
                    Character.shorts_long_weared = false;
                }
            }
        }
        private void skirt_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!Character.weared_on_legs)
            {
                skirt.Margin = Character.skirt_on;
                Character.weared_on_legs = true;
                Character.skirt_weared = true;
            }
            else
            {
                if (Character.skirt_weared)
                {
                    skirt.Margin = Character.skirt_off;
                    Character.weared_on_legs = false;
                    Character.skirt_weared = false;
                }
            }
        }
    }
}