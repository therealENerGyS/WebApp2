﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApp2.Context;

#nullable disable

namespace WebApp2.Migrations.Data
{
    [DbContext(typeof(DataContext))]
    [Migration("20230529111438_Sql3Test")]
    partial class Sql3Test
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApp2.Models.Entities.CategoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "new"
                        },
                        new
                        {
                            Id = 2,
                            Name = "featured"
                        },
                        new
                        {
                            Id = 3,
                            Name = "popular"
                        },
                        new
                        {
                            Id = 4,
                            Name = "discount"
                        });
                });

            modelBuilder.Entity("WebApp2.Models.Entities.ContactEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("001bf82e-ec29-4fbc-9a8c-cb7318a9c819"),
                            Comment = "Hejsan",
                            Created = new DateTime(2023, 5, 29, 13, 14, 38, 551, DateTimeKind.Local).AddTicks(8451),
                            Email = "anton@domain.com",
                            Name = "Anton"
                        });
                });

            modelBuilder.Entity("WebApp2.Models.Entities.ProductEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Apple watch",
                            ImageUrl = "https://store.storeimages.cdn-apple.com/4668/as-images.apple.com/is/MKU93_VW_34FR+watch-40-alum-starlight-nc-se_VW_34FR_WF_CO?wid=1400&hei=1400&trim=1%2C0&fmt=p-jpg&qlt=95&.v=1683237043713",
                            Name = "Apple watch series",
                            Price = 249m
                        },
                        new
                        {
                            Id = 2,
                            Description = "Table Lamp",
                            ImageUrl = "https://media.wigerdals.com/2022/02/Table-lamp-in-teak-2.jpg",
                            Name = "Table Lamp",
                            Price = 30m
                        },
                        new
                        {
                            Id = 3,
                            Description = "Laptop Thinkpad Lenovo",
                            ImageUrl = "https://www.lenovo.com/medias/lenovo-laptops-thinkpad-E14-gen-4-14-amd-hero.png?context=bWFzdGVyfHJvb3R8Mjc0OTQ4fGltYWdlL3BuZ3xoMDMvaGJhLzE0MDYwNzY4NDI4MDYyLnBuZ3xjNGVkYmNkOTkwOGNjNjc1YzdjNGM5Nzk3MjE4MDFmODg0Y2VkNGQwNjljMzYzYjk2NDFkMDMwYTZjNzk3MGI1",
                            Name = "Laptop Thinkpad Lenovo",
                            Price = 499m
                        },
                        new
                        {
                            Id = 4,
                            Description = "Table Lamp",
                            ImageUrl = "https://modernity.ams3.cdn.digitaloceanspaces.com/2022/08/7613f256-819x1024.jpg",
                            Name = "Table Lamp",
                            Price = 45m
                        },
                        new
                        {
                            Id = 5,
                            Description = "Gumshoes black fashion",
                            ImageUrl = "https://www.designboom.com/wp-content/uploads/2018/04/gumshoe-2-818x491.jpg",
                            Name = "Gumshoes black fashion",
                            Price = 89m
                        },
                        new
                        {
                            Id = 6,
                            Description = "Woman White Dress",
                            ImageUrl = "https://media.dior.com/couture/ecommerce/media/catalog/product/T/L/1674064948_321L25A3608_X0200_E01_GH.jpg",
                            Name = "Woman White Dress",
                            Price = 119m
                        },
                        new
                        {
                            Id = 7,
                            Description = "Kettle Water Boiler",
                            ImageUrl = "https://www.cremashop.se/media/cache/gallery_image/content/products/wilfa/wk-5/419.jpg",
                            Name = "Kettle Water Boiler",
                            Price = 49m
                        },
                        new
                        {
                            Id = 8,
                            Description = "Congee Cooking Rice Cooker",
                            ImageUrl = "https://cdn.abicart.com/shop/images/22157092-origpic-aff204/ws35/42135/art35/h7092/4053.jpg",
                            Name = "Congee Cooking Rice Cooker",
                            Price = 149m
                        },
                        new
                        {
                            Id = 9,
                            Description = "Woman Black Dress",
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/shopping?q=tbn:ANd9GcQ6anbJ4z73KFj3oxAJxf8yOEL393b3xQy-9L63YkllIwxDQfTmh97w0uI2mwnurM2FOSvWUOGm_11SUT1croSUzp8-ZvpfQjAyCRkh0euMYXrS8jnZrhCj&usqp=CAE",
                            Name = "Woman Black Dress",
                            Price = 99m
                        },
                        new
                        {
                            Id = 10,
                            Description = "Laptop HP",
                            ImageUrl = "https://www.elgiganten.se/image/dv_web_D180001002758719/312968/hp-barbar-dator-15-r3-58256-156-barbar-dator.jpg",
                            Name = "Laptop HP",
                            Price = 349m
                        },
                        new
                        {
                            Id = 11,
                            Description = "Table Lamp",
                            ImageUrl = "https://02.cdn37.se/ak1/images/2.754688/crme-atelier-soft-serve-table-lamp-grande-mocha.jpeg",
                            Name = "Table Lamp",
                            Price = 20m
                        },
                        new
                        {
                            Id = 12,
                            Description = "Samsung Watch",
                            ImageUrl = "https://images.samsung.com/is/image/samsung/assets/se/2208/pcd/watches/Galaxy_Watch5_mo.png?$264_264_PNG$",
                            Name = "Samsung Watch",
                            Price = 459m
                        },
                        new
                        {
                            Id = 13,
                            Description = "Table Lamp - scelerisque tempore",
                            ImageUrl = "https://www.boconcept.com/on/demandware.static/-/Sites-master-catalog/default/dwcfe950b0/images/1100000/1106997.jpg",
                            Name = "Table Lamp - scelerisque tempore",
                            Price = 25m
                        },
                        new
                        {
                            Id = 14,
                            Description = "Table Lamp - scelerisque tempore",
                            ImageUrl = "https://cdn.shopify.com/s/files/1/0337/3871/9365/articles/cult-design-blog-banner-heading-top-10-table-lamps-design-icons15_1140x650.jpg?v=1658359748",
                            Name = "Table Lamp - scelerisque tempore",
                            Price = 49m
                        },
                        new
                        {
                            Id = 15,
                            Description = "Apple watch series",
                            ImageUrl = "https://store.storeimages.cdn-apple.com/4668/as-images.apple.com/is/apple-watch-se-og-202303?wid=600&hei=315&fmt=jpeg&qlt=95&.v=1677202217654",
                            Name = "Apple watch series",
                            Price = 299m
                        },
                        new
                        {
                            Id = 16,
                            Description = "Gumshoes black fashion",
                            ImageUrl = "https://footwearnews.com/wp-content/uploads/2018/04/gumshoe_02.jpg",
                            Name = "Gumshoes black fashion",
                            Price = 99m
                        },
                        new
                        {
                            Id = 17,
                            Description = "Woman red dress",
                            ImageUrl = "https://hips.hearstapps.com/hmg-prod/images/rat-and-b-1587127096.jpg?resize=480:*",
                            Name = "Woman red dress",
                            Price = 139m
                        },
                        new
                        {
                            Id = 18,
                            Description = "Kettle water boiler",
                            ImageUrl = "https://i5.walmartimages.com/asr/7a2f144a-f0e7-41f8-85e2-a89f684b9590.97045698436cf2c8f293ac63672af5be.jpeg",
                            Name = "Kettle water boiler",
                            Price = 99m
                        },
                        new
                        {
                            Id = 19,
                            Description = "Rice cooker",
                            ImageUrl = "https://m.media-amazon.com/images/I/71JWnktqA8L._AC_SL1500_.jpg",
                            Name = "Rice cooker",
                            Price = 199m
                        },
                        new
                        {
                            Id = 20,
                            Description = "Pizza tomato sauce kebab",
                            ImageUrl = "https://foodbydrygast.com/assets/images/recipes/kebab_pizza.webp",
                            Name = "Pizza tomato sauce kebab",
                            Price = 19m
                        });
                });

            modelBuilder.Entity("WebApp2.Models.Entities.ProductTagEntity", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("ProductTagEntity");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 11,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 12,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 13,
                            CategoryId = 4
                        },
                        new
                        {
                            ProductId = 14,
                            CategoryId = 4
                        },
                        new
                        {
                            ProductId = 15,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 16,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 17,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 18,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 19,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 20,
                            CategoryId = 3
                        });
                });

            modelBuilder.Entity("WebApp2.Models.Entities.ProductTagEntity", b =>
                {
                    b.HasOne("WebApp2.Models.Entities.CategoryEntity", "Category")
                        .WithMany("ProductCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApp2.Models.Entities.ProductEntity", "Product")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WebApp2.Models.Entities.CategoryEntity", b =>
                {
                    b.Navigation("ProductCategories");
                });

            modelBuilder.Entity("WebApp2.Models.Entities.ProductEntity", b =>
                {
                    b.Navigation("ProductCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
