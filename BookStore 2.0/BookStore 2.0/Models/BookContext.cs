using BookStore_2._0.Entities.Store;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_2._0.Models
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Publisher> Publishers { get; set; }


        public BookContext(DbContextOptions<BookContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Genre>().HasData(
                new Genre { Id = 1, Name = "Сказки" },
                new Genre { Id = 2, Name = "Стихи" },
                new Genre { Id = 3, Name = "Приключения" },
                new Genre { Id = 4, Name = "Фантастика" },
                new Genre { Id = 5, Name = "Детективы" },
                new Genre { Id = 7, Name = "Энциклопедии" }
                );
            modelBuilder.Entity<Book>().HasData(
               new Book { Id = 1, Name = "Пан Коцкий", Description = "Something about this book" }
               );
        }
    }
}
