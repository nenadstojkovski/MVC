using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaHut.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        {
        }

        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<PizzaType> PizzaTypes { get; set; }
        public DbSet<User> Users { get; set; }
         
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PizzaType>().HasData(
                new PizzaType { ID = 1, Name = "Capri", Description = "dough, ham, mashrums" },
                new PizzaType { ID = 2, Name = "Quatro", Description = "dough, cheese, mashrums" },
                new PizzaType { ID = 3, Name = "Vege", Description = "dough, vegetables, mashrums" }
                );

            modelBuilder.Entity<User>().HasData(
                new User { ID = 1, Name = "Bojan", Address = "Partizanska", City = "Skopje", Email = "bojan@abc.com", Phone = "078123123" },
                new User { ID = 2, Name = "Viktor", Address = "Vodnjanska", City = "Stip", Email = "viktor@abc.com", Phone = "078123123" },
                new User { ID = 3, Name = "Dejan", Address = "R. Luxemburg", City = "Bitola", Email = "dejan@abc.com", Phone = "078123123" }
                );
        }
    }
}
