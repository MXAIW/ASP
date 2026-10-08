using System.Numerics;

namespace Blazor.Components.Pages
{
	public partial class Factorial
	{
		int n; // Исходное число для вычисления факториала
		BigInteger f = 1; //Факториал
		void Calculate()
		{
			f = 1;
			for (int i = 1; i <= n; i++)
			{
				f *= i;
			}
		}
	}
}
