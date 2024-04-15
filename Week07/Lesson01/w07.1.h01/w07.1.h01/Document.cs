public class Document
{
    public string BackGroundColor { get; }
    public string FontColor { get; }

    public Document(string backGroundColor, string fontColor)
    {
        BackGroundColor = backGroundColor;
        FontColor = fontColor;
    }
}