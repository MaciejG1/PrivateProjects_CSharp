using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KolkoIKrzyzykOkienkowo
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int round = 1;
        public string sign;
        public string playerInfoStringX= "Kolej gracza II (X)";
        public string playerInfoStringO = "Kolej gracza I (O)";
        public string playerInfoWinX ="Wygrał gracz II (X)";
        public string playerInfoWinO= "Wygrał gracz I (O)";
        public string playerInfoWinREMIS = "REMIS";
        public MainWindow()
        {
            InitializeComponent();

        }
        private void NumberOfRound()
        {
            if (round%2==1)
            {
                PlayerInfo.Content = playerInfoStringO;
                sign = "X";
            }
            else
            {
                PlayerInfo.Content = playerInfoStringX;
                sign = "O";
            }
            

        }
        private void CheckingWin()
        {
            if
               (((string)Button11.Content == "X" && (string)Button12.Content == "X" && (string)Button13.Content == "X") ||
                ((string)Button21.Content == "X" && (string)Button22.Content == "X" && (string)Button23.Content == "X") ||
                ((string)Button31.Content == "X" && (string)Button32.Content == "X" && (string)Button33.Content == "X") ||
                ((string)Button11.Content == "X" && (string)Button21.Content == "X" && (string)Button31.Content == "X") ||
                ((string)Button12.Content == "X" && (string)Button22.Content == "X" && (string)Button32.Content == "X") ||
                ((string)Button13.Content == "X" && (string)Button23.Content == "X" && (string)Button33.Content == "X") ||
                ((string)Button13.Content == "X" && (string)Button22.Content == "X" && (string)Button31.Content == "X") ||
                ((string)Button11.Content == "X" && (string)Button22.Content == "X" && (string)Button33.Content == "X"))
            {
                
                PlayerInfo.Content = playerInfoWinX;
                NewGameButton.Visibility = Visibility.Visible;
            }
            else if
               (((string)Button11.Content == "O" && (string)Button12.Content == "O" && (string)Button13.Content == "O") ||
                ((string)Button21.Content == "O" && (string)Button22.Content == "O" && (string)Button23.Content == "O") ||
                ((string)Button31.Content == "O" && (string)Button32.Content == "O" && (string)Button33.Content == "O") ||
                ((string)Button11.Content == "O" && (string)Button21.Content == "O" && (string)Button31.Content == "O") ||
                ((string)Button12.Content == "O" && (string)Button22.Content == "O" && (string)Button32.Content == "O") ||
                ((string)Button13.Content == "O" && (string)Button23.Content == "O" && (string)Button33.Content == "O") ||
                ((string)Button13.Content == "O" && (string)Button22.Content == "O" && (string)Button31.Content == "O") ||
                ((string)Button11.Content == "O" && (string)Button22.Content == "O" && (string)Button33.Content == "O"))
            {
                
                PlayerInfo.Content = playerInfoWinO;
                NewGameButton.Visibility = Visibility.Visible;
            }
            else if((string)Button11.Content != "" && (string)Button12.Content != "" && (string)Button13.Content != "" && 
                    (string)Button21.Content != "" && (string)Button22.Content != "" && (string)Button23.Content != "" &&
                    (string)Button31.Content != "" && (string)Button32.Content != "" && (string)Button33.Content != "")
            {
               
                PlayerInfo.Content = playerInfoWinREMIS;
                NewGameButton.Visibility = Visibility.Visible;
            }
        }

        private void NewGameButton_Click(object sender, RoutedEventArgs e)
        {
            round = 1;
            sign = "";
            
            PlayerInfo.Content = playerInfoStringO;
            Button11.Content = "";
            Button12.Content = "";
            Button13.Content = "";
            Button21.Content = "";
            Button22.Content = "";
            Button23.Content = "";
            Button31.Content = "";
            Button32.Content = "";
            Button33.Content = "";
            NewGameButton.Visibility= Visibility.Hidden;
        }
        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            // Obsługa kliknięcia przycisku "Exit"
            Application.Current.Shutdown(); // Zamknięcie aplikacji
        }

        private void NewGameMenuItem_Click(object sender, RoutedEventArgs e)
        {
        round = 1;
        sign="";   
        PlayerInfo.Content = playerInfoStringO;
        Button11.Content = "";
        Button12.Content = "";
        Button13.Content = "";
        Button21.Content = "";
        Button22.Content = "";
        Button23.Content = "";
        Button31.Content = "";
        Button32.Content = "";
        Button33.Content = "";
            NewGameButton.Visibility = Visibility.Hidden;
        }

        private void RulesOfGameMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Zasady Gry:\r\n\r\nCel gry: Gra polega na umiejętnym ustawianiu trzech kółek lub krzyżyków w jednej linii (poziomej, pionowej lub skośnej) przed przeciwnikiem.\r\n\r\nPrzygotowanie: Zaczynając od pustej planszy o wymiarach 3x3, gracze na przemian umieszczają swoje kółka lub krzyżyki w dowolnym wolnym kwadracie.\r\n\r\nRuchy graczy: Gracz stawiający kółko lub krzyżyk może postawić jeden element w jednym ruchu. Celem jest zbudowanie linii z trzech swoich symboli zanim zrobi to przeciwnik.\r\n\r\nZwycięstwo: Gra kończy się, gdy jeden z graczy zbuduje linię z trzech kółek lub krzyżyków. Zwycięzcą jest osoba, która osiągnie ten cel pierwsza.\r\n\r\nRemis: Jeżeli plansza zostanie zapełniona, a nikt nie zbuduje linii, gra kończy się remisem.");
        }

        private void Button11_Click(object sender, RoutedEventArgs e)
        {
           
           if ((string)Button11.Content == "" && (string)PlayerInfo.Content != playerInfoWinO && (string)PlayerInfo.Content != playerInfoWinX && (string)PlayerInfo.Content != playerInfoWinREMIS)
            {
                round++;
                NumberOfRound();
                Button11.Content = sign;
                CheckingWin();
            }
            else
            { 
            
            }

        }
        private void Button12_Click(object sender, RoutedEventArgs e)
        {
           
            if ((string)Button12.Content == "" && (string)PlayerInfo.Content != playerInfoWinO && (string)PlayerInfo.Content != playerInfoWinX && (string)PlayerInfo.Content != playerInfoWinREMIS)
            {
                round++;
                NumberOfRound();
                Button12.Content = sign;
                CheckingWin();
            }
            else
            {

            }
        }
        private void Button13_Click(object sender, RoutedEventArgs e)
        {
            if ((string)Button13.Content == "" && (string)PlayerInfo.Content != playerInfoWinO && (string)PlayerInfo.Content != playerInfoWinX && (string)PlayerInfo.Content != playerInfoWinREMIS)
            {
                round++;
                NumberOfRound();
                Button13.Content = sign;
                CheckingWin();
            }
            else
            {

            }
        }


        private void Button21_Click(object sender, RoutedEventArgs e)
        {
            if ((string)Button21.Content == "" && (string)PlayerInfo.Content != playerInfoWinO && (string)PlayerInfo.Content != playerInfoWinX && (string)PlayerInfo.Content != playerInfoWinREMIS)
            {
                round++;
                NumberOfRound();
                Button21.Content = sign;
                CheckingWin();
            }
            else
            {

            }

        }
        private void Button22_Click(object sender, RoutedEventArgs e)
        {
            if ((string)Button22.Content == "" && (string)PlayerInfo.Content != playerInfoWinO && (string)PlayerInfo.Content != playerInfoWinX && (string)PlayerInfo.Content != playerInfoWinREMIS)
            {
                round++;
                NumberOfRound();
                Button22.Content = sign;
                CheckingWin();
            }
            else
            {

            }

        }
        private void Button23_Click(object sender, RoutedEventArgs e)
        {
            if ((string)Button23.Content == "" && (string)PlayerInfo.Content != playerInfoWinO && (string)PlayerInfo.Content != playerInfoWinX && (string)PlayerInfo.Content != playerInfoWinREMIS)
            {
                round++;
                NumberOfRound();
                Button23.Content = sign;
                CheckingWin();
            }
            else
            {

            }

        }


        private void Button31_Click(object sender, RoutedEventArgs e)
        {
            if ((string)Button31.Content == "" && (string)PlayerInfo.Content != playerInfoWinO && (string)PlayerInfo.Content != playerInfoWinX && (string)PlayerInfo.Content != playerInfoWinREMIS)
            {
                round++;
                NumberOfRound();
                Button31.Content = sign;
                CheckingWin();
            }
            else
            {

            }

        }
        private void Button32_Click(object sender, RoutedEventArgs e)
        {
             if ((string)Button32.Content == "" && (string)PlayerInfo.Content != playerInfoWinO && (string)PlayerInfo.Content != playerInfoWinX && (string)PlayerInfo.Content != playerInfoWinREMIS)
            {
                round++;
                NumberOfRound();
                Button32.Content = sign;
                CheckingWin();
            }
            else
            {

            }

        }
        private void Button33_Click(object sender, RoutedEventArgs e)
        {
            if ((string)Button33.Content == "" && (string)PlayerInfo.Content != playerInfoWinO && (string)PlayerInfo.Content != playerInfoWinX && (string)PlayerInfo.Content != playerInfoWinREMIS)
            {
                round++;
                NumberOfRound();
                Button33.Content = sign;
                CheckingWin();
            }
            else
            {

            }

        }
    }
}
