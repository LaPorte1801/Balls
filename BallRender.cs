using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace Balls
{
    internal class BallRender
    {
        private BallPresenter _presenter;
        private Canvas _canvas;

        public BallRender(Canvas canvas)
        {
            _presenter = new BallPresenter();
            _canvas = canvas;
        }

        public void DrawBall()
        {
            _canvas.Children.Add(_presenter.ellipse);
            Canvas.SetTop(_presenter.ellipse, _presenter.position.X);
            Canvas.SetLeft(_presenter.ellipse, _presenter.position.Y);
        }

        public void SetPosition(int x, int y)
        {

        }

    }
}
