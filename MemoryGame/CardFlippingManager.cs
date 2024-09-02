using System.Windows;
using System.Windows.Controls;

namespace NewMemoryGame
{
    public class CardFlippingManager : FlippingCard
    {
        public static int counterOfDissaperedCards = 0;
        private static bool isTwoCardsCorrect { get; set; } = true;
        private static FourxThreeGamePanel _gamePanel;
        public CardFlippingManager(FourxThreeGamePanel gamePanel)
        {
            _gamePanel = gamePanel; //adding instance in constructor
        }
        public static int counterCards { get; set; } = 0;
        public static List<FlippingCard> FlippedCards { get; private set; } = new List<FlippingCard>();
        public static Panel CardsPanel { get; set; } // Panel with all the cards
        //counter of actual flipped cards
        public static void IncrementCounter(FlippingCard card)
        {
            counterCards++;
            FlippedCards.Add(card);

            if (counterCards == 2)
            {
                CheckFlippedCards();
            }

        }


        public static void ResetCounter()
        {
            counterCards = 0;
            foreach (FlippingCard card in FlippedCards)
            {
                card.ResetFlip();
            }
            FlippedCards.Clear();
        }
        //blocking the rest of the cards during comparision 2 cards
        public static void BlockAllCards(bool isEnabled)
        {
            if (CardsPanel != null)
            {
                foreach (var child in CardsPanel.Children)
                {
                    if (child is FlippingCard card)
                    {
                        card.Flip_Card.IsEnabled = isEnabled;
                    }
                }
            }
        }



        private async static void CheckFlippedCards()
        {
            if (FlippedCards.Count == 2)
            {
                var firstCard = FlippedCards[0];
                var secondCard = FlippedCards[1];

                var firstCardFront = firstCard.FrontSide as FrontSideCard;
                var secondCardFront = secondCard.FrontSide as FrontSideCard;
                isTwoCardsCorrect = false;
                if (firstCardFront != null && secondCardFront != null &&
                    (firstCardFront.ImagePath == secondCardFront.ImagePath))
                {
                    //manage of cards if pictures matches
                    await Task.Delay(2500); //warning! This time has to be smaller than time in FlippingCard.xaml.cs Line 49 due to restarting array
                    FlippedCards[0].Visibility = Visibility.Hidden;
                    FlippedCards[1].Visibility = Visibility.Hidden;
                    counterOfDissaperedCards = counterOfDissaperedCards + 2;
                    FlippedCards.Clear();
                    BlockAllCards(true);
                    counterCards = 0;
                    _gamePanel.ShowPlayerScores();
                    isTwoCardsCorrect = true;


                    if (counterOfDissaperedCards >= 12)
                    {
                        _gamePanel.EndGame();
                        counterOfDissaperedCards = 0;
                        counterCards = 0;
                        FlippedCards.Clear();
                    }

                }
                if(!isTwoCardsCorrect)
                _gamePanel.WhichTurn();
            }
        }

    }
}



