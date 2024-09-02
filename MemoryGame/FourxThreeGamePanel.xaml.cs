using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;


namespace NewMemoryGame

{
    
    public partial class FourxThreeGamePanel : UserControl
    {
        public static bool isPlayerOneTurn { get; set; } = true;
        public static int PlayerOneScores { get; private set; } = 0;
        public static int PlayerTwoScores { get; private set; } = 0;
        public static string PlayerTurn { get; set; } = "Gracz 1";
        private CardFlippingManager _flippingManager;
        private static MainWindow _menuPanel;
        ///////////////links to pictures of the cards////////////////
        string[] linksBackSidesCards = new string[6] { "C:\\Users\\MaciejG\\source\\repos\\NewMemoryGame\\Pictures\\triss.png",
            "C:\\Users\\MaciejG\\source\\repos\\NewMemoryGame\\Pictures\\yennefer.png",
            "C:\\Users\\MaciejG\\source\\repos\\NewMemoryGame\\Pictures\\zoltan.png",
            "C:\\Users\\MaciejG\\source\\repos\\NewMemoryGame\\Pictures\\ciri.png",
            "C:\\Users\\MaciejG\\source\\repos\\NewMemoryGame\\Pictures\\geralt.png",
            "C:\\Users\\MaciejG\\source\\repos\\NewMemoryGame\\Pictures\\olgierd.png" };
        //creating an instance of MainWindow class
        public FourxThreeGamePanel(MainWindow _menupanel)
        {
            _menuPanel = _menupanel;
        }
        ///////////////functions ///////////////
        public FourxThreeGamePanel()
        {
            InitializeComponent();
            InitializeCards();
            _flippingManager = new CardFlippingManager(this);
            StartShowPlyerScores();

            
        }
        private void StartShowPlyerScores()
        {
            playerOnePoints.Text = PlayerOneScores.ToString();
            playerTwoPoints.Text = PlayerTwoScores.ToString();
            CurrentPlayerRound.Text = PlayerTurn;
        }
        public async void WhichTurn()
        {
            await Task.Delay(2500);
            if (isPlayerOneTurn)
            {
                
                isPlayerOneTurn = false;
                PlayerTurn = "Gracz 2";
                CurrentPlayerRound.Text = PlayerTurn;
            }
            else
            {
                isPlayerOneTurn = true;
                PlayerTurn = "Gracz 1";
                CurrentPlayerRound.Text = PlayerTurn;
            }
        }
        public void ShowPlayerScores()
        {
            //code about scores of players
            if (isPlayerOneTurn)
            {
                PlayerOneScores++;
               playerOnePoints.Text = PlayerOneScores.ToString();
              
            }
            else
            {
                PlayerTwoScores++;
                playerTwoPoints.Text = PlayerTwoScores.ToString();
                
            }

        }
        public void InitializeCards()
        {
            //utworzenie instancji globalnej w CardFlippingManager.cs wszystkich przyciskow w celu ich blokady w trakcie obrotu kart
            CardFlippingManager.CardsPanel = CardsPanel;
            //creating instance of the objects with differents frontsides
            DataContext = this;
            string[] linkToCards = PictureAssignment(linksBackSidesCards);

            /////////////////First Column of Cards/////////////////
            MyFrontSideControl1 = new FrontSideCard { };
            MyBackSideControl1 = new BackSideCard { /* set properties */ };

            MyFrontSideControl2 = new FrontSideCard { /* set properties */ };
            MyBackSideControl2 = new BackSideCard { /* set properties */ };

            MyFrontSideControl3 = new FrontSideCard { /* set properties */ };
            MyBackSideControl3 = new BackSideCard { /* set properties */ };
            /////////////////Second Column of Cards/////////////////
            MyFrontSideControl4 = new FrontSideCard { /* set properties */ };
            MyBackSideControl4 = new BackSideCard { /* set properties */ };

            MyFrontSideControl5 = new FrontSideCard { /* set properties */ };
            MyBackSideControl5 = new BackSideCard { /* set properties */ };

            MyFrontSideControl6 = new FrontSideCard { /* set properties */ };
            MyBackSideControl6 = new BackSideCard { /* set properties */ };
            /////////////////Third Column of Cards/////////////////
            MyFrontSideControl7 = new FrontSideCard { /* set properties */ };
            MyBackSideControl7 = new BackSideCard { /* set properties */ };

            MyFrontSideControl8 = new FrontSideCard { /* set properties */ };
            MyBackSideControl8 = new BackSideCard { /* set properties */ };

            MyFrontSideControl9 = new FrontSideCard { /* set properties */ };
            MyBackSideControl9 = new BackSideCard { /* set properties */ };
            /////////////////Fourth Column of Cards/////////////////
            MyFrontSideControl10 = new FrontSideCard { /* set properties */ };
            MyBackSideControl10 = new BackSideCard { /* set properties */ };

            MyFrontSideControl11 = new FrontSideCard { /* set properties */ };
            MyBackSideControl11 = new BackSideCard { /* set properties */ };

            MyFrontSideControl12 = new FrontSideCard { /* set properties */ };
            MyBackSideControl12 = new BackSideCard { /* set properties */ };
            //initialising the pictures of front part of card - in this place u can change the picture of single card on the revers
            MyFrontSideControl1.ImageSource = new BitmapImage(new Uri("C:\\Users\\MaciejG\\source\\repos\\NewMemoryGame\\Pictures\\backsidecard.png"));
            MyFrontSideControl2.ImageSource = new BitmapImage(new Uri("C:\\Users\\MaciejG\\source\\repos\\NewMemoryGame\\Pictures\\backsidecard.png"));
            MyFrontSideControl3.ImageSource = new BitmapImage(new Uri("C:\\Users\\MaciejG\\source\\repos\\NewMemoryGame\\Pictures\\backsidecard.png"));
            MyFrontSideControl4.ImageSource = new BitmapImage(new Uri("C:\\Users\\MaciejG\\source\\repos\\NewMemoryGame\\Pictures\\backsidecard.png"));
            MyFrontSideControl5.ImageSource = new BitmapImage(new Uri("C:\\Users\\MaciejG\\source\\repos\\NewMemoryGame\\Pictures\\backsidecard.png"));
            MyFrontSideControl6.ImageSource = new BitmapImage(new Uri("C:\\Users\\MaciejG\\source\\repos\\NewMemoryGame\\Pictures\\backsidecard.png"));
            MyFrontSideControl7.ImageSource = new BitmapImage(new Uri("C:\\Users\\MaciejG\\source\\repos\\NewMemoryGame\\Pictures\\backsidecard.png"));
            MyFrontSideControl8.ImageSource = new BitmapImage(new Uri("C:\\Users\\MaciejG\\source\\repos\\NewMemoryGame\\Pictures\\backsidecard.png"));
            MyFrontSideControl9.ImageSource = new BitmapImage(new Uri("C:\\Users\\MaciejG\\source\\repos\\NewMemoryGame\\Pictures\\backsidecard.png"));
            MyFrontSideControl10.ImageSource = new BitmapImage(new Uri("C:\\Users\\MaciejG\\source\\repos\\NewMemoryGame\\Pictures\\backsidecard.png"));
            MyFrontSideControl11.ImageSource = new BitmapImage(new Uri("C:\\Users\\MaciejG\\source\\repos\\NewMemoryGame\\Pictures\\backsidecard.png"));
            MyFrontSideControl12.ImageSource = new BitmapImage(new Uri("C:\\Users\\MaciejG\\source\\repos\\NewMemoryGame\\Pictures\\backsidecard.png"));

            //initialising the pictures of front part of card - in this place u can change the picture of single card on the avers
            MyBackSideControl1.ImageSource = new BitmapImage(new Uri(linkToCards[0]));
            MyFrontSideControl1.ImagePath = linkToCards[0];
            MyBackSideControl2.ImageSource = new BitmapImage(new Uri(linkToCards[1]));
            MyFrontSideControl2.ImagePath = linkToCards[1];
            MyBackSideControl3.ImageSource = new BitmapImage(new Uri(linkToCards[2]));
            MyFrontSideControl3.ImagePath = linkToCards[2];
            MyBackSideControl4.ImageSource = new BitmapImage(new Uri(linkToCards[3]));
            MyFrontSideControl4.ImagePath = linkToCards[3];
            MyBackSideControl5.ImageSource = new BitmapImage(new Uri(linkToCards[4]));
            MyFrontSideControl5.ImagePath = linkToCards[4];
            MyBackSideControl6.ImageSource = new BitmapImage(new Uri(linkToCards[5]));
            MyFrontSideControl6.ImagePath = linkToCards[5];
            MyBackSideControl7.ImageSource = new BitmapImage(new Uri(linkToCards[6]));
            MyFrontSideControl7.ImagePath = linkToCards[6];
            MyBackSideControl8.ImageSource = new BitmapImage(new Uri(linkToCards[7]));
            MyFrontSideControl8.ImagePath = linkToCards[7];
            MyBackSideControl9.ImageSource = new BitmapImage(new Uri(linkToCards[8]));
            MyFrontSideControl9.ImagePath = linkToCards[8];
            MyBackSideControl10.ImageSource = new BitmapImage(new Uri(linkToCards[9]));
            MyFrontSideControl10.ImagePath = linkToCards[9];
            MyBackSideControl11.ImageSource = new BitmapImage(new Uri(linkToCards[10]));
            MyFrontSideControl11.ImagePath = linkToCards[10];
            MyBackSideControl12.ImageSource = new BitmapImage(new Uri(linkToCards[11]));
            MyFrontSideControl12.ImagePath = linkToCards[11];
        }
        public void EndGame()
        {
            foreach (var child in CardsPanel.Children)
            {
                if (child is FlippingCard card)
                {
                    card.Visibility = Visibility.Visible;
                    card.Flip_Card.IsEnabled = true;
                    card.ResetFlip();
                }
            }

            InitializeCards();
            _flippingManager = new CardFlippingManager(this);
            isPlayerOneTurn  = true;
           //scores
            PlayerOneScores = 0;
            PlayerTwoScores  = 0;
            PlayerTurn  = "Gracz 1";
            StartShowPlyerScores();
            _menuPanel.menupanel.Visibility = Visibility.Visible;
        }
        static string[] PictureAssignment(string[] linksBackSidesCards)
        {
            Random rnd = new Random();
            int startAssignmentNumber = rnd.Next(1, 13);
            int temp = rnd.Next(1, 5);
            string[] linkToCards = new string[12];
            int assignment = 0;

            for (int i = 0; i < linkToCards.Length; i++)
            {
                linkToCards[i] = "";
            }

            for (int i = 0; i < 6; i++)
            {
                assignment = 0;
                while (assignment < 2)
                {
                    if (linkToCards[startAssignmentNumber % 12] == "")
                    {
                        linkToCards[startAssignmentNumber % 12] = linksBackSidesCards[i];
                        startAssignmentNumber = startAssignmentNumber * temp;
                        assignment++;
                    }
                    else
                        startAssignmentNumber++;
                }
            }
            return linkToCards;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EndGame();

        }

