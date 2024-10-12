﻿using System.Text;
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
        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            //myCanvas.Width = e.NewSize.Width;
            //myCanvas.Height = e.NewSize.Height;

            //double xChange = 1, yChange = 1;

            //if (e.PreviousSize.Width != 0)
            //    xChange = (e.NewSize.Width / e.PreviousSize.Width);

            //if (e.PreviousSize.Height != 0)
            //    yChange = (e.NewSize.Height / e.PreviousSize.Height);

            //foreach (FrameworkElement fe in myCanvas.Children)
            //{
            //    fe.Height = fe.ActualHeight * yChange;
            //    fe.Width = fe.ActualWidth * xChange;

            //    Canvas.SetTop(fe, Canvas.GetTop(fe) * yChange);
            //    Canvas.SetLeft(fe, Canvas.GetLeft(fe) * xChange);
            //}
            myCanvas.Width = e.NewSize.Width;
            myCanvas.Height = e.NewSize.Height;

            double xChange = 1, yChange = 1;

            if (e.PreviousSize.Width != 0)
                xChange = (e.NewSize.Width / e.PreviousSize.Width);

            if (e.PreviousSize.Height != 0)
                yChange = (e.NewSize.Height / e.PreviousSize.Height);

            ScaleTransform scale = new ScaleTransform(myCanvas.LayoutTransform.Value.M11 * xChange, myCanvas.LayoutTransform.Value.M22 * yChange);
            myCanvas.LayoutTransform = scale;
            myCanvas.UpdateLayout();
        }


        private bool _isMoving;
        private double offsetX;
        private double offsetY;
        private void MouseDown(object sender, MouseButtonEventArgs e)
        {
            _isMoving = true;
            var image =  sender as Image;
            offsetX = Mouse.GetPosition(this).X - Canvas.GetLeft(image);
            offsetY = Mouse.GetPosition(this).Y - Canvas.GetTop(image);
        }

        private void MouseUp(object sender, MouseButtonEventArgs e)
        {
            _isMoving = false;
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            if (!_isMoving) return;
            var image = sender as Image;
            if (image != null)
            {
                Canvas.SetLeft(image, Mouse.GetPosition(this).X - offsetX);
                Canvas.SetTop(image, Mouse.GetPosition(this).Y - offsetY);
            }
        }

    }
}