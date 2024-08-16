using BookStoreWeb.Models;
using BookStoreWeb.Models.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookStoreWeb.DataAccess.Data
{
    public class ApplicationDbContext: IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options) 
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        //public object GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { Id=1,Name="Action",DisplayOrder=1},
                new Category { Id=2,Name="SicFI",DisplayOrder=2},
                new Category { Id=3,Name="LifeLessons",DisplayOrder=3}
                );

            modelBuilder.Entity<Company>().HasData(
                new Company {
                Id=1,
                Name="Info Tech",
                StreetAddress="Omr Road",
                City="Chennai",
                State="Tamilnadu",
                PostalCode="60015",
                PhoneNumber="1234567890"},
                new Company {
                    Id=2,
                    Name = "Hybrid Soln",
                    StreetAddress = "ECR Road",
                    City = "Hyderabad",
                    State = "Telugana",
                    PostalCode = "70015",
                    PhoneNumber = "6789356289"
                },
                new Company {
                    Id=3,
                    Name = "RTO Mand Tech",
                    StreetAddress = "Park Road",
                    City = "Bangalore",
                    State = "Karnataka",
                    PostalCode = "90015",
                    PhoneNumber = "9876234560"
                }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Alexandrian Knights",
                    Author = "Lavik Jain",
                    Description = "Alexandrian Knights is an exciting story for children about four friends from the United States - Alex, Mike, Max, and Felix. On their adventure in Kuldhara, a mysterious village in Rajasthan, India, they find a secret temple. Magic from the temple turns them into Elemental Knights, each with their own special powers and strong armor. They solve tricky puzzles and learn new powers that show who they really are. This adventure teaches them about the importance of being brave and sticking together.\r\n\r\nIn the big final battle, they meet the Shadow Lord, a scary enemy who wants to cover the world in darkness. Can they use their new powers and friendship to beat him and make the world safe again? ",
                    ISBN = "978-93--941055-25-6",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId=1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 2,
                    Title = "The Theory Of Everything",
                    Author = "Stephen Hawking",
                    Description = "Seven lectures by the brilliant theoretical physicist have been compiled into this book to try to explain to the common man, the complex problems of mathematics and the question that has been gripped everyone all for centuries, the theory of existence. ",
                    ISBN = "878-93--941055-25-7",
                    ListPrice = 40,
                    Price = 30,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    Title = "You Can",
                    Author = "George Matthew Adams ",
                    Description = "Do you often wonder whether you really have it in you to accomplish your goals, to win over obstacles, and to succeed in life? Through the empowering self-help manual you can, penned to promote personal growth and well-being for anyone who reads it.",
                    ISBN = "778-93--941055-25-8",
                    ListPrice = 55,
                    Price = 50,
                    Price50 = 40,
                    Price100 = 35,
                    CategoryId = 3,
                    ImageUrl=""
                },
                new Product
                {
                    Id = 4,
                    Title = "Touch of Eternity",
                    Author = "Durjoy, Datta",
                    Description = "Born on the same day and at the same time, Druvan and Anvesha know they are soulmates in every sense of the word. Their parents, however, refuse to accept their 'togetherness' at first and try to tear them apart. Druvan and Anvesha try their best to explain why that cannot happen. ",
                    ISBN = "678-93--941055-25-9",
                    ListPrice = 70,
                    Price = 65,
                    Price50 = 60,
                    Price100 = 55,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 5,
                    Title = "You Only Live Once",
                    Author = "Stuti Changle",
                    Description = "Find the answers about your own life in this story about searching for love and discovering yourself. Join a broken but rising YouTube star Alara, a struggling but hopeful stand-up comedian Aarav, and a zany but zen beach shack owner Ricky. Together, take the journey to seek the truth behind the famous singer Elisha's disappearance somewhere by the deep sea in Goa. ",
                    ISBN = "578-93--941055-26-1",
                    ListPrice = 30,
                    Price = 27,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 6,
                    Title = "You are the Best Friend",
                    Author = "Ajay K Pandey ",
                    Description = "You might come across love many times in life;\r\nbut the one that you experience with your best friend is etched for eternity.",
                    ISBN = "478-93--941055-26-2",
                    ListPrice = 25,
                    Price = 23,
                    Price50 = 22,
                    Price100 = 20,
                    CategoryId = 3,
                    ImageUrl = ""
                });

        }
    }
}