        /////////////////First Column of Cards/////////////////
        public FrontSideCard MyFrontSideControl1 { get; set; }

        public BackSideCard MyBackSideControl1 { get; set; }

        public FrontSideCard MyFrontSideControl2 { get; set; }
        public BackSideCard MyBackSideControl2 { get; set; }

        public FrontSideCard MyFrontSideControl3 { get; set; }
        public BackSideCard MyBackSideControl3 { get; set; }
        /////////////////Second Column of Cards/////////////////
        public FrontSideCard MyFrontSideControl4 { get; set; }
        public BackSideCard MyBackSideControl4 { get; set; }

        public FrontSideCard MyFrontSideControl5 { get; set; }
        public BackSideCard MyBackSideControl5 { get; set; }

        public FrontSideCard MyFrontSideControl6 { get; set; }
        public BackSideCard MyBackSideControl6 { get; set; }
        /////////////////Third Column of Cards/////////////////
        public FrontSideCard MyFrontSideControl7 { get; set; }
        public BackSideCard MyBackSideControl7 { get; set; }

        public FrontSideCard MyFrontSideControl8 { get; set; }
        public BackSideCard MyBackSideControl8 { get; set; }

        public FrontSideCard MyFrontSideControl9 { get; set; }
        public BackSideCard MyBackSideControl9 { get; set; }
        /////////////////Fourth Column of Cards/////////////////
        public FrontSideCard MyFrontSideControl10 { get; set; }
        public BackSideCard MyBackSideControl10 { get; set; }

        public FrontSideCard MyFrontSideControl11 { get; set; }
        public BackSideCard MyBackSideControl11 { get; set; }

        public FrontSideCard MyFrontSideControl12 { get; set; }
        public BackSideCard MyBackSideControl12 { get; set; }

       


       
    }
}