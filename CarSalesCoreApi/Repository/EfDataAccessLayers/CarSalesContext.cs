using CarSalesCoreApi.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSalesCoreApi.Repository
{
    public class CarSalesContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-PQF4L5Q\SQLEXPRESS;Initial Catalog=CarSalesDB;Integrated Security=True");
        }
        public DbSet<Category> Category { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Adress> Adress { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<District> District { get; set; }
        public DbSet<Model> Model { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<CarBrand> CarBrand { get; set; }
        public DbSet<Car> Car { get; set; }
        public DbSet<Favorite> Favorite { get; set; }
    }
}
