using System;

public static class Globals
{
	internal static void Main()
	{
		int a;
		int n;
		int poz = 0;
        int nr;
		Console.Write("Introduceti numarul al carui pozitie se cauta:");
		Console.Write("\n");
		Console.Write("a= ");
		a = Convert.ToInt32(Console.ReadLine());
		Console.Write("Introduceti cate numere va contine sirul:");
		Console.Write("\n");
		Console.Write("n= ");
		n = Convert.ToInt32(Console.ReadLine());
		Console.Write("\n");

		for (int i = 0; i < n; i++)
		{
			
			nr = Convert.ToInt32(Console.ReadLine());

			if (nr == a)
			{
				poz = i+1;
				Console.Write("Pozitia numarului in secventa =  " + poz);
			}

		}
		Console.Write("-1");

	}
}