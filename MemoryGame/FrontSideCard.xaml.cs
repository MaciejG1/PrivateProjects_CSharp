using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace NewMemoryGame
{
    /// <summary>
    /// Logika interakcji dla klasy FrontSideCard.xaml
    /// </summary>
    public partial class FrontSideCard : UserControl
    {
        public BitmapImage ImageSource
        {
            get { return (BitmapImage)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }

        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register("ImageSource", typeof(BitmapImage), typeof(FrontSideCard), new PropertyMetadata(null));

        public string ImagePath { get; set; }

        public FrontSideCard()
        {
            InitializeComponent();
        }
    }
}
