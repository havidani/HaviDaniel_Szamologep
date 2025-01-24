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

			Console.WriteLine($"Az első szám: {elso}, a második szám: {masodik}, a művelet jele: {jel}");
		}
	}
}
