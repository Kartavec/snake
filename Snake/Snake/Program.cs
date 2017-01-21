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
<<<<<<< HEAD
			Console.SetBufferSize( 80, 25 );

			Walls walls = new Walls( 80, 25 );
			walls.Draw();
=======
			int x = 1;
			Func1( x );
			Console.WriteLine( "Call Func1. x = " + x );

			x = 1;
			Func2( x );
			Console.WriteLine( "Call Func2. x = " + x );

			x = 1;
			Func3( x );
			Console.WriteLine( "Call Func3. x = " + x );

			Point p1 = new Point( 1, 3, '*' );
			Move( p1, 10, 10 );
			Console.WriteLine( "Call Move. p1.x = " + p1.x + ", p1.y = " + p1.y );

			Point p2 = new Point( 4, 5, '#' );
			p1 = p2;
			p2.x = 8;
			p2.y = 8;
			Console.WriteLine( "p1 = p2. p1.x = " + p1.x + ", p1.y = " + p1.y + "; p2.x = " + p2.x + ", p2.y = " + p2.y );

			p1 = new Point( 1, 3, '*' );
			Update( p1 );
			Console.WriteLine( "Call Move. p1.x = " + p1.x + ", p1.y = " + p1.y );
>>>>>>> refs/remotes/Kartavec/lesson-5/RAM

			// Отрисовка точек			
			Point p = new Point( 4, 5, '*' );
			Snake snake = new Snake( p, 4, Direction.RIGHT );
			snake.Draw();

			FoodCreator foodCreator = new FoodCreator( 80, 25, '$' );
			Point food = foodCreator.CreateFood();
			food.Draw();

			while (true)
			{
				if ( walls.IsHit(snake) || snake.IsHitTail() )
				{
					break;
				}
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
				if ( Console.KeyAvailable )
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.HandleKey( key.Key );
				}
			}
			WriteGameOver();
			Console.ReadLine();
      }


		static void WriteGameOver()
		{
			int xOffset = 25;
			int yOffset = 8;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.SetCursorPosition( xOffset, yOffset++ );
			WriteText( "============================", xOffset, yOffset++ );
			WriteText( "И Г Р А    О К О Н Ч Е Н А", xOffset + 1, yOffset++ );
			yOffset++;
			WriteText( "Автор: Евгений Картавец", xOffset + 2, yOffset++ );
			WriteText( "Специально для GeekBrains", xOffset + 1, yOffset++ );
			WriteText( "============================", xOffset, yOffset++ );
		}

<<<<<<< HEAD
		static void WriteText( String text, int xOffset, int yOffset )
		{
			Console.SetCursorPosition( xOffset, yOffset );
			Console.WriteLine( text );
		}

=======
		public static void Func1( int value )
		{
			
		}

		public static void Func2( int value )
		{
			value = value + 1;
		}

		public static void Func3( int x )
		{
			x = x + 1;
		}

		public static void Move( Point p, int dx, int dy )
		{
			p.x = p.x + dx;
			p.y = p.y + dy;
		}

		public static void Update( Point p )
		{
			p = new Point();
		}


>>>>>>> refs/remotes/Kartavec/lesson-5/RAM
	}
}
