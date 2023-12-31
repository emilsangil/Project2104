﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project2104.Context;

#nullable disable

namespace Project2104.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230810065711_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Project2104.DataModels.Shoe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Shoes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "M",
                            Description = "Inspired by the original that debuted in 1985, the Air Jordan 1 Low offers a clean, classic look that's familiar yet always fresh. With an iconic design that pairs perfectly with any 'fit, these kicks ensure you'll always be on point. Encapsulated Air-Sole unit provides lightweight cushioning.",
                            Image = "https://lemkus.com/cdn/shop/products/553558-066-1.png?v=1680251200",
                            Name = "Air Jordan 1 Low ",
                            Price = 166.59999999999999
                        },
                        new
                        {
                            Id = 2,
                            Category = "M",
                            Description = "The Terminator Low lets you step back to the era of hook shots, knee pads and calf-high socks. Pulling inspiration from the \"Be True To Your School\" ad campaign (and 1 of the 7 original colorways released in '85), it ups your game with spirited team colors.",
                            Image = "https://lemkus.com/cdn/shop/files/Layer_3544.png?v=1688466136",
                            Name = "Nike Terminator Low",
                            Price = 173.84
                        },
                        new
                        {
                            Id = 3,
                            Category = "M",
                            Description = "A tribute to the legendary Chicago skyline used to create the Jumpman logo, this Air Jordan 1 Mid features an iconic colorway. The tongue features the original image, while the sole and side feature the Chicago sunset shade. The encapsulated Air-Sole unit provides the right amount of cushioning with every step.\r\n",
                            Image = "https://lemkus.com/cdn/shop/files/FB2212-100-1.png?v=1690381031",
                            Name = "AIR JORDAN 1 MID SS (GS)",
                            Price = 159.34999999999999
                        },
                        new
                        {
                            Id = 4,
                            Category = "W",
                            Description = "A tribute to the legendary Chicago skyline used to create the Jumpman logo, this Air Jordan 1 Mid features an iconic colorway. The tongue features the original image, while the sole and side feature the Chicago sunset shade. The encapsulated Air-Sole unit provides the right amount of cushioning with every step.",
                            Image = "https://lemkus.com/cdn/shop/files/DZ3745-500-1.png?v=1690014771",
                            Name = "AIR JORDAN 1 MID SE (W)",
                            Price = 202.83000000000001
                        },
                        new
                        {
                            Id = 5,
                            Category = "W",
                            Description = "A tribute to the legendary Chicago skyline used to create the Jumpman logo, this Air Jordan 1 Mid features an iconic colorway. The tongue features the original image, while the sole and side feature the Chicago sunset shade. The encapsulated Air-Sole unit provides the right amount of cushioning with every step.",
                            Image = "https://lemkus.com/cdn/shop/files/DZ3745-300-1.png?v=1688479640",
                            Name = "AIR JORDAN 1 MID SE (W)",
                            Price = 202.80000000000001
                        },
                        new
                        {
                            Id = 6,
                            Category = "W",
                            Description = "You don't need to play \"either or\" when it comes to choosing style or comfort with this one—which is nice, 'cause you deserve both. Nike Air technology absorbs impact for cushioning with every step. Suede on the upper and toe breaks in easily and contours to your feet. Formula 23 foam keeps your feet extra padded.",
                            Image = "https://lemkus.com/cdn/shop/files/FJ4652-100-1.png?v=1686142393",
                            Name = "AIR JORDAN 1 ZOOM CMFT 2 (W)",
                            Price = 217.31999999999999
                        },
                        new
                        {
                            Id = 7,
                            Category = "M",
                            Description = "The newly reissued 580 brings an icon back to life. The modernized look of a slimmed down toe and reduced collar height is combined with construction that comes as close to a one-to-one recreation of the OG materials, compounds, and features as humanly possible.",
                            Image = "https://lemkus.com/cdn/shop/files/MT580HSB-1.png?v=1683273697",
                            Name = "580 LIFESTYLE",
                            Price = 156.44999999999999
                        },
                        new
                        {
                            Id = 8,
                            Category = "M",
                            Description = "The 9060 reinterprets familiar elements sourced from classic 99X models with a warped sensibility inspired by the proudly futuristic, visible tech aesthetic of the Y2K era.",
                            Image = "https://lemkus.com/cdn/shop/products/U9060TRU-1.png?v=1681456799",
                            Name = "9060 LIFESTYLE",
                            Price = 173.84
                        },
                        new
                        {
                            Id = 9,
                            Category = "M",
                            Description = "This redesigned version of the shoes honours those roots with a suede upper that nods to their smart beginnings. Perforated details on the toe and the flex on the heel add a pop of retro texture, just like the grooved tread. And you can't miss the 3-Stripes style along the sides.",
                            Image = "https://lemkus.com/cdn/shop/products/FZ5880-5.png?v=1675684622",
                            Name = "CENTENNIAL 85 LOW",
                            Price = 137.61000000000001
                        },
                        new
                        {
                            Id = 10,
                            Category = "M",
                            Description = "The adidas NMD — short for Nomad — is a popular casual sneaker that combines old design concepts with new technology, particularly Boost cushioning and occasional Primeknit uppers.",
                            Image = "https://lemkus.com/cdn/shop/products/HQ4452_1.png?v=1671352439",
                            Name = "NMD_R1",
                            Price = 154.63999999999999
                        },
                        new
                        {
                            Id = 11,
                            Category = "M",
                            Description = "Textile lining provides strength and durability. Primegreen recycled materials used in the upper represent one of the solutions to help end plastic waste. Lace closure ensures a snug fit. Rubber outsole offers maximum traction and grip.",
                            Image = "https://lemkus.com/cdn/shop/products/GX5784_1.png?v=1653467764",
                            Name = "NMD V3",
                            Price = 224.56999999999999
                        },
                        new
                        {
                            Id = 12,
                            Category = "W",
                            Description = "Textile lining provides strength and durability. Primegreen recycled materials used in the upper represent one of the solutions to help end plastic waste. Lace closure ensures a snug fit. Rubber outsole offers maximum traction and grip.",
                            Image = "https://lemkus.com/cdn/shop/products/GX5785_1.png?v=1658739934",
                            Name = "NMD V3 (W)",
                            Price = 224.56999999999999
                        },
                        new
                        {
                            Id = 13,
                            Category = "W",
                            Description = "The crisp leather on the upper has a slight sheen, ages to soft perfection and features durable overlays reminiscent of '80s b-ball. The foam midsole offers lightweight, responsive cushioning. The padded, low-cut collar adds a sleek look that feels comfortable.",
                            Image = "https://lemkus.com/cdn/shop/files/FN7773-001-1.png?v=1688473932",
                            Name = "DUNK LOW (W)",
                            Price = 173.84
                        },
                        new
                        {
                            Id = 14,
                            Category = "M",
                            Description = "Tongue top and modified overlay in the upper add classic comfort and refer to the AJ6. Semi-bootie lining rounds off the look and refers to the AJ7. Embroidered Nike Air heel logo inspired the AJ6 and the moulded heel detail taken from the AJ8 give an iconic finish.",
                            Image = "https://lemkus.com/cdn/shop/files/DZ5577-168-1.png?v=1688737178",
                            Name = "JORDAN MVP (GS)",
                            Price = 173.84
                        },
                        new
                        {
                            Id = 15,
                            Category = "M",
                            Description = "This shoe features a vibrant orange and yellow colorway inspired by the popular fire-type Pokemon, Charmander. The upper is constructed with a mix of suede and leather materials, providing durability and a premium feel.",
                            Image = "https://lemkus.com/cdn/shop/products/387686_01-1.png?v=1670315077",
                            Name = "SLIPSTREAM CHARMANDER",
                            Price = 154.63999999999999
                        },
                        new
                        {
                            Id = 16,
                            Category = "M",
                            Description = "PUMA x COCA-COLA is the coming together of two iconic brands who share a profound history, a sense of positivity, and an ability to move culture forward.",
                            Image = "https://lemkus.com/cdn/shop/products/38704201-1.png?v=1675241004",
                            Name = "WILO COCA COLA RACING",
                            Price = 94.129999999999995
                        },
                        new
                        {
                            Id = 17,
                            Category = "W",
                            Description = "The Nike Air Force 1 '07 is back with crisp leather, bold colors, and classic Nike cutlines. The upper comes with stitched leather overlays that stay true to their predecessor and deliver reliable support. The foam midsole offers the perfect amount of cushioning, while the perforations on the toe enhance airflow.",
                            Image = "https://lemkus.com/cdn/shop/files/Layer_3544_61f7c5d3-67dc-4f02-84ce-ca98e0e45ee0.png?v=1688471755",
                            Name = "AIR FORCE 1 '07 LOW (W)",
                            Price = 173.84
                        },
                        new
                        {
                            Id = 18,
                            Category = "K",
                            Description = "The low-top kicks are made from real and synthetic leather that's durable and brings a classic feel. The shape gives toes more wiggle room and the fit helps keep growing feet comfortable. The Max Air unit has a softer feel that's tuned right for kids. Plus, comfy and flexible foam makes for easy steps.",
                            Image = "https://lemkus.com/cdn/shop/files/DV3608-103-1.png?v=1683192772",
                            Name = "AIR max 90 LTR (PS)",
                            Price = 90.319999999999993
                        },
                        new
                        {
                            Id = 19,
                            Category = "K",
                            Description = "The Nike Air Max 90 takes the original look to a new level with more comfort and flexibility. It keeps the classic Max Air cushioning you know and love. The '90s look has leather and synthetic leather to make it durable and easy to clean. A Max Air unit provides the same lightweight cushioning as the original.",
                            Image = "https://lemkus.com/cdn/shop/products/CD6868-009-1.png?v=1680094361",
                            Name = "AIR MAX 90 LTR (TD)",
                            Price = 90.319999999999993
                        },
                        new
                        {
                            Id = 20,
                            Category = "K",
                            Description = "Ride the '90s style wave with the Nike Air Force 1 LV8 2 TD “Panda.” Teaming up that classic AF1 look with a bold era-echoing colour block, this remixed sneaker also features smooth durable leather and a hidden Air-Sole unit for comfort.",
                            Image = "https://lemkus.com/cdn/shop/products/DV1624-001-1.png?v=1677054466",
                            Name = "FORCE 1 LV8 2 (TD)",
                            Price = 100.5
                        },
                        new
                        {
                            Id = 21,
                            Category = "K",
                            Description = "The one-piece design slips",
                            Image = "https://lemkus.com/cdn/shop/products/GY9148_1.png?v=1673347669",
                            Name = "NMD 360 (TD)",
                            Price = 80.900000000000006
                        },
                        new
                        {
                            Id = 22,
                            Category = "W",
                            Description = "Durable leather upper is made for everyday wear. Originally designed for performance running, the visible Max Air unit provides all-day cushioning. Padded, low-cut collar looks sleek and feels comfortable. 2 sets of laces let you switch up your style.",
                            Image = "https://lemkus.com/cdn/shop/files/FJ5479-410-1.png?v=1686563041",
                            Name = "AIR MAX 1 PRM (W)",
                            Price = 231.81
                        },
                        new
                        {
                            Id = 23,
                            Category = "M",
                            Description = "It features a white and University Red smooth leather upper with black leather collars and red Swooshes. From there, a black and red woven Nike tongue label and an Air sole at the base completes the design.",
                            Image = "https://lemkus.com/cdn/shop/files/DZ5485-400-1.png?v=1688654367",
                            Name = "AIR JORDAN 1 RETRO HI OG",
                            Price = 253.63
                        },
                        new
                        {
                            Id = 24,
                            Category = "W",
                            Description = "The '80s b-ball icon returns with classic details and throwback hoops flair. Channeling vintage style back onto the streets, its padded collar and extra-puffy silhouette let you take your game anywhere—in comfort. Leather in the upper softens and gains vintage character with wear.",
                            Image = "https://lemkus.com/cdn/shop/files/DZ2794-100-1.png?v=1690365351",
                            Name = "DUNK LOW TWIST (W)",
                            Price = 173.84
                        },
                        new
                        {
                            Id = 25,
                            Category = "M",
                            Description = "The Air Jordan 1 never misses an opportunity to enhance comfort alongside iconic designs. In this Zoom Air CMFT 2, the cushioning technology helps rebound from the road and a responsive ride all day. Style and comfort in the most contemporary silhouette.",
                            Image = "https://lemkus.com/cdn/shop/files/DV1307-107-1.png?v=1688725892",
                            Name = "AIR JORDAN 1 ZM AIR CMFT 2",
                            Price = 224.56999999999999
                        },
                        new
                        {
                            Id = 26,
                            Category = "W",
                            Description = "This iteration of the AJ1 reimagines MJ's first signature shoe with a fresh mix of colors. Premium materials, soft cushioning and a padded ankle collar offer total support and celebrate the shoe that started it all.",
                            Image = "https://lemkus.com/cdn/shop/products/FD2596-700-1.png?v=1676281218",
                            Name = "AIR JORDAN 1 RETRO HI OG (W)",
                            Price = 194.71000000000001
                        },
                        new
                        {
                            Id = 27,
                            Category = "M",
                            Description = "Taking inspiration from the original shoe that debuted in the mid 80s, the Air Jordan 1 Low is made to a low top minimalist style with all white colourways. The heel of the sneaker showcases the brand's original logo of the wings, the side of the sneakers features the Swoosh branding as a matching overlay.",
                            Image = "https://lemkus.com/cdn/shop/products/553558-136-1.png?v=1662649553",
                            Name = "AIR JORDAN 1 LOW (All White)",
                            Price = 160.0
                        },
                        new
                        {
                            Id = 28,
                            Category = "M",
                            Description = "The 550's low top, streamlined silhouette offers a clean take on the heavy-duty designs of the late '80s, while the dependable leather upper construction is a classic look in any era.",
                            Image = "https://lemkus.com/cdn/shop/files/BB550HSB-1.png?v=1684762429",
                            Name = "550 LIFESTYLE",
                            Price = 160.5
                        },
                        new
                        {
                            Id = 29,
                            Category = "M",
                            Description = "A classic, leather upper is bolstered with a puff and stitch collar, for a subtle reinterpretation of molded foam construction.",
                            Image = "https://lemkus.com/cdn/shop/files/BB650RCL-1.png?v=1684330926",
                            Name = "650 LIFESTYLE",
                            Price = 202.83000000000001
                        });
                });

            modelBuilder.Entity("Project2104.DataModels.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Project2104.DataModels.Shoe", b =>
                {
                    b.HasOne("Project2104.DataModels.User", null)
                        .WithMany("Favorites")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Project2104.DataModels.User", b =>
                {
                    b.Navigation("Favorites");
                });
#pragma warning restore 612, 618
        }
    }
}
