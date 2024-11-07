using System;
namespace Casting_Implicit_Explicit_Operators_Generic
{
	public class Celsius
	{

		public double Degree { get; set; }
	
		public Celsius(double degree)
		{
			Degree = degree;
		}

		public static implicit operator Kelvin(Celsius celsius)
		{
			return new Kelvin(celsius.Degree + 237);
		}
	}
}

