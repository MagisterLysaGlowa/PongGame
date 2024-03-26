using PongGame.pong;
using PongGame;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace PongGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer game_timer;
        private Ball ball;
        private Player player_mouse;
        private Player player_keyboard;

        public MainWindow()
        {
            InitializeComponent();
            //Utworzenie podstawowych obiektów

            ball =
                new Ball(10, 10, MainCanavs);
            player_mouse =
                new Player(MainCanavs, 10, 100, new SolidColorBrush(Colors.White), false);
            player_keyboard =
                new Player(MainCanavs, 10, 100, new SolidColorBrush(Colors.White), true);

        }
    }
}