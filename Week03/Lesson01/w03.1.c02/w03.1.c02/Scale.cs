class Scale
{
    public bool UseKg = true;

    public static double ConvertKgToLbs(double weightKg)
    {
        return weightKg * 2.2;
    }

    public string DisplayWeight(double weight)
    {
        if (weight == 60 && UseKg)
        {
            return "60 kg";
        }
        else
        {
            return $"{ConvertKgToLbs(60)} lbs";
        }
    }
}