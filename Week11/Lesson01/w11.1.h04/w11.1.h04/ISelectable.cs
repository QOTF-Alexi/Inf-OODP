public interface ISelectable
{
    public void Select();
    public void Deselect();
    public bool IsSelected { get; }
}
