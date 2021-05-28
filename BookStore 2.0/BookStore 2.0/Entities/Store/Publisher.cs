using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_2._0.Entities.Store
{
	public class Publisher
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public byte[] Image { get; set; }
		public virtual ICollection<Book> Books { get; set; }
	}
}
