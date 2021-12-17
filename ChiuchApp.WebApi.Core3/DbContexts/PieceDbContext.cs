using ChiuchApp.WebApi.Core3.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiuchApp.WebApi.Core3.DbContexts
{
    public class PieceDbContext : DbContext
    {
        public PieceDbContext(DbContextOptions<PieceDbContext> options) : base(options)
        {

        }
        
        public DbSet<Category> Categories { get; set; }
        public DbSet<Piece> Pieces { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //seed
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = Guid.Parse("{11111111-6A49-4A8B-BD00-AD3CC8E85924}"),
                    Name = "Buty",
                    Description = "Obouwie dla Niej i dla Niego",
                    Created = new DateTime(2021, 02, 01),
                    MainCategory = "Odzież"
                },
                new Category()
                {
                    Id = Guid.Parse("{22222222-6A49-4A8B-BD00-AD3CC8E85924}"),
                    Name = "Okulary",
                    Description = "Okulary przeciwsłoneczne i korekcyjne",
                    Created = new DateTime(2021, 02, 02),
                    MainCategory = "Dodatki"
                },
                new Category()
                {
                    Id = Guid.Parse("{33333333-6A49-4A8B-BD00-AD3CC8E85924}"),
                    Name = "Sukienki",
                    Description = "Sukienki dla Niej",
                    Created = new DateTime(2021, 02, 03),
                    MainCategory = "Odzież"
                });

            modelBuilder.Entity<Piece>().HasData(
                new Piece()
                {
                    Id = Guid.Parse("{11111111-1111-4A8B-BD00-AD3CC8E85924}"),
                    Name = "Converse",
                    CategoryId = Guid.Parse("{11111111-6A49-4A8B-BD00-AD3CC8E85924}"),
                    Description ="Białe półtrampki Converse"             
                });

        }
    }
}
