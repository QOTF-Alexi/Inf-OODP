using Newtonsoft.Json;

public static class InventoryManager
{
    public static List<Plant> ReadInventory(string dataset)
    {
        string jsonString = File.ReadAllText(dataset);
        return JsonConvert.DeserializeObject<List<Plant>>(jsonString)!;
    }

    public static List<Plant> DetectLowInventory(List<Plant> inventory)
    {
        return (from item in inventory where item.Stock < 5 orderby item.Stock select item).ToList();
    }

    public static List<Plant> SearchByCategory(List<Plant> inventory, string category)
    {
        return (from item in inventory where item.Category == category select item).ToList();
    }

    public static List<Plant> LastSoldItems(List<Plant> inventory)
    {
        Plant lastSoldPlant = inventory.OrderByDescending(p => p.LastSold).FirstOrDefault();

        // Return a list of all plants that have been sold
        return inventory.Where(p => p.LastSold == lastSoldPlant.LastSold).ToList();
    }

    public static List<Plant> PotentialRemoval(List<Plant> inventory)
    {
        return inventory
            .Where(p => p.LastSold.AddMonths(16) < DateOnly.FromDateTime(DateTime.Now) && p.Stock >= 10)
            .ToList();
    }

}