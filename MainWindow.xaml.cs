using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Balls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<BallPresenter> ballPresenters;

        public MainWindow()
        {
            InitializeComponent();
            ballPresenters = new List<BallPresenter>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new();
            BallPresenter ballPresenter = new(mainCanvas, random.Next(0, Convert.ToInt32(mainCanvas.ActualWidth)), -100);
            ballPresenters.Add(ballPresenter);
            ballPresenter.DrawBall();
        }

        private void MainCanvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            for (int i = 0; i < ballPresenters.Count; i++)
            {
                if (e.GetPosition(mainCanvas).X >= ballPresenters[i].position.X && e.GetPosition(mainCanvas).X <= ballPresenters[i].position.X + 50 &&
                    e.GetPosition(mainCanvas).Y >= ballPresenters[i].position.Y && e.GetPosition(mainCanvas).Y <= ballPresenters[i].position.Y + 50)
                {
                    ballPresenters[i].HitBall();
                }
            }
        }
    }
}
