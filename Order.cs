using System;

class Order
{
    public string orderId { get; set; }
    public DateTime orderDate { get; set; }
    public DateTime pickupTime { get; set; }
    public string status { get; set; }
    public double totalPrice { get; set; }
    public string qrCode { get; set; }
    public bool noShowFlag { get; set; }

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
