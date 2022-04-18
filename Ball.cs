using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Balls
{
    internal class Ball
    {
        public Point position { get; private set; }
        public event Action<Ball> PositionChanged;
        public Ball()
        {
            position = new Point(0, 0);
            Move();
        }

        public Ball(int posX, int posY)
        {
            position = new Point(posX, posY);
            Move();
        }

        public async void Move()
        {
            while (true)
            {
                await Task.Run(() => 
                {
                    position = new Point(position.X, position.Y + 1);
                    Thread.Sleep(10);
                });

                PositionChanged(this);
            }
        }
    }
}
