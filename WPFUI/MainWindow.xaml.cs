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
using Engine.ViewModels;
using Engine.EventArgs;



namespace WPFUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GameSession _gameSession;

        public GameSession GameSession { get => _gameSession; set => _gameSession = value; }

        public MainWindow()
        {
            InitializeComponent();
            this.GameSession = new GameSession();
            this.GameSession.OnMessageRaised += OnGameMessageRaised;
            DataContext = this.GameSession;

        }

        private void OnClick_MoveNorth(object sender, RoutedEventArgs e)
        {
            GameSession.MoveNorth();
        }

        private void OnClick_MoveSouth(object sender, RoutedEventArgs e)
        {
            GameSession.MoveSouth();
        }

        private void OnClick_MoveWest(object sender, RoutedEventArgs e)
        {

            GameSession.MoveWest();
        }

        private void OnClick_MoveEast(object sender, RoutedEventArgs e)
        {
            GameSession.MoveEast();
        }

        private void OnClick_AttackMonster(object sender, RoutedEventArgs e)
        {
            GameSession.AttackCurrentMonster();
        }

        private void OnGameMessageRaised(object sender, GameMessageEventArgs e)
        {
            GameMessage.Document.Blocks.Add(new Paragraph(new Run(e.Message)));
            GameMessage.ScrollToEnd();
        }

        private void OnClicl_DisplayTradeScreen(object sender, RoutedEventArgs e)
        {
            TradeScreen tradeScreen = new TradeScreen();
            tradeScreen.Owner = this;
            tradeScreen.DataContext = _gameSession;
            tradeScreen.ShowDialog();
        }
    }
}
