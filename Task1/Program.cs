using Microsoft.EntityFrameworkCore;

namespace Task1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using MyDatabase myDataBase = new MyDatabase();
            var orders = new List<Order>
            {
                new Order
                {
                    OrderId = Guid.NewGuid(),
                    Name = "Order 1",
                    Create = new DateTime(2023, 3, 1),
                    Update = new DateTime(2023, 3, 2),
                    Description = "This is the first order."
                },
                new Order
                {
                    OrderId = Guid.NewGuid(),
                    Name = "Order 2",
                    Create = new DateTime(2023, 3, 3),
                    Update = new DateTime(2023, 3, 4),
                    Description = "This is the second order."
                },
                new Order
                {
                    OrderId = Guid.NewGuid(),
                    Name = "Order 3",
                    Create = new DateTime(2023, 3, 5),
                    Update = new DateTime(2023, 3, 6),
                    Description = "This is the third order."
                },
                new Order
                {
                    OrderId = Guid.NewGuid(),
                    Name = "Order 4",
                    Create = new DateTime(2023, 3, 7),
                    Update = new DateTime(2023, 3, 8),
                    Description = "This is the fourth order."
                },
                new Order
                {
                    OrderId = Guid.NewGuid(),
                    Name = "Order 5",
                    Create = new DateTime(2023, 3, 9),
                    Update = new DateTime(2023, 3, 10),
                    Description = "This is the fifth order."
                },
                new Order
                {
                    OrderId = Guid.NewGuid(),
                    Name = "Order 6",
                    Create = new DateTime(2023, 3, 11),
                    Update = new DateTime(2023, 3, 12),
                    Description = "This is the sixth order."
                },
                new Order
                {
                    OrderId = Guid.NewGuid(),
                    Name = "Order 7",
                    Create = new DateTime(2023, 3, 13),
                    Update = new DateTime(2023, 3, 14),
                    Description = "This is the seventh order."
                },
                new Order
                {
                    OrderId = Guid.NewGuid(),
                    Name = "Order 8",
                    Create = new DateTime(2023, 3, 15),
                    Update = new DateTime(2023, 3, 16),
                    Description = "This is the eighth order."
                },
                new Order
                {
                    OrderId = Guid.NewGuid(),
                    Name = "Order 9",
                    Create = new DateTime(2023, 3, 17),
                    Update = new DateTime(2023, 3, 18),
                    Description = "This is the ninth order."
                },
                new Order
                {
                    OrderId = Guid.NewGuid(),
                    Name = "Order 10",
                    Create = new DateTime(2023, 3, 19),
                    Update = new DateTime(2023, 3, 20),
                    Description = "This is the tenth order."
                }
            };

            foreach (var order in orders)
            {
                myDataBase.Add(order);
            }
            myDataBase.SaveChanges();


            var ords = await myDataBase.Orders.ToListAsync();
            foreach (var ord in ords)
            {
                await Console.Out.WriteLineAsync(ord.Name);
            }
        }
    }
}
