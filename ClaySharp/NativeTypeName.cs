namespace ClaySharp;

[AttributeUsage(AttributeTargets.All)]
public class NativeTypeName(string type) : System.Attribute
{
    private string _type = type;
}
