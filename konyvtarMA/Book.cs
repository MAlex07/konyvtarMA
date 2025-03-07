using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konyvtarMA
{
	internal class Book
	{
		private string title;
		private string author;
		private int pageCount;
		private int releaseYear;

		public Book(string title, string author, int pageCount, int releaseYear)
		{
			this.title = title;
			this.author = author;
			this.pageCount = pageCount;
			this.releaseYear = releaseYear;
		}

		public string Title { get => title; set => title = value; }
		public string Author { get => author; set => author = value; }
		public int PageCount { get => pageCount; set => pageCount = value; }
		public int ReleaseYear { get => releaseYear; set => releaseYear = value; }


		public void GetBookByTitle(Book[] books, string title)
		{

		}

		public void EditBookData()
		{
			this.title = "Top gear";
			this.author = "Gáspár Győző";
			this.pageCount = 576;
			this.releaseYear = 1976;
		}



		public override string? ToString()
		{
			return $"Cím: {title} / Író: {author} / Oldalai száma: {pageCount} / Megjelenési éve: {releaseYear}";
		}
	}
}
