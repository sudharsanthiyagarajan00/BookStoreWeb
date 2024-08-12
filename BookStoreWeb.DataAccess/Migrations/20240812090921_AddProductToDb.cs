using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStoreWeb.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddProductToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "Lavik Jain", "Alexandrian Knights is an exciting story for children about four friends from the United States - Alex, Mike, Max, and Felix. On their adventure in Kuldhara, a mysterious village in Rajasthan, India, they find a secret temple. Magic from the temple turns them into Elemental Knights, each with their own special powers and strong armor. They solve tricky puzzles and learn new powers that show who they really are. This adventure teaches them about the importance of being brave and sticking together.\r\n\r\nIn the big final battle, they meet the Shadow Lord, a scary enemy who wants to cover the world in darkness. Can they use their new powers and friendship to beat him and make the world safe again? ", "978-93--941055-25-6", 99.0, 90.0, 80.0, 85.0, "Alexandrian Knights" },
                    { 2, "Stephen Hawking", "Seven lectures by the brilliant theoretical physicist have been compiled into this book to try to explain to the common man, the complex problems of mathematics and the question that has been gripped everyone all for centuries, the theory of existence. ", "878-93--941055-25-7", 40.0, 30.0, 20.0, 25.0, "The Theory Of Everything" },
                    { 3, "George Matthew Adams ", "Do you often wonder whether you really have it in you to accomplish your goals, to win over obstacles, and to succeed in life? Through the empowering self-help manual you can, penned to promote personal growth and well-being for anyone who reads it.", "778-93--941055-25-8", 55.0, 50.0, 35.0, 40.0, "You Can" },
                    { 4, "Durjoy, Datta", "Born on the same day and at the same time, Druvan and Anvesha know they are soulmates in every sense of the word. Their parents, however, refuse to accept their 'togetherness' at first and try to tear them apart. Druvan and Anvesha try their best to explain why that cannot happen. ", "678-93--941055-25-9", 70.0, 65.0, 55.0, 60.0, "Touch of Eternity" },
                    { 5, "Stuti Changle", "Find the answers about your own life in this story about searching for love and discovering yourself. Join a broken but rising YouTube star Alara, a struggling but hopeful stand-up comedian Aarav, and a zany but zen beach shack owner Ricky. Together, take the journey to seek the truth behind the famous singer Elisha's disappearance somewhere by the deep sea in Goa. ", "578-93--941055-26-1", 30.0, 27.0, 20.0, 25.0, "You Only Live Once" },
                    { 6, "Ajay K Pandey ", "You might come across love many times in life;\r\nbut the one that you experience with your best friend is etched for eternity.", "478-93--941055-26-2", 25.0, 23.0, 20.0, 22.0, "You are the Best Friend" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
