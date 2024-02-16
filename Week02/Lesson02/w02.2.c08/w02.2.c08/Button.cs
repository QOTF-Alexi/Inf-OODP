using System.Threading.Channels;

public class Button
{
    public bool IsPressed;
    public int TimesPressed;
    
    public Button(bool IsPressed = false, int TimesPressed = 0)
    {
        this.IsPressed = IsPressed;
        this.TimesPressed = TimesPressed;
    }

    public void Press()
    {
        IsPressed = !IsPressed;
        TimesPressed += 1;
    }

    public string Info() => IsPressed switch
    {
        true => $"Button is pressed.\nPressed {TimesPressed} times.",
        _ => $"Button is not pressed.\nPressed {TimesPressed} times."
    };
}