namespace konyvtarMA
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Book konyv1 = new("Egri csillagok", "Gárdonyi Géza", 500, 1901);
			Book konyv2 = new("Pál utcai fiúk", "Molnár Ferenc", 220, 1906);
			Book konyv3 = new("A kis herceg", "Antoine de Saint-Exupéry", 96, 1943);

            Console.WriteLine(konyv1);
			Console.WriteLine(konyv2);
			Console.WriteLine(konyv3);

            Console.WriteLine();
            Console.WriteLine();

            konyv1.EditBookData("Finlandia", "Gáspár Győző", 5000, 2016);
			Console.WriteLine(konyv1);

			Book[] books = new Book[] {konyv1, konyv2, konyv3};

			Book keresett = Book.GetBookByTitle(books, "Egri csillagok");

			if (keresett != null)
			{
                Console.WriteLine($"Létezik ilyen könyv: {keresett}");
            }
			else
			{
                Console.WriteLine("Sajnos nincs ilyen könyv");
            }
        }
	}
}
