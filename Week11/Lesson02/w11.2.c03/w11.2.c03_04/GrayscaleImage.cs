public class GrayscaleImage
{
    public int Height { get; }
    public int Width { get; }

    public int[,] PixelData { get; }
    //Set PixelData

    public GrayscaleImage(int height, int width)
    {
        Width = width;
        Height = height;
        PixelData = new int[height, width];
    }

    public GrayscaleImage(int[,] pixelData)
    {
        Height = pixelData.GetLength(0);
        Width = pixelData.GetLength(1);
        PixelData = pixelData;
    }

    public void AdjustBrightness(double factor)
    {
        for (int i = 0; i < PixelData.GetLength(0); i++)
        {
            for (int j = 0; j < PixelData.GetLength(1); j++)
            {
                PixelData[i, j] = Convert.ToInt32(Math.Floor(PixelData[i, j] * factor));
            }
        }
    }
}