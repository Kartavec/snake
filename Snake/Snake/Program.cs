using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Snake
{
	class Program
	{
		static void Main( string[] args )
		{
			Console.SetBufferSize( 80, 25 );

			// Отрисовка рамочки
			HorizontalLine upLine = new HorizontalLine( 0, 78, 0, '+' );
			HorizontalLine downLine = new HorizontalLine( 0, 78, 24, '+' );
			VerticalLine leftLine = new VerticalLine( 0, 24, 0, '+' );
			VerticalLine rightLine = new VerticalLine( 0, 24, 78, '+' );
			upLine.Draw();
			downLine.Draw();
			leftLine.Draw();
			rightLine.Draw();
			
			// Отрисовка точек			
			Point p = new Point( 4, 5, '*' );
			Snake snake = new Snake( p, 4, Direction.RIGHT );
			snake.Draw();

			FoodCreator foodCreator = new FoodCreator( 80, 25, '$' );
			Point food = foodCreator.CreateFood();
			food.Draw();

			while (true)
			{
				if(snake.Eat( food ) )
				{
					food = foodCreator.CreateFood();
					food.Draw();
            }
				else
				{
					snake.Move();
				}					

				Thread.Sleep( 100 );

				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.HandleKey( key.Key );
				}
			}
		}
	}
}
