// <auto-generated />
using System;
using ChiuchApp.WebApi.Core3.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ChiuchApp.WebApi.Core3.Migrations
{
    [DbContext(typeof(PieceDbContext))]
    [Migration("20210306014216_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ChiuchApp.WebApi.Core3.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MainCategory")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("11111111-6a49-4a8b-bd00-ad3cc8e85924"),
                            Created = new DateTimeOffset(new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)),
                            Description = "Obouwie dla Niej i dla Niego",
                            MainCategory = "Odzież",
                            Name = "Buty"
                        },
                        new
                        {
                            Id = new Guid("22222222-6a49-4a8b-bd00-ad3cc8e85924"),
                            Created = new DateTimeOffset(new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)),
                            Description = "Okulary przeciwsłoneczne i korekcyjne",
                            MainCategory = "Dodatki",
                            Name = "Okulary"
                        },
                        new
                        {
                            Id = new Guid("33333333-6a49-4a8b-bd00-ad3cc8e85924"),
                            Created = new DateTimeOffset(new DateTime(2021, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)),
                            Description = "Sukienki dla Niej",
                            MainCategory = "Odzież",
                            Name = "Sukienki"
                        });
                });

            modelBuilder.Entity("ChiuchApp.WebApi.Core3.Entities.Piece", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Pieces");

                    b.HasData(
                        new
                        {
                            Id = new Guid("11111111-1111-4a8b-bd00-ad3cc8e85924"),
                            CategoryId = new Guid("11111111-6a49-4a8b-bd00-ad3cc8e85924"),
                            Description = "Białe półtrampki Converse",
                            Name = "Converse"
                        });
                });

            modelBuilder.Entity("ChiuchApp.WebApi.Core3.Entities.Piece", b =>
                {
                    b.HasOne("ChiuchApp.WebApi.Core3.Entities.Category", "Category")
                        .WithMany("Pieces")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ChiuchApp.WebApi.Core3.Entities.Category", b =>
                {
                    b.Navigation("Pieces");
                });
#pragma warning restore 612, 618
        }
    }
}
