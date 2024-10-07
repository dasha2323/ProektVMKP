using System.Windows;

namespace WpfApp1
{
    ///shotrs stripes  Magrin = 1155,-195,200,0 (+)    50,270,1300,455  (-)
    ///shorts short    Margin = 1150,-200,193,0 (+)    250,270,1093,470 (-)
    ///shorts long     Margin = 1100,-110,195,0 (+)    600,-110,695,0   (-)
    ///skirt           Margin = 1115,-140,195,0 (+)    430,300,910,440  (-)

    public static class Character
    {
        public static bool weared_on_torso = false;
        public static bool tshirt_weared = false;
        
        public static bool weared_on_legs = false;

        public static bool shorts_stripes_weared = false;
        public static Thickness shorts_stripes_on = new Thickness(1150, -195, 195, 0); //поменять
        public static Thickness shorts_stripes_off = new Thickness(50, 270, 1300, 455);

        public static bool shorts_short_weared = false;
        public static Thickness shorts_short_on = new Thickness(1150, -200, 193, 0);//поменять
        public static Thickness shorts_short_off = new Thickness(250, 270, 1093, 470);

        public static bool shorts_long_weared = false;
        public static Thickness shorts_long_on = new Thickness(1100, -110, 195, 0);//поменять
        public static Thickness shorts_long_off = new Thickness(600, -110, 695, 0);

        public static bool skirt_weared = false;
        public static Thickness skirt_on = new Thickness(1115, -140, 195, 0);//поменять
        public static Thickness skirt_off = new Thickness(430, 300, 910, 440);

        public static bool weared_on_ = false;
    }
}