using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction {
	internal class Fraction {
		public int Integer { get; set; }
		public int Numerator { get; set; }

		int denominator;
		public int Denominator 
		{
			get => denominator;
			set
			{
				if (value == 0) value = 1;
				denominator = value;
			}
		}
	}
}

