class ProgressPopup : Popup
{
    private int _progress = 0;
    private string _progressBar = "";

    public ProgressPopup(string message) : base(message)
    {
        Message = message;
        Display();
    }

    public void IncreaseProgress(int amount)
    {
        _progress += amount;
        if (_progress > 100) _progress = 100;
        Display();
    }

    public override void Display()
    {
        base.Display();
        _progressBar = new string('|', _progress / 10);
        Console.WriteLine(_progress + "%     " + _progressBar);
    }
}
