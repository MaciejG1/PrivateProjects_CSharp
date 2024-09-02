using System.Windows;
using System.Windows.Controls;

namespace NewMemoryGame
{
    public partial class FlippingCard : UserControl
    {

        //creating dynamic assignment of pictures to frontside card
        public static readonly DependencyProperty FrontSideProperty =
            DependencyProperty.Register("FrontSide", typeof(UIElement), typeof(FlippingCard), new PropertyMetadata(null));

        public UIElement FrontSide
        {
            get { return (UIElement)GetValue(FrontSideProperty); }
            set { SetValue(FrontSideProperty, value); }
        }

        public static readonly DependencyProperty BackSideProperty =
            DependencyProperty.Register("BackSide", typeof(UIElement), typeof(FlippingCard), new PropertyMetadata(null));

        public UIElement BackSide
        {
            get { return (UIElement)GetValue(BackSideProperty); }
            set { SetValue(BackSideProperty, value); }
        }



        public FlippingCard()
        {
            InitializeComponent();
        }

        public async void ToggleButtonChecking(object sender, RoutedEventArgs e)
        {
            if (Flip_Card.IsChecked == true)
            {

                blockingCardButton.Visibility = Visibility.Visible;
                CardFlippingManager.IncrementCounter(this);

                if (CardFlippingManager.counterCards == 2)
                {
                    CardFlippingManager.BlockAllCards(false);
                    await Task.Delay(2700);
                    CardFlippingManager.ResetCounter();
                    CardFlippingManager.BlockAllCards(true);

                }
            }

        }

        protected void blockingCardButton_Click(object sender, RoutedEventArgs e)
        {


        }

        public void ResetFlip()
        {

            Flip_Card.IsChecked = false;
            blockingCardButton.Visibility = Visibility.Hidden;
        }

    }
}
