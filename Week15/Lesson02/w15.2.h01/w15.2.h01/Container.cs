using System.Globalization;

public class Container
{
    public string Code { get; }
    public string Manifest { get; }
    public string[] Categories { get; }
    public string Origin { get; }
    public double Weight { get; } //in kilograms rounded up by 2 decimals (convert the lbs value from the manifest to kg by multiplying with 0.45359237)
    public ContainerStatus Status { get; set; }
    
    public double ActualWeight { get; } //in kilograms rounded up by 2 decimals (convert the lbs value from the manifest to kg by multiplying with 0.45359237)

    public Container(string code, string manifest, string[] categories, string origin, string weight, string actual_weight)//, int status)
    {
        Code = code;
        Manifest = manifest;
        Categories = categories;
        Origin = origin;
        var validWeight = weight.Replace(" lbs", "");
        Weight = Math.Round(Convert.ToDouble(validWeight) * 0.45359237, 2);
        var validActualWeight = actual_weight.Replace(" lbs", "");
        ActualWeight = Math.Round(Convert.ToDouble(validActualWeight) * 0.45359237, 2);
        Status = ContainerStatus.Processing;
    }

    public override string ToString()
    {
        return $"Container(Code:'{Code}', Manifest:'{Manifest}', Categories:'{String.Join(',', Categories)}', Origin:'{Origin}', Status:'{Status}', Weight:'{Weight}', ActualWeight:'{ActualWeight}')";
    }
}