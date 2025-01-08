﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentManagementWebApp.Data;

#nullable disable

namespace StudentManagementWebApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StudentManagementWebApp.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.PrimitiveCollection<string>("Marks")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 20,
                            Marks = "[85,90,78]",
                            Name = "John"
                        },
                        new
                        {
                            Id = 2,
                            Age = 22,
                            Marks = "[92,88,94]",
                            Name = "Alice"
                        },
                        new
                        {
                            Id = 3,
                            Age = 21,
                            Marks = "[75,80,70]",
                            Name = "Bob"
                        },
                        new
                        {
                            Id = 4,
                            Age = 23,
                            Marks = "[65,70,80]",
                            Name = "Charlie"
                        },
                        new
                        {
                            Id = 5,
                            Age = 24,
                            Marks = "[88,90,85]",
                            Name = "David"
                        },
                        new
                        {
                            Id = 6,
                            Age = 19,
                            Marks = "[78,82,80]",
                            Name = "Eve"
                        },
                        new
                        {
                            Id = 7,
                            Age = 20,
                            Marks = "[92,95,91]",
                            Name = "Frank"
                        },
                        new
                        {
                            Id = 8,
                            Age = 22,
                            Marks = "[70,72,68]",
                            Name = "Grace"
                        },
                        new
                        {
                            Id = 9,
                            Age = 21,
                            Marks = "[90,88,85]",
                            Name = "Hannah"
                        },
                        new
                        {
                            Id = 10,
                            Age = 23,
                            Marks = "[80,85,78]",
                            Name = "Ivy"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
