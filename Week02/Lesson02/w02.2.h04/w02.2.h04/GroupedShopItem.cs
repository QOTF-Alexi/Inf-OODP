public class GroupedShopItem
{
    public ShopItem Item;
    public int Quantity;
    
    public GroupedShopItem(ShopItem Item)
    {
        this.Item = Item;
        Quantity = 1;
    }
}