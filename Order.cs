using System;
using System.Collections.Generic;

class Order
{
    public string orderId { get; set; }
    public DateTime orderDate { get; set; }
    public DateTime pickupTime { get; set; }
    public string status { get; set; }
    public double totalPrice { get; set; }
    public string qrCode { get; set; }
    public bool noShowFlag { get; set; }

    public List<OrderItem> Items { get; set; } = new List<OrderItem>();

    public Order(string id, DateTime date, DateTime pickup, string status, double price, string qr, bool noShow)
    {
        orderId = id;
        orderDate = date;
        pickupTime = pickup;
        this.status = status;
        totalPrice = price;
        qrCode = qr;
        noShowFlag = noShow;
    }

    public void createOrder(string studentId, List<OrderItem> items, DateTime pickupTime)
    {
        orderId = Guid.NewGuid().ToString();
        orderDate = DateTime.Now;
        this.pickupTime = pickupTime;
        Items = items;
        status = "Pending";
        totalPrice = calculateTotalPrice();
    }

    public double calculateTotalPrice()
    {
        double total = 0;
        foreach (var item in Items)
        {
            total += item.GetSubtotal();
        }
        totalPrice = total;
        return total;
    }

    public void updateStatus(string newStatus)
    {
        status = newStatus;
    }

    public string generateQRCode()
    {
        qrCode = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
        return qrCode;
    }

    public void markNoShow()
    {
        noShowFlag = true;
    }

    public string getOrderSummary()
    {
        string summary = $"Order ID: {orderId}\n" +
                         $"Items: {Items.Count}\n" +
                         $"Total Price: ${totalPrice}\n" +
                         $"Status: {status}\n" +
                         $"Pickup Time: {pickupTime}";
        return summary;
    }

    public void DisplayOrder()
    {
        Console.WriteLine($"Order ID: {orderId}");
        Console.WriteLine($"Order Date: {orderDate}");
        Console.WriteLine($"Pickup Time: {pickupTime}");
        Console.WriteLine($"Status: {status}");
        Console.WriteLine($"Total Price: ${totalPrice}");
        Console.WriteLine($"QR Code: {qrCode}");
        Console.WriteLine($"No Show: {(noShowFlag ? "Yes" : "No")}");
    }
}

class OrderItem
{
    public string orderId { get; set; }
    public string itemName { get; set; }
    public double price { get; set; }
    public int quantity { get; set; }

    public OrderItem(string orderId, string itemName, double price, int quantity)
    {
        this.orderId = orderId;
        this.itemName = itemName;
        this.price = price;
        this.quantity = quantity;
    }

    public double GetSubtotal()
    {
        return price * quantity;
    }
}
