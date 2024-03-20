using System;
using System.Reflection;

class Present
{
    private object _contents;
    public bool IsWrapped { get; private set; }
    
    public Present(object contents)
    {
        _contents = contents;
        IsWrapped = true;
    }

    public string Hint
    {
        get
        {
            if (IsWrapped)
            {
                if (_contents.GetType() == typeof(BoardGame))
                {
                    PropertyInfo property = _contents.GetType().GetProperty("Publisher");
                    string publisher = (string)property.GetValue(_contents);
                    return $"It is a board game by {publisher}";
                }
                return _contents switch
                {
                    Lego => "It is a Lego set!",
                    BoardGame => $"It is a board game by {null}",
                    Movie => "It is a movie!",
                    Toy => "It is a toy!",
                    _ => "It is a surprise!"
                };
            }

            return "It is already unwrapped.";
        }
    }

    public void Unwrap() => IsWrapped = false;

    public object? GetContents()
    {
        if (IsWrapped)
            return null;
        return _contents;
    }
}