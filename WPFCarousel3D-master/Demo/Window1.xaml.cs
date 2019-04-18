namespace SamNoble.Wpf.Controls.DemoClient
{
    using SamNoble.Wpf.Controls.Carousel3D;
    using System;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using System.Windows.Media.Animation;

    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {


        public Window1()
        {
            InitializeComponent();

            /* we will have 6 pages */
            for (var i = 0; i < 6; i++)
            {
                this.btnAddItem_Click(this, new RoutedEventArgs());
            }
        }

        private void btnAddItem_Click(object sender, RoutedEventArgs e)
        {
            iconsLoading();
        }

        /// <summary>
        /// KK added
        /// </summary>
        private void iconsLoading()
        {
            StackPanel sp = new StackPanel();
            sp.Width = 99;
            sp.Height = 29;

            Image icon = new Image();
            icon.Width = 90;
            icon.Height = 25;
            /* Will need to figure out where to put images to relatively point to them */
            string element;
            if (ellipsePanel3D.Children.Count == 1)
                element = "U:/SeniorDesign/carousel/WPFCarousel3D-master/Carousel3D/Images/weather.png";
            else if (ellipsePanel3D.Children.Count == 2)
                element = "U:/SeniorDesign/carousel/WPFCarousel3D-master/Carousel3D/Images/calendar.png";
            else if (ellipsePanel3D.Children.Count == 3)
                element = "U:/SeniorDesign/carousel/WPFCarousel3D-master/Carousel3D/Images/traffic.png";
            else if (ellipsePanel3D.Children.Count == 4)
                element = "U:/SeniorDesign/carousel/WPFCarousel3D-master/Carousel3D/Images/twitter.png";
            else if (ellipsePanel3D.Children.Count == 5)
                element = "U:/SeniorDesign/carousel/WPFCarousel3D-master/Carousel3D/Images/settings.png";
            else
                element = "U:/SeniorDesign/carousel/WPFCarousel3D-master/Carousel3D/Images/home.png";
            icon.Source = new BitmapImage(new Uri(element, UriKind.Relative));
            sp.Children.Add(icon);
            ellipsePanel3D.Children.Add(new Button() { Content = sp });
        }

        private void btnRemoveItem_Click(object sender, RoutedEventArgs e)
        {
            if (ellipsePanel3D.Children.Count > 0)
            {
                ellipsePanel3D.Children.RemoveAt(ellipsePanel3D.Children.Count - 1);
            }
        }

        private void btnMoveNext_Click(object sender, RoutedEventArgs e)
        {
            this.ellipsePanel3D.RotateRight(true);
        }

        private void btnMovePrev_Click(object sender, RoutedEventArgs e)
        {
            this.ellipsePanel3D.RotateLeft(true);
        }

        private void ItemClick(object sender, RoutedEventArgs e)
        {

        }
        
        private void CarouselMouseButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
