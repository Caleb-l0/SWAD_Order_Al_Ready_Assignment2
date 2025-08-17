using System;

class OrderItem
{
    public string ItemId { get; set; }
    public int Quantity { get; set; }
    public double UnitPrice { get; set; }

    public OrderItem(string itemId, int quantity, double unitPrice)
    {
        ItemId = itemId;
        Quantity = quantity;
        UnitPrice = unitPrice;
    }

    public void AddItem(int quantity)
    {
        Quantity += quantity;
        Console.WriteLine($"{quantity} more of {ItemId} added. New quantity: {Quantity}");
    }
    public void RemoveItem()
    {
        Console.WriteLine($"Removed {ItemId} from order.");
        Quantity = 0;
    }

    public void UpdateQuantity(int quantity)
    {
        Quantity = quantity;
        Console.WriteLine($"{ItemId} quantity updated to {Quantity}");
    }

    public double CalculateItemPrice()
    {
        return Quantity * UnitPrice;
    }
    public void DisplayItem()
    {
        Console.WriteLine($"Item: {ItemId}, Quantity: {Quantity}, Unit Price: ${UnitPrice}, Total: ${CalculateItemPrice()}");
    }
}
