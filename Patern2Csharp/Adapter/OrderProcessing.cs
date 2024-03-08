using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern2Csharp.Adapter
{
    public interface IOrderProcessor
    {
        void ProcessOrder(Order order);
    }

    public enum PaymentMethod
    {
        Cash,
        CreditCard,
        PayPal,
        BankTransfer
    }

    public class Order
    {
        public int OrderId { get; set; }
        public required string CustomerName { get; set; }
        public required string[] Items { get; set; }
        public decimal TotalAmount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
    public class RestaurantOrderProcessor : IOrderProcessor
    {
        public void ProcessOrder(Order order)
        {
            Console.WriteLine($"Processing order #{order.OrderId} for {order.CustomerName}");

            Console.WriteLine("Items in the order:");
            foreach (var item in order.Items)
            {
                Console.WriteLine($"- {item}");
            }

            Console.WriteLine($"Total amount: {order.TotalAmount:C}");
            Console.WriteLine($"Payment method: {order.PaymentMethod}");
            Console.WriteLine("Order processed successfully.\n");
        }
    }
}
