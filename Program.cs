using System;

namespace CalculateTriangleArea
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			double width = double.Parse(Console.ReadLine());
			double height = double.Parse(Console.ReadLine());

			double area = GetTriagleArea(width, height);

			Console.WriteLine(area);

		}

		public static double GetTriagleArea(double width, double height)
		{
			return width * height / 2;
		}
	}
}
