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


		public static Book GetBookByTitle(Book[] books, string title)
		{
			foreach (var book in books)
			{
				if (AreTitlesEquals(book.Title, title))
				{
					return book;
				}
			}
			return null;
		}

		private static bool AreTitlesEquals(string title1, string title2)
		{
			if(title1.Length == title2.Length)
			{
				return false;
			}
			for (int i = 0; i < title1.Length; i++)
			{
				if(char.ToLower(title1[i]) != char.ToLower(title2[i]))
				{
					return false;
				}
			}
			return true;
		}

		public void EditBookData( string newtitle, string newauthor, int newpageCount, int newreleaseYear)
		{
			this.title = newtitle;
			this.author = newauthor;
			this.pageCount = newpageCount;
			this.releaseYear = newreleaseYear;
		}



		public override string? ToString()
		{
			return $"Cím: {title} / Író: {author} / Oldalai száma: {pageCount} / Megjelenési éve: {releaseYear}";
		}
	}
}
