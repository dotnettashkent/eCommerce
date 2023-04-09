using eCommerce.DAL.Contexts;
using eCommerce.Domain.Entities.Enums;
using eCommerce.Domain.Entities.Users;

namespace eCommerce.Web.Models
{
    public static class UserSeedData
    {
        private static readonly AppDbContext dbContext = new AppDbContext();
        public static void Initialize()
        {
            if (dbContext.Users.Any())
                return;


            dbContext.Users.AddRangeAsync(
                new User
                {
                    FirstName = "Firdavs",
                    LastName = "Muzaffarov",
                    Age = 30,
                    Phone = "+123456789",
                    OrderTime = DateTime.UtcNow,
                    Payment = PaymentType.Online,
                    Email = "john.doe@example.com",
                    Password = "password123",
                    Role = UserRole.Admin
                },
                new User
                {
                    FirstName = "Jane",
                    LastName = "Doe",
                    Age = 25,
                    Phone = "+987654321",
                    OrderTime = DateTime.UtcNow,
                    Payment = PaymentType.Online,
                    Email = "jane.doe@example.com",
                    Password = "password123"
                },
                new User
                {
                    FirstName = "Bob",
                    LastName = "Smith",
                    Age = 40,
                    Phone = "+1122334455",
                    OrderTime = DateTime.UtcNow,
                    Payment = PaymentType.Cash,
                    Email = "bob.smith@example.com",
                    Password = "password123"
                },
                new User
                {
                    FirstName = "Alice",
                    LastName = "Johnson",
                    Age = 35,
                    Phone = "+9988776655",
                    OrderTime = DateTime.UtcNow,
                    Payment = PaymentType.Cash,
                    Email = "alice.johnson@example.com",
                    Password = "password123"
                },
                new User
                {
                    FirstName = "David",
                    LastName = "Williams",
                    Age = 28,
                    Phone = "+1122334455",
                    OrderTime = DateTime.UtcNow,
                    Payment = PaymentType.Cash,
                    Email = "david.williams@example.com",
                    Password = "password123",
                    Role = UserRole.Admin
                },
                new User
                {
                    FirstName = "Sarah",
                    LastName = "Davis",
                    Age = 32,
                    Phone = "+4433221100",
                    OrderTime = DateTime.UtcNow,
                    Payment = PaymentType.Cash,
                    Email = "sarah.davis@example.com",
                    Password = "password123"
                },
                new User
                {
                    FirstName = "Tom",
                    LastName = "Brown",
                    Age = 42,
                    Phone = "+1122334455",
                    OrderTime = DateTime.UtcNow,
                    Payment = PaymentType.Online,
                    Email = "tom.brown@example.com",
                    Password = "password123"
                },
                new User
                {
                    FirstName = "Olivia",
                    LastName = "Garcia",
                    Age = 29,
                    Phone = "+1122334455",
                    OrderTime = DateTime.UtcNow,
                    Payment = PaymentType.Online,
                    Email = "olivia.garcia@example.com",
                    Password = "password123"
                },
                new User
                {
                    FirstName = "Michael",
                    LastName = "Lopez",
                    Age = 36,
                    Phone = "+1122334455",
                    OrderTime = DateTime.UtcNow,
                    Payment = PaymentType.Cash,
                    Email = "michael.lopez@example.com",
                    Password = "password123"
                },
                new User
                {
                    FirstName = "Emily",
                    LastName = "Martinez",
                    Age = 31,
                    Phone = "+1122334455",
                    OrderTime = DateTime.UtcNow,
                    Payment = PaymentType.Online,
                    Email = "emily.martinez@example.com",
                    Password = "password123"
                });

            dbContext.SaveChanges();

        }
    }
}
