using EcomWebLocal.Models;
using Microsoft.EntityFrameworkCore;

namespace EcomWebLocal.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Fantasy", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Thriller", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Harry Potter and the Sorcerer’s Stone",
                    Author = "J.K. Rowling",
                    Description = "Harry Potter, the boy who lived",
                    ISBN = "9781781106501",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80
                },
               new Product
               {
                   Id = 2,
                   Title = "Harry Potter and the Sorcerer’s Stone",
                   Author = "J.K. Rowling",
                   Description = "Harry Potter, the boy who lived",
                   ISBN = "9781781106501",
                   ListPrice = 40,
                   Price = 30,
                   Price50 = 25,
                   Price100 = 20
               },
                new Product
                {
                    Id = 3,
                    Title = "Harry Potter and the Sorcerer’s Stone",
                    Author = "J.K. Rowling",
                    Description = "Harry Potter, the boy who lived",
                    ISBN = "9781781106501",
                    ListPrice = 55,
                    Price = 50,
                    Price50 = 40,
                    Price100 = 35
                },
                new Product
                {
                    Id = 4,
                    Title = "Harry Potter and the Sorcerer’s Stone",
                    Author = "J.K. Rowling",
                    Description = "Harry Potter, the boy who lived",
                    ISBN = "9781781106501",
                    ListPrice = 70,
                    Price = 65,
                    Price50 = 60,
                    Price100 = 55
                },
                new Product
                {
                    Id = 5,
                    Title = "Harry Potter and the Sorcerer’s Stone",
                    Author = "J.K. Rowling",
                    Description = "Harry Potter, the boy who lived",
                    ISBN = "9781781106501",
                    ListPrice = 30,
                    Price = 27,
                    Price50 = 25,
                    Price100 = 20
                },
                new Product
                {
                    Id = 6,
                    Title = "Harry Potter and the Sorcerer’s Stone",
                    Author = "J.K. Rowling",
                    Description = "Harry Potter, the boy who lived",
                    ISBN = "9781781106501",
                    ListPrice = 25,
                    Price = 23,
                    Price50 = 22,
                    Price100 = 20
                }
               );
        }
    }
}
