using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Program
	{
		static void Main( string[] args )
		{
			int x = 1;
			IncFailed( x );
			Console.WriteLine( "Call IncFailed. x = " + x );

			x = 1;
			x = Inc( x );
			Console.WriteLine( "Call Inc. x = " + x );

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

		}

		public static void IncFailed( int value )
		{
			value = value + 1;
		}

		public static int Inc( int value )
		{
			return value + 1;
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


	}
}
