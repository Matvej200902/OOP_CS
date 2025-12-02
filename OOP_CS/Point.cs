using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CS {
	internal class Point {
		double x;
		double y;

		public double GetX()
		{
			return x;
		}
		public double GetY()
		{
			return y;
		}

		public void SetX(double x)
		{
			this.x = x;
		}
		public void SetY(double y)
		{
			this.y = y;
		}
		
		public double X {
			get
			{
				return x;
			}

			set
			{
				x = value;
			}
		}
		public double Y {
			get
			{
				return y;
			}

			set
			{
				y = value;
			}
		}
		public Point()
		{
			Console.WriteLine($"DefaultConstructor: {this.GetHashCode()}");
		}

		public Point(double x, double y)
		{
			this.X = x;
			this.Y = y;
			Console.WriteLine($"Constructor: {this.GetHashCode()}");
		}

		public Point(Point other)
		{
			this.X = other.x;
			this.Y = other.y;
			Console.WriteLine($"Copy: {this.GetHashCode()}");
		}

		~Point()
		{
			Console.WriteLine($"Destructor: {this.GetHashCode()}");
		}

		public static Point operator +(Point left, Point right)
		{
			//Point result = new Point
			//(
			//	left.X + right.X,
			//	left.Y + right.Y
			//);
			//return result;

			return new Point(
				left.X + right.X,
				left.Y + right.Y);
		}

		public static Point operator ++(Point obj)
		{
			obj.Y++;
			obj.X++;
			return new Point(obj);
		}

		public static bool operator ==(Point left, Point right)
		{
			return left.X == right.X && left.Y == right.Y;
		}
		public static bool operator !=(Point left, Point right)
		{
			return left.X != right.X || left.Y != right.Y;
		}
		public static bool operator >(Point left, Point right)
		{
			return left.X + left.Y > right.X + right.Y;
		}

		public static bool operator<(Point left, Point right)
		{
			return left.X + left.Y < right.X + right.Y;
		}

		public double Distance(Point other)
		{
			double x_distance = this.X - other.X;
			double y_distance = this.Y - other.Y;
			double distance = Math.Sqrt(x_distance * x_distance + y_distance * y_distance);
			return distance;
		}

		public void Print()
		{
			Console.WriteLine($"X = {x}\tY = {y}");
		}
	}
}
