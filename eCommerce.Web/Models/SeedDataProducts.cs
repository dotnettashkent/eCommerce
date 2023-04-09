using eCommerce.DAL.Contexts;
using eCommerce.Domain.Entities.Products;


namespace eCommerce.Web.Models
{
    public static class SeedDataProducts
    {
        private static readonly AppDbContext appDbContext = new AppDbContext();
        public static void Initialize()
        {
            if (appDbContext.Products.Any())
            {
                return;
            }


            appDbContext.Products.AddRange(

                 new Product { ProductName = "Product 1", FirmName = "Firm 1", Description = "Description 1", Category = "Category 1", Count = 1, Price = 10 },
                 new Product { ProductName = "Product 2", FirmName = "Firm 2", Description = "Description 2", Category = "Category 2", Count = 2, Price = 20 },
                 new Product { ProductName = "Product 3", FirmName = "Firm 3", Description = "Description 3", Category = "Category 3", Count = 3, Price = 30 },
                 new Product { ProductName = "Product 4", FirmName = "Firm 4", Description = "Description 4", Category = "Category 4", Count = 4, Price = 40 },
                 new Product { ProductName = "Product 5", FirmName = "Firm 5", Description = "Description 5", Category = "Category 5", Count = 5, Price = 50 },
                 new Product { ProductName = "Product 6", FirmName = "Firm 6", Description = "Description 6", Category = "Category 6", Count = 6, Price = 60 },
                 new Product { ProductName = "Product 7", FirmName = "Firm 7", Description = "Description 7", Category = "Category 7", Count = 7, Price = 70 },
                 new Product { ProductName = "Product8 ", FirmName = "Firm8 ", Description = "Description8 ", Category = "Category8 ", Count = 8, Price = 80 },
                 new Product { ProductName = "Product9 ", FirmName = "Firm9 ", Description = "Description9 ", Category = "Category9 ", Count = 9, Price = 90 },
                 new Product { ProductName = "Product10 ", FirmName = "Firm10 ", Description = "Description10 ", Category = "Category10 ", Count = 10, Price = 100 }
            );
            appDbContext.SaveChanges();


        }
    }
}
