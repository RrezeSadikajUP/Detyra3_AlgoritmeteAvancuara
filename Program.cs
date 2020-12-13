using System;

namespace Detyra3_HeightOfBinarySearchTree
{
	public class Nyja
	{
		public int data;
		public Nyja majtas, djathtas;

		public Nyja(int elementi)
		{
			data = elementi;
			majtas = djathtas = null;
		}
	}

	public class PemaBinare
	{
		Nyja rrenja;


		int thellesia_maksimale(Nyja nyja)
		{
			if (nyja == null)
				return 0;
			else
			{
				int thellesia_majtas = thellesia_maksimale(nyja.majtas);
				int thellesia_djathtas = thellesia_maksimale(nyja.djathtas);


				if (thellesia_majtas > thellesia_djathtas)
					return (thellesia_majtas + 1);
				else
					return (thellesia_djathtas + 1);
			}
		}

		public static void Main(String[] args)
		{
			PemaBinare pema = new PemaBinare();

			pema.rrenja = new Nyja(1);
			pema.rrenja.majtas = new Nyja(2);
			pema.rrenja.djathtas = new Nyja(3);
			pema.rrenja.majtas.majtas = new Nyja(4);
			pema.rrenja.majtas.djathtas = new Nyja(5);
			pema.rrenja.djathtas.majtas = new Nyja(6);
			pema.rrenja.djathtas.djathtas = new Nyja(7);
			pema.rrenja.djathtas.djathtas.djathtas = new Nyja(8);

			Console.WriteLine("Lartësia e pemës është : " +
										pema.thellesia_maksimale(pema.rrenja));
		}
	}
}
