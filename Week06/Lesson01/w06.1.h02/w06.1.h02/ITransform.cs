public interface ITransform
{
    public bool IsTransformed { get; }

    public void Transform();

    public void Revert();
}
