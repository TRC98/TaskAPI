﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskAPI.DataAccess;

namespace TaskAPI.DataAccess.Migrations
{
    [DbContext(typeof(TodoDbContext))]
    [Migration("20220413101151_AuthorEntityAndData")]
    partial class AuthorEntityAndData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TaskAPI.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Author");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FullName = "Fiqri Ismail"
                        },
                        new
                        {
                            Id = 2,
                            FullName = "Prabashwara Bandara"
                        },
                        new
                        {
                            Id = 3,
                            FullName = "Chaminda Sooriyapperuma"
                        },
                        new
                        {
                            Id = 4,
                            FullName = "Hansamali Gamage"
                        });
                });

            modelBuilder.Entity("TaskAPI.Models.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Due")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Todos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Created = new DateTime(2022, 4, 13, 15, 41, 51, 122, DateTimeKind.Local).AddTicks(2079),
                            Description = "Get some text books for school",
                            Due = new DateTime(2022, 4, 18, 15, 41, 51, 122, DateTimeKind.Local).AddTicks(8488),
                            Status = 0,
                            Title = "Get books for school - DB"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 1,
                            Created = new DateTime(2022, 4, 13, 15, 41, 51, 123, DateTimeKind.Local).AddTicks(150),
                            Description = "Go to supermarket and buy some stuff",
                            Due = new DateTime(2022, 4, 18, 15, 41, 51, 123, DateTimeKind.Local).AddTicks(159),
                            Status = 0,
                            Title = "Need some grocceries"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 2,
                            Created = new DateTime(2022, 4, 13, 15, 41, 51, 123, DateTimeKind.Local).AddTicks(174),
                            Description = "Buy new camera",
                            Due = new DateTime(2022, 4, 18, 15, 41, 51, 123, DateTimeKind.Local).AddTicks(176),
                            Status = 0,
                            Title = "Purchase camera"
                        });
                });

            modelBuilder.Entity("TaskAPI.Models.Todo", b =>
                {
                    b.HasOne("TaskAPI.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });
#pragma warning restore 612, 618
        }
    }
}
