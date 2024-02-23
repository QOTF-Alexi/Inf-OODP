public class ShoppingCart
{
    public List<GroupedShopItem> Groceries;

    public ShoppingCart()
    {
        Groceries = new();
    }

    public void AddItem(ShopItem Item)
    {
        bool contains = false;
        foreach(GroupedShopItem item in Groceries)
        {
            if(item.Item == Item)
            {
                contains = true;
                item.Quantity += 1;
                break;
            }
        }

        if (!contains)
        {
            Groceries.Add(new GroupedShopItem(Item));
        }
    }

    public GroupedShopItem FindItem(ShopItem Item)
    {
        foreach(GroupedShopItem item in Groceries)
        {
            if(item.Item == Item)
            {
                return item;
            }
        }
        return null;
    }

    public void Contents()
    {
        foreach (GroupedShopItem item in Groceries)
        {
            Console.WriteLine($"{item.Item.Name} x {item.Quantity}");
        }
    }

    public double TotalPrice()
    {
        double TotalPrice = 0;
        foreach (GroupedShopItem item in Groceries)
        {
            TotalPrice += (item.Item.Price * item.Quantity);
        }

        return TotalPrice;
    }
}