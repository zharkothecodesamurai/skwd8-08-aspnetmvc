﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SEDC.WebApp.ModelDemo.DataAccess.DB;

namespace SEDC.WebApp.ModelDemo.DataAccess.Migrations
{
    [DbContext(typeof(PizzaDbContext))]
    partial class PizzaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SEDC.WebApp.ModelDemo.DataAccess.Domain.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Delivered");

                    b.Property<int?>("PizzaId");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("PizzaId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("SEDC.WebApp.ModelDemo.DataAccess.Domain.Models.Pizza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.Property<int>("Size");

                    b.HasKey("Id");

                    b.ToTable("Pizzas");

                    b.HasData(
                        new { Id = 1, Image = "Kapri.png", Name = "Kapri", Price = 7.0, Size = 2 },
                        new { Id = 2, Image = "Kapri.png", Name = "Kapri", Price = 7.0, Size = 3 },
                        new { Id = 3, Image = "Kapri.png", Name = "Kapri", Price = 7.0, Size = 4 },
                        new { Id = 4, Image = "Peperoni.png", Name = "Peperoni", Price = 9.0, Size = 2 },
                        new { Id = 5, Image = "Peperoni.png", Name = "Peperoni", Price = 8.0, Size = 3 },
                        new { Id = 6, Image = "Peperoni.png", Name = "Peperoni", Price = 8.0, Size = 4 },
                        new { Id = 7, Image = "Margarita.png", Name = "Margarita", Price = 10.5, Size = 2 },
                        new { Id = 8, Image = "Margarita.png", Name = "Margarita", Price = 10.5, Size = 4 },
                        new { Id = 9, Image = "Margarita.png", Name = "Margarita", Price = 10.5, Size = 4 },
                        new { Id = 10, Image = "Siciliana.png", Name = "Siciliana", Price = 6.5, Size = 2 },
                        new { Id = 11, Image = "Siciliana.png", Name = "Siciliana", Price = 9.5, Size = 3 },
                        new { Id = 12, Image = "Siciliana.png", Name = "Siciliana", Price = 9.5, Size = 4 }
                    );
                });

            modelBuilder.Entity("SEDC.WebApp.ModelDemo.DataAccess.Domain.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<long>("Phone");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new { Id = 1, Address = "Bob Street", FirstName = "Bob", LastName = "Bobsky", Phone = 80012312345L }
                    );
                });

            modelBuilder.Entity("SEDC.WebApp.ModelDemo.DataAccess.Domain.Models.Order", b =>
                {
                    b.HasOne("SEDC.WebApp.ModelDemo.DataAccess.Domain.Models.Pizza", "Pizza")
                        .WithMany()
                        .HasForeignKey("PizzaId");

                    b.HasOne("SEDC.WebApp.ModelDemo.DataAccess.Domain.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
