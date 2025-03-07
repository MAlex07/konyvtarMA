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

            konyv1.EditBookData();
			Console.WriteLine(konyv1);
        }
	}
}
