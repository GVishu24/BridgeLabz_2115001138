using System;
using System.Collections.Generic;

namespace Inheritance
{
    using System;

    class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }

        public Order(int orderId, DateTime orderDate)
        {
            OrderId = orderId;
            OrderDate = orderDate;
        }

        public virtual string GetOrderStatus()
        {
            return "Order placed";
        }
    }

    class ShippedOrder : Order
    {
        public string TrackingNumber { get; set; }

        public ShippedOrder(int orderId, DateTime orderDate, string trackingNumber) : base(orderId, orderDate)
        {
            TrackingNumber = trackingNumber;
        }

        public override string GetOrderStatus()
        {
            return "Order shipped";
        }
    }

    class DeliveredOrder : ShippedOrder
    {
        public DateTime DeliveryDate { get; set; }

        public DeliveredOrder(int orderId, DateTime orderDate, string trackingNumber, DateTime deliveryDate)
            : base(orderId, orderDate, trackingNumber)
        {
            DeliveryDate = deliveryDate;
        }

        public override string GetOrderStatus()
        {
            return "Order delivered";
        }
    }

    class Program
    {
        static void Main()
        {
            Order order = new Order(1001, DateTime.Now);
            ShippedOrder shippedOrder = new ShippedOrder(1002, DateTime.Now.AddDays(-2), "TRACK12345");
            DeliveredOrder deliveredOrder = new DeliveredOrder(1003, DateTime.Now.AddDays(-5), "TRACK67890", DateTime.Now.AddDays(-1));

            Console.WriteLine($"Order ID: {order.OrderId}, Status: {order.GetOrderStatus()}");
            Console.WriteLine($"Order ID: {shippedOrder.OrderId}, Status: {shippedOrder.GetOrderStatus()}, Tracking: {shippedOrder.TrackingNumber}");
            Console.WriteLine($"Order ID: {deliveredOrder.OrderId}, Status: {deliveredOrder.GetOrderStatus()}, Tracking: {deliveredOrder.TrackingNumber}, Delivered on: {deliveredOrder.DeliveryDate.ToShortDateString()}");
        }
    }
}
