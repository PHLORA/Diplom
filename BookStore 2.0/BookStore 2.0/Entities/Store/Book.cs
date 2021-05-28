using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_2._0.Entities.Store
{
	public class Book
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int Price { get; set; }
		public int? Discount { get; set; }
		public string Language { get; set; }
		public string Cover { get; set; }
		public int Pages { get; set; }
		public byte[] Image { get; set; }
		public DateTime PublicationDate { get; set; }
		public bool isFavourite { get; set; }
		public virtual Publisher Publisher { get; set; }
		public virtual ICollection <Author> Authors { get; set; }
		public virtual ICollection<Genre> Genres { get; set; }
	}
}
