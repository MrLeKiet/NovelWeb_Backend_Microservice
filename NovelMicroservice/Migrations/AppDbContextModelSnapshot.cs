﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NovelMicroservice.Data;

#nullable disable

namespace NovelMicroservice.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("NovelMicroservice.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CategoryID"));

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            ImageUrl = "https://media.istockphoto.com/id/177321629/vi/anh/nh%C3%B3m-tr%E1%BA%BB-em-c%C3%B3-d%E1%BA%A5u-hi%E1%BB%87u-gi%C6%A1-ng%C3%B3n-tay-c%C3%A1i-l%C3%AAn.jpg?s=2048x2048&w=is&k=20&c=osGSOiFdJ-A3QB5UOD06R22vFACOAc9A5MYddfV4EBs=",
                            Name = "Children"
                        },
                        new
                        {
                            CategoryID = 2,
                            ImageUrl = "https://media.istockphoto.com/id/1198829958/photo/group-of-five-scary-figures-in-hooded-cloaks-in-the-dark.jpg?s=612x612&w=0&k=20&c=Vjx6Kz6zpdqPrUr1RAUyXWwcOlsy64vd6_ENdPl-r0E=",
                            Name = "Horror"
                        },
                        new
                        {
                            CategoryID = 3,
                            ImageUrl = "https://media.istockphoto.com/id/688410346/vector/chinese-style-fantasy-scenes.jpg?s=612x612&w=0&k=20&c=r3skS5InspYQ7EqUCCzUzU3QHcwRwD6mNRbDpP8sIG4=",
                            Name = "Fantasy"
                        });
                });

            modelBuilder.Entity("NovelMicroservice.Models.Chapter", b =>
                {
                    b.Property<int>("ChapterID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ChapterID"));

                    b.Property<int>("ChapterNumber")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("NovelID")
                        .HasColumnType("int");

                    b.HasKey("ChapterID");

                    b.HasIndex("NovelID");

                    b.ToTable("Chapters");

                    b.HasData(
                        new
                        {
                            ChapterID = 1,
                            ChapterNumber = 1,
                            Content = "Once upon a time...",
                            NovelID = 1
                        },
                        new
                        {
                            ChapterID = 2,
                            ChapterNumber = 2,
                            Content = "The journey begins.",
                            NovelID = 1
                        },
                        new
                        {
                            ChapterID = 3,
                            ChapterNumber = 1,
                            Content = "In the shadows of the night.",
                            NovelID = 2
                        },
                        new
                        {
                            ChapterID = 4,
                            ChapterNumber = 1,
                            Content = "The boy who lived.",
                            NovelID = 3
                        });
                });

            modelBuilder.Entity("NovelMicroservice.Models.Novel", b =>
                {
                    b.Property<int>("NovelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("NovelID"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("NovelID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Novels");

                    b.HasData(
                        new
                        {
                            NovelID = 1,
                            Author = "Antoine de Saint-Exupéry",
                            CategoryID = 1,
                            Description = "A timeless story of a young prince and his adventures.",
                            ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/71OZY035QKL.jpg",
                            Name = "The Little Prince"
                        },
                        new
                        {
                            NovelID = 2,
                            Author = "Bram Stoker",
                            CategoryID = 2,
                            Description = "The classic vampire tale that started it all.",
                            ImageUrl = "https://cdn.kobo.com/book-images/88a05cf1-a3b6-461b-a8f7-f0e25b06274a/1200/1200/False/dracula-bram-stoker.jpg",
                            Name = "Dracula"
                        },
                        new
                        {
                            NovelID = 3,
                            Author = "J.K. Rowling",
                            CategoryID = 3,
                            Description = "A young wizard's journey through magic and friendship.",
                            ImageUrl = "https://nhasachphuongnam.com/images/detailed/160/81YOuOGFCJL.jpg",
                            Name = "Harry Potter"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
