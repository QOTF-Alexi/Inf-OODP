public static class CleaningService
{
    public static void Clean(ICleanable thing)
    {
        thing.Clean();
    }
    
    public static void Clean(List<ICleanable> things)
    {
        foreach (var thing in things)
        {
            thing.Clean();
        }
    }
}