using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project2104.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shoes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Shoes",
                columns: new[] { "Id", "Category", "Description", "Image", "Name", "Price", "UserId" },
                values: new object[,]
                {
                    { 1, "M", "Inspired by the original that debuted in 1985, the Air Jordan 1 Low offers a clean, classic look that's familiar yet always fresh. With an iconic design that pairs perfectly with any 'fit, these kicks ensure you'll always be on point. Encapsulated Air-Sole unit provides lightweight cushioning.", "https://lemkus.com/cdn/shop/products/553558-066-1.png?v=1680251200", "Air Jordan 1 Low ", 166.59999999999999, null },
                    { 2, "M", "The Terminator Low lets you step back to the era of hook shots, knee pads and calf-high socks. Pulling inspiration from the \"Be True To Your School\" ad campaign (and 1 of the 7 original colorways released in '85), it ups your game with spirited team colors.", "https://lemkus.com/cdn/shop/files/Layer_3544.png?v=1688466136", "Nike Terminator Low", 173.84, null },
                    { 3, "M", "A tribute to the legendary Chicago skyline used to create the Jumpman logo, this Air Jordan 1 Mid features an iconic colorway. The tongue features the original image, while the sole and side feature the Chicago sunset shade. The encapsulated Air-Sole unit provides the right amount of cushioning with every step.\r\n", "https://lemkus.com/cdn/shop/files/FB2212-100-1.png?v=1690381031", "AIR JORDAN 1 MID SS (GS)", 159.34999999999999, null },
                    { 4, "W", "A tribute to the legendary Chicago skyline used to create the Jumpman logo, this Air Jordan 1 Mid features an iconic colorway. The tongue features the original image, while the sole and side feature the Chicago sunset shade. The encapsulated Air-Sole unit provides the right amount of cushioning with every step.", "https://lemkus.com/cdn/shop/files/DZ3745-500-1.png?v=1690014771", "AIR JORDAN 1 MID SE (W)", 202.83000000000001, null },
                    { 5, "W", "A tribute to the legendary Chicago skyline used to create the Jumpman logo, this Air Jordan 1 Mid features an iconic colorway. The tongue features the original image, while the sole and side feature the Chicago sunset shade. The encapsulated Air-Sole unit provides the right amount of cushioning with every step.", "https://lemkus.com/cdn/shop/files/DZ3745-300-1.png?v=1688479640", "AIR JORDAN 1 MID SE (W)", 202.80000000000001, null },
                    { 6, "W", "You don't need to play \"either or\" when it comes to choosing style or comfort with this one—which is nice, 'cause you deserve both. Nike Air technology absorbs impact for cushioning with every step. Suede on the upper and toe breaks in easily and contours to your feet. Formula 23 foam keeps your feet extra padded.", "https://lemkus.com/cdn/shop/files/FJ4652-100-1.png?v=1686142393", "AIR JORDAN 1 ZOOM CMFT 2 (W)", 217.31999999999999, null },
                    { 7, "M", "The newly reissued 580 brings an icon back to life. The modernized look of a slimmed down toe and reduced collar height is combined with construction that comes as close to a one-to-one recreation of the OG materials, compounds, and features as humanly possible.", "https://lemkus.com/cdn/shop/files/MT580HSB-1.png?v=1683273697", "580 LIFESTYLE", 156.44999999999999, null },
                    { 8, "M", "The 9060 reinterprets familiar elements sourced from classic 99X models with a warped sensibility inspired by the proudly futuristic, visible tech aesthetic of the Y2K era.", "https://lemkus.com/cdn/shop/products/U9060TRU-1.png?v=1681456799", "9060 LIFESTYLE", 173.84, null },
                    { 9, "M", "This redesigned version of the shoes honours those roots with a suede upper that nods to their smart beginnings. Perforated details on the toe and the flex on the heel add a pop of retro texture, just like the grooved tread. And you can't miss the 3-Stripes style along the sides.", "https://lemkus.com/cdn/shop/products/FZ5880-5.png?v=1675684622", "CENTENNIAL 85 LOW", 137.61000000000001, null },
                    { 10, "M", "The adidas NMD — short for Nomad — is a popular casual sneaker that combines old design concepts with new technology, particularly Boost cushioning and occasional Primeknit uppers.", "https://lemkus.com/cdn/shop/products/HQ4452_1.png?v=1671352439", "NMD_R1", 154.63999999999999, null },
                    { 11, "M", "Textile lining provides strength and durability. Primegreen recycled materials used in the upper represent one of the solutions to help end plastic waste. Lace closure ensures a snug fit. Rubber outsole offers maximum traction and grip.", "https://lemkus.com/cdn/shop/products/GX5784_1.png?v=1653467764", "NMD V3", 224.56999999999999, null },
                    { 12, "W", "Textile lining provides strength and durability. Primegreen recycled materials used in the upper represent one of the solutions to help end plastic waste. Lace closure ensures a snug fit. Rubber outsole offers maximum traction and grip.", "https://lemkus.com/cdn/shop/products/GX5785_1.png?v=1658739934", "NMD V3 (W)", 224.56999999999999, null },
                    { 13, "W", "The crisp leather on the upper has a slight sheen, ages to soft perfection and features durable overlays reminiscent of '80s b-ball. The foam midsole offers lightweight, responsive cushioning. The padded, low-cut collar adds a sleek look that feels comfortable.", "https://lemkus.com/cdn/shop/files/FN7773-001-1.png?v=1688473932", "DUNK LOW (W)", 173.84, null },
                    { 14, "M", "Tongue top and modified overlay in the upper add classic comfort and refer to the AJ6. Semi-bootie lining rounds off the look and refers to the AJ7. Embroidered Nike Air heel logo inspired the AJ6 and the moulded heel detail taken from the AJ8 give an iconic finish.", "https://lemkus.com/cdn/shop/files/DZ5577-168-1.png?v=1688737178", "JORDAN MVP (GS)", 173.84, null },
                    { 15, "M", "This shoe features a vibrant orange and yellow colorway inspired by the popular fire-type Pokemon, Charmander. The upper is constructed with a mix of suede and leather materials, providing durability and a premium feel.", "https://lemkus.com/cdn/shop/products/387686_01-1.png?v=1670315077", "SLIPSTREAM CHARMANDER", 154.63999999999999, null },
                    { 16, "M", "PUMA x COCA-COLA is the coming together of two iconic brands who share a profound history, a sense of positivity, and an ability to move culture forward.", "https://lemkus.com/cdn/shop/products/38704201-1.png?v=1675241004", "WILO COCA COLA RACING", 94.129999999999995, null },
                    { 17, "W", "The Nike Air Force 1 '07 is back with crisp leather, bold colors, and classic Nike cutlines. The upper comes with stitched leather overlays that stay true to their predecessor and deliver reliable support. The foam midsole offers the perfect amount of cushioning, while the perforations on the toe enhance airflow.", "https://lemkus.com/cdn/shop/files/Layer_3544_61f7c5d3-67dc-4f02-84ce-ca98e0e45ee0.png?v=1688471755", "AIR FORCE 1 '07 LOW (W)", 173.84, null },
                    { 18, "K", "The low-top kicks are made from real and synthetic leather that's durable and brings a classic feel. The shape gives toes more wiggle room and the fit helps keep growing feet comfortable. The Max Air unit has a softer feel that's tuned right for kids. Plus, comfy and flexible foam makes for easy steps.", "https://lemkus.com/cdn/shop/files/DV3608-103-1.png?v=1683192772", "AIR max 90 LTR (PS)", 90.319999999999993, null },
                    { 19, "K", "The Nike Air Max 90 takes the original look to a new level with more comfort and flexibility. It keeps the classic Max Air cushioning you know and love. The '90s look has leather and synthetic leather to make it durable and easy to clean. A Max Air unit provides the same lightweight cushioning as the original.", "https://lemkus.com/cdn/shop/products/CD6868-009-1.png?v=1680094361", "AIR MAX 90 LTR (TD)", 90.319999999999993, null },
                    { 20, "K", "Ride the '90s style wave with the Nike Air Force 1 LV8 2 TD “Panda.” Teaming up that classic AF1 look with a bold era-echoing colour block, this remixed sneaker also features smooth durable leather and a hidden Air-Sole unit for comfort.", "https://lemkus.com/cdn/shop/products/DV1624-001-1.png?v=1677054466", "FORCE 1 LV8 2 (TD)", 100.5, null },
                    { 21, "K", "The one-piece design slips", "https://lemkus.com/cdn/shop/products/GY9148_1.png?v=1673347669", "NMD 360 (TD)", 80.900000000000006, null },
                    { 22, "W", "Durable leather upper is made for everyday wear. Originally designed for performance running, the visible Max Air unit provides all-day cushioning. Padded, low-cut collar looks sleek and feels comfortable. 2 sets of laces let you switch up your style.", "https://lemkus.com/cdn/shop/files/FJ5479-410-1.png?v=1686563041", "AIR MAX 1 PRM (W)", 231.81, null },
                    { 23, "M", "It features a white and University Red smooth leather upper with black leather collars and red Swooshes. From there, a black and red woven Nike tongue label and an Air sole at the base completes the design.", "https://lemkus.com/cdn/shop/files/DZ5485-400-1.png?v=1688654367", "AIR JORDAN 1 RETRO HI OG", 253.63, null },
                    { 24, "W", "The '80s b-ball icon returns with classic details and throwback hoops flair. Channeling vintage style back onto the streets, its padded collar and extra-puffy silhouette let you take your game anywhere—in comfort. Leather in the upper softens and gains vintage character with wear.", "https://lemkus.com/cdn/shop/files/DZ2794-100-1.png?v=1690365351", "DUNK LOW TWIST (W)", 173.84, null },
                    { 25, "M", "The Air Jordan 1 never misses an opportunity to enhance comfort alongside iconic designs. In this Zoom Air CMFT 2, the cushioning technology helps rebound from the road and a responsive ride all day. Style and comfort in the most contemporary silhouette.", "https://lemkus.com/cdn/shop/files/DV1307-107-1.png?v=1688725892", "AIR JORDAN 1 ZM AIR CMFT 2", 224.56999999999999, null },
                    { 26, "W", "This iteration of the AJ1 reimagines MJ's first signature shoe with a fresh mix of colors. Premium materials, soft cushioning and a padded ankle collar offer total support and celebrate the shoe that started it all.", "https://lemkus.com/cdn/shop/products/FD2596-700-1.png?v=1676281218", "AIR JORDAN 1 RETRO HI OG (W)", 194.71000000000001, null },
                    { 27, "M", "Taking inspiration from the original shoe that debuted in the mid 80s, the Air Jordan 1 Low is made to a low top minimalist style with all white colourways. The heel of the sneaker showcases the brand's original logo of the wings, the side of the sneakers features the Swoosh branding as a matching overlay.", "https://lemkus.com/cdn/shop/products/553558-136-1.png?v=1662649553", "AIR JORDAN 1 LOW (All White)", 160.0, null },
                    { 28, "M", "The 550's low top, streamlined silhouette offers a clean take on the heavy-duty designs of the late '80s, while the dependable leather upper construction is a classic look in any era.", "https://lemkus.com/cdn/shop/files/BB550HSB-1.png?v=1684762429", "550 LIFESTYLE", 160.5, null },
                    { 29, "M", "A classic, leather upper is bolstered with a puff and stitch collar, for a subtle reinterpretation of molded foam construction.", "https://lemkus.com/cdn/shop/files/BB650RCL-1.png?v=1684330926", "650 LIFESTYLE", 202.83000000000001, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Shoes_UserId",
                table: "Shoes",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shoes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
