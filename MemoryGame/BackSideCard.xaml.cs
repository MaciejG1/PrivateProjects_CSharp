using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace NewMemoryGame
{
    /// <summary>
    /// Logika interakcji dla klasy BackSideCard.xaml
    /// </summary>
    public partial class BackSideCard : UserControl
    {

        public BitmapImage ImageSource
        {
            get { return (BitmapImage)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }

        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register("ImageSource", typeof(BitmapImage), typeof(BackSideCard), new PropertyMetadata(null));

        public BackSideCard()
        {
            InitializeComponent();
        }
    }
}
