using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace Balls
{
    internal class BallRender
    {
        private BallPresenter _presenter;
        private Canvas _canvas;
        private Point _position;

        public BallRender(Canvas canvas)
        {
            _presenter = new BallPresenter();
            _canvas = canvas;
        }

        public BallRender(Canvas canvas, int posX, int posY)
        {
            _position = new Point(posX, posY);
            _presenter = new BallPresenter(canvas, posX, posY);
            _canvas = canvas;
        }

        public void DrawBall()
        {
            _canvas.Children.Add(_presenter._ellipse); 
            Canvas.SetLeft(_presenter._ellipse, _position.X);
            Canvas.SetTop(_presenter._ellipse, _position.Y);
        }


    }
}
