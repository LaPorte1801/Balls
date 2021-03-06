using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Balls
{
    internal class BallPresenter
    {
        private readonly Ball _ball;
        public Point position { get; private set; }
        private Canvas _canvas;
        private Ellipse _ellipse;

        public BallPresenter(Canvas canvas, int posX, int posY)
        {
            _ball = new Ball(posX, posY);
            _canvas = canvas;
            position = _ball.position;
            _ellipse = new Ellipse() { Height = 50, Width = 50, Fill = Brushes.Black, Stroke = Brushes.Gray };
            _ball.PositionChanged += _ball_PositionChangedHandler;
        }

        private void _ball_PositionChangedHandler()
        {
            position = _ball.position;
            Canvas.SetLeft(_ellipse, _ball.position.X);
            Canvas.SetTop(_ellipse, _ball.position.Y);
            if (_ball.position.Y > _canvas.ActualHeight)
            {
                _canvas.Children.Remove(_ellipse);
            }
        }

        public void DrawBall()
        {
            _canvas.Children.Add(_ellipse);
            Canvas.SetLeft(_ellipse, _ball.position.X);
            Canvas.SetTop(_ellipse, _ball.position.Y);
        }

        public void HitBall()
        {
            _canvas.Children.Remove(_ellipse);
        }
            
    }
}
