using System.Windows;

namespace NewMemoryGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       private FourxThreeGamePanel _fourxThreeGamePanel {  get; set; }  
        public MainWindow()
        {
            InitializeComponent();
            _fourxThreeGamePanel = new FourxThreeGamePanel(this);
        }

       
        private void Play_Click(object sender, RoutedEventArgs e)
        {
            menupanel.Visibility = Visibility.Hidden;
            fourxthreepanel.Visibility = Visibility.Visible;
        }

        private void HowToPlay_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Zasady gry:\r\n\r\nCel gry:\r\nNależy odkryć 2 karty z tymi samymi postaciami aby otrzymać punkt. W przypadku gdy uda sie odwrócić 2 karty te same, możemy kontynuować odkrywanie następnych kart. Za każdą odkrytą parę, gracz otrzymuje 1 punkt. W przypadku gdy nie uda mu się odkryć 2 tych samych kart, rozpoczyna się tura drugiego gracza.\r\n\r\nKoniec Gry:\r\nGra kończy się kiedy zostaną odkrytę wszystkie karty. Wygrywa gracz z większą ilością punktów. \r\n");

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}