﻿// <auto-generated />
using System;
using BookStoreWeb.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookStoreWeb.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240812120422_AddImageUrlToProduct")]
    partial class AddImageUrlToProduct
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookStoreWeb.Models.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "SicFI"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "LifeLessons"
                        });
                });

            modelBuilder.Entity("BookStoreWeb.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ListPrice")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Price100")
                        .HasColumnType("float");

                    b.Property<double>("Price50")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Lavik Jain",
                            CategoryId = 1,
                            Description = "Alexandrian Knights is an exciting story for children about four friends from the United States - Alex, Mike, Max, and Felix. On their adventure in Kuldhara, a mysterious village in Rajasthan, India, they find a secret temple. Magic from the temple turns them into Elemental Knights, each with their own special powers and strong armor. They solve tricky puzzles and learn new powers that show who they really are. This adventure teaches them about the importance of being brave and sticking together.\r\n\r\nIn the big final battle, they meet the Shadow Lord, a scary enemy who wants to cover the world in darkness. Can they use their new powers and friendship to beat him and make the world safe again? ",
                            ISBN = "978-93--941055-25-6",
                            ImageUrl = "",
                            ListPrice = 99.0,
                            Price = 90.0,
                            Price100 = 80.0,
                            Price50 = 85.0,
                            Title = "Alexandrian Knights"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Stephen Hawking",
                            CategoryId = 2,
                            Description = "Seven lectures by the brilliant theoretical physicist have been compiled into this book to try to explain to the common man, the complex problems of mathematics and the question that has been gripped everyone all for centuries, the theory of existence. ",
                            ISBN = "878-93--941055-25-7",
                            ImageUrl = "",
                            ListPrice = 40.0,
                            Price = 30.0,
                            Price100 = 20.0,
                            Price50 = 25.0,
                            Title = "The Theory Of Everything"
                        },
                        new
                        {
                            Id = 3,
                            Author = "George Matthew Adams ",
                            CategoryId = 3,
                            Description = "Do you often wonder whether you really have it in you to accomplish your goals, to win over obstacles, and to succeed in life? Through the empowering self-help manual you can, penned to promote personal growth and well-being for anyone who reads it.",
                            ISBN = "778-93--941055-25-8",
                            ImageUrl = "",
                            ListPrice = 55.0,
                            Price = 50.0,
                            Price100 = 35.0,
                            Price50 = 40.0,
                            Title = "You Can"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Durjoy, Datta",
                            CategoryId = 3,
                            Description = "Born on the same day and at the same time, Druvan and Anvesha know they are soulmates in every sense of the word. Their parents, however, refuse to accept their 'togetherness' at first and try to tear them apart. Druvan and Anvesha try their best to explain why that cannot happen. ",
                            ISBN = "678-93--941055-25-9",
                            ImageUrl = "",
                            ListPrice = 70.0,
                            Price = 65.0,
                            Price100 = 55.0,
                            Price50 = 60.0,
                            Title = "Touch of Eternity"
                        },
                        new
                        {
                            Id = 5,
                            Author = "Stuti Changle",
                            CategoryId = 3,
                            Description = "Find the answers about your own life in this story about searching for love and discovering yourself. Join a broken but rising YouTube star Alara, a struggling but hopeful stand-up comedian Aarav, and a zany but zen beach shack owner Ricky. Together, take the journey to seek the truth behind the famous singer Elisha's disappearance somewhere by the deep sea in Goa. ",
                            ISBN = "578-93--941055-26-1",
                            ImageUrl = "",
                            ListPrice = 30.0,
                            Price = 27.0,
                            Price100 = 20.0,
                            Price50 = 25.0,
                            Title = "You Only Live Once"
                        },
                        new
                        {
                            Id = 6,
                            Author = "Ajay K Pandey ",
                            CategoryId = 3,
                            Description = "You might come across love many times in life;\r\nbut the one that you experience with your best friend is etched for eternity.",
                            ISBN = "478-93--941055-26-2",
                            ImageUrl = "",
                            ListPrice = 25.0,
                            Price = 23.0,
                            Price100 = 20.0,
                            Price50 = 22.0,
                            Title = "You are the Best Friend"
                        });
                });

            modelBuilder.Entity("BookStoreWeb.Models.Product", b =>
                {
                    b.HasOne("BookStoreWeb.Models.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
