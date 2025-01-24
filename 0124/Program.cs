using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0124
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Kérem adja meg az első számot: ");
			int elso = int.Parse(Console.ReadLine());

			Console.Write("Kérem adja meg a második számot: ");
			int masodik = int.Parse(Console.ReadLine());

			Console.Write("Az elvégzendő művelet jele: ");
			char jel = Console.ReadLine()[0];

			int eredmény = osszeadas(elso, masodik, jel);

			Console.WriteLine($"Az eredmény: {eredmény}");

			Console.WriteLine($"Az első szám: {elso}, a második szám: {masodik}, a művelet jele: {jel}");
		}

		static int osszeadas(int szam1, int szam2, char mj)
		{
			if (mj == '+')
			{
				return szam1 + szam2;
			}
			else if (mj == '-')
			{
				return szam1 - szam2;
			}
			else if (mj == '/')
			{
				if (szam2 != 0)
				{
					return szam1 / szam2;
				}
				else
				{
					Console.WriteLine("Hiba: Nullával való osztás nem lehetséges.");
					return 0;
				}
			}
			else if (mj == '*')
			{
				return szam1 * szam2;
			}
			else
			{
				Console.WriteLine("Ismeretlen művelet.");
				return 0;
			}
		}
	}
}
