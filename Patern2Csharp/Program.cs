using Patern2Csharp.Adapter;
using Patern2Csharp.Bridge;

namespace Pattern2Csharp
{
    internal class Program
    {
        private const decimal V = 15.99m;

        static void Main(string[] args)
        {
            var order = new Order
            {
                OrderId = 1001,
                CustomerName = "John Doe",
                Items = new string[] { "Burger", "Fries", "Soda" },
                TotalAmount = V,
                PaymentMethod = PaymentMethod.CreditCard
            };

            IOrderProcessor orderProcessor = new RestaurantOrderProcessor();
            orderProcessor.ProcessOrder(order);

            Console.ReadLine();
        }
        static void Developer(string[] args)
        {
            IDepartment salesDepartment = new SalesDepartment();
            Console.WriteLine("Sales Department tasks:");
            salesDepartment.PerformTask();

            Console.WriteLine();

            IDepartment developmentDepartment = new DevelopmentDepartment();
            Console.WriteLine("Development Department tasks:");
            developmentDepartment.PerformTask();

            Console.WriteLine();

            IDepartment marketingDepartment = new MarketingDepartment();
            Console.WriteLine("Marketing Department tasks:");
            marketingDepartment.PerformTask();

            Console.ReadLine();
        }
    }
}