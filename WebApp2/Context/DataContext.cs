using Microsoft.EntityFrameworkCore;
using WebApp2.Models.Entities;

namespace WebApp2.Context;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<ProductEntity> Products { get; set; }
    public DbSet<CategoryEntity> Categories { get; set; }
    public DbSet<ContactEntity> Contacts { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<CategoryEntity>().HasData(
            new CategoryEntity { Id = 1, Name = "new" },
            new CategoryEntity { Id = 2, Name = "featured" },
            new CategoryEntity { Id = 3, Name = "popular" },
            new CategoryEntity { Id = 4, Name = "discount" }
            );

        builder.Entity<ProductEntity>().HasData(
            new ProductEntity { Id = 1, Name = "Apple watch series", Price = 249, ImageUrl = "https://store.storeimages.cdn-apple.com/4668/as-images.apple.com/is/MKU93_VW_34FR+watch-40-alum-starlight-nc-se_VW_34FR_WF_CO?wid=1400&hei=1400&trim=1%2C0&fmt=p-jpg&qlt=95&.v=1683237043713", Description = "Apple watch" },
            new ProductEntity { Id = 2, Name = "Table Lamp", Price = 30, ImageUrl = "https://media.wigerdals.com/2022/02/Table-lamp-in-teak-2.jpg", Description = "Table Lamp" },
            new ProductEntity { Id = 3, Name = "Laptop Thinkpad Lenovo", Price = 499, ImageUrl = "https://www.lenovo.com/medias/lenovo-laptops-thinkpad-E14-gen-4-14-amd-hero.png?context=bWFzdGVyfHJvb3R8Mjc0OTQ4fGltYWdlL3BuZ3xoMDMvaGJhLzE0MDYwNzY4NDI4MDYyLnBuZ3xjNGVkYmNkOTkwOGNjNjc1YzdjNGM5Nzk3MjE4MDFmODg0Y2VkNGQwNjljMzYzYjk2NDFkMDMwYTZjNzk3MGI1", Description = "Laptop Thinkpad Lenovo" },
            new ProductEntity { Id = 4, Name = "Table Lamp", Price = 45, ImageUrl = "https://modernity.ams3.cdn.digitaloceanspaces.com/2022/08/7613f256-819x1024.jpg", Description = "Table Lamp" },
            new ProductEntity { Id = 5, Name = "Gumshoes black fashion", Price = 89, ImageUrl = "https://www.designboom.com/wp-content/uploads/2018/04/gumshoe-2-818x491.jpg", Description = "Gumshoes black fashion" },
            new ProductEntity { Id = 6, Name = "Woman White Dress", Price = 119, ImageUrl = "https://media.dior.com/couture/ecommerce/media/catalog/product/T/L/1674064948_321L25A3608_X0200_E01_GH.jpg", Description = "Woman White Dress" },
            new ProductEntity { Id = 7, Name = "Kettle Water Boiler", Price = 49, ImageUrl = "https://www.cremashop.se/media/cache/gallery_image/content/products/wilfa/wk-5/419.jpg", Description = "Kettle Water Boiler" },
            new ProductEntity { Id = 8, Name = "Congee Cooking Rice Cooker", Price = 149, ImageUrl = "https://cdn.abicart.com/shop/images/22157092-origpic-aff204/ws35/42135/art35/h7092/4053.jpg", Description = "Congee Cooking Rice Cooker" },

            new ProductEntity { Id = 9, Name = "Woman Black Dress", Price = 99, ImageUrl = "https://encrypted-tbn0.gstatic.com/shopping?q=tbn:ANd9GcQ6anbJ4z73KFj3oxAJxf8yOEL393b3xQy-9L63YkllIwxDQfTmh97w0uI2mwnurM2FOSvWUOGm_11SUT1croSUzp8-ZvpfQjAyCRkh0euMYXrS8jnZrhCj&usqp=CAE", Description = "Woman Black Dress" },
            new ProductEntity { Id = 10, Name = "Laptop HP", Price = 349, ImageUrl = "https://www.elgiganten.se/image/dv_web_D180001002758719/312968/hp-barbar-dator-15-r3-58256-156-barbar-dator.jpg", Description = "Laptop HP" },
            new ProductEntity { Id = 11, Name = "Table Lamp", Price = 20, ImageUrl = "https://02.cdn37.se/ak1/images/2.754688/crme-atelier-soft-serve-table-lamp-grande-mocha.jpeg", Description = "Table Lamp" },
            new ProductEntity { Id = 12, Name = "Samsung Watch", Price = 459, ImageUrl = "https://images.samsung.com/is/image/samsung/assets/se/2208/pcd/watches/Galaxy_Watch5_mo.png?$264_264_PNG$", Description = "Samsung Watch" },

            new ProductEntity { Id = 13, Name = "Table Lamp - scelerisque tempore", Price = 25, ImageUrl = "https://www.boconcept.com/on/demandware.static/-/Sites-master-catalog/default/dwcfe950b0/images/1100000/1106997.jpg", Description = "Table Lamp - scelerisque tempore" },
            new ProductEntity { Id = 14, Name = "Table Lamp - scelerisque tempore", Price = 49, ImageUrl = "https://cdn.shopify.com/s/files/1/0337/3871/9365/articles/cult-design-blog-banner-heading-top-10-table-lamps-design-icons15_1140x650.jpg?v=1658359748", Description = "Table Lamp - scelerisque tempore" },

            new ProductEntity { Id = 15, Name = "Apple watch series", Price = 299, ImageUrl = "https://store.storeimages.cdn-apple.com/4668/as-images.apple.com/is/apple-watch-se-og-202303?wid=600&hei=315&fmt=jpeg&qlt=95&.v=1677202217654", Description = "Apple watch series" },
            new ProductEntity { Id = 16, Name = "Gumshoes black fashion", Price = 99, ImageUrl = "https://footwearnews.com/wp-content/uploads/2018/04/gumshoe_02.jpg", Description = "Gumshoes black fashion" },
            new ProductEntity { Id = 17, Name = "Woman red dress", Price = 139, ImageUrl = "https://hips.hearstapps.com/hmg-prod/images/rat-and-b-1587127096.jpg?resize=480:*", Description = "Woman red dress" },
            new ProductEntity { Id = 18, Name = "Kettle water boiler", Price = 99, ImageUrl = "https://i5.walmartimages.com/asr/7a2f144a-f0e7-41f8-85e2-a89f684b9590.97045698436cf2c8f293ac63672af5be.jpeg", Description = "Kettle water boiler" },
            new ProductEntity { Id = 19, Name = "Rice cooker", Price = 199, ImageUrl = "https://m.media-amazon.com/images/I/71JWnktqA8L._AC_SL1500_.jpg", Description = "Rice cooker" },
            new ProductEntity { Id = 20, Name = "Pizza tomato sauce kebab", Price = 19, ImageUrl = "https://foodbydrygast.com/assets/images/recipes/kebab_pizza.webp", Description = "Pizza tomato sauce kebab" }
            );

        builder.Entity<ProductTagEntity>().HasData(
            new ProductTagEntity { ProductId = 1, CategoryId = 2 },
            new ProductTagEntity { ProductId = 2, CategoryId = 2 },
            new ProductTagEntity { ProductId = 3, CategoryId = 2 },
            new ProductTagEntity { ProductId = 4, CategoryId = 2 },
            new ProductTagEntity { ProductId = 5, CategoryId = 2 },
            new ProductTagEntity { ProductId = 6, CategoryId = 2 },
            new ProductTagEntity { ProductId = 7, CategoryId = 2 },
            new ProductTagEntity { ProductId = 8, CategoryId = 2 },


            new ProductTagEntity { ProductId = 9, CategoryId = 1 },
            new ProductTagEntity { ProductId = 10, CategoryId = 1 },
            new ProductTagEntity { ProductId = 11, CategoryId = 1 },
            new ProductTagEntity { ProductId = 12, CategoryId = 1 },

            new ProductTagEntity { ProductId = 13, CategoryId = 4 },
            new ProductTagEntity { ProductId = 14, CategoryId = 4 },

            new ProductTagEntity { ProductId = 15, CategoryId = 3 },
            new ProductTagEntity { ProductId = 16, CategoryId = 3 },
            new ProductTagEntity { ProductId = 17, CategoryId = 3 },
            new ProductTagEntity { ProductId = 18, CategoryId = 3 },
            new ProductTagEntity { ProductId = 19, CategoryId = 3 },
            new ProductTagEntity { ProductId = 20, CategoryId = 3 }
            );
    }
}
