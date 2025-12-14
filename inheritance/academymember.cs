using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
	internal class AcademyMember:Human
	{
		public string Speciality { get; set; }
		public AcademyMember
			(
			string lastname, string firstname, int age,
			string speciality
			):base(lastname, firstname, age)

		{
			this.Speciality = speciality;
		}
	}
}
