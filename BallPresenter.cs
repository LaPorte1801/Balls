using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Balls
{
    internal class BallPresenter
    {
        private readonly Ball _ball;
        public Point position { get; }

        public Ellipse ellipse;

        public BallPresenter()
        {
            _ball = new Ball();
            position = _ball.position;
            ellipse = new Ellipse() { Height = 50, Width = 50, Fill = Brushes.Black, Stroke = Brushes.Gray };
        }
    }
}
