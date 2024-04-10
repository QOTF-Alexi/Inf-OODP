public static class Converter
{
    public static T2 ConvertVariables<T1, T2>(T1 item) => (T2)Convert.ChangeType(item, typeof(T2));
}