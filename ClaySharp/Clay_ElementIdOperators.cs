namespace ClaySharp.Interop;

public partial struct Clay_ElementId : IEquatable<Clay_ElementId>
{
    
    public bool Equals(Clay_ElementId other)
    {
        return id == other.id && offset == other.offset && baseId == other.baseId;
    }

    public override bool Equals(object? obj)
    {
        return obj is Clay_ElementId other && Equals(other);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(id, offset, baseId);
    }

    public static bool operator ==(Clay_ElementId left, Clay_ElementId right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(Clay_ElementId left, Clay_ElementId right)
    {
        return !left.Equals(right);
    }
}