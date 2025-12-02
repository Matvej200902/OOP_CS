//#define PROPERTIES
//#define CONSTRUCTORS
//#define INCROMENT
using System;

using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CS {
	internal class Program {
		static void Main(string[] args)
		{
#if PROPERTIES
			Point A = new Point();
			//A.SetX(2);
			//A.SetY(3);
			A.X = 2;
			A.Y = 3;
			A.Print();

			Point B = new Point();
			B.X = 7;
			B.Y = 8;
			B.Print();

			Console.WriteLine($"Расстояние: {A.Distance(B)}");
#endif
#if CONSTRUCTORS
			Point A = new Point(2, 3);
			Point B = new Point(7, 8);
			Console.WriteLine($"Расстояние: {A.Distance(B)}");

			Point C = new Point(A);

			Point D = A + B;

			D.Print();

			A += B;
			A.Print();
#endif
#if INCROMENT

			Point i = new Point(2, 3);
			Point j;
			for (; i.X < 10; i++) {
				i.Print();
			}
			Console.WriteLine("\n-----------------------------------------------\n");
			i.Print();
			j.X = 100;

			Console.WriteLine("\n-----------------------------------------------\n");
			i.Print();
#endif
			Point A = new Point(2, 3);
			Point B = new Point(7, 8);

			Console.WriteLine(A > B);
		}
	}
}

