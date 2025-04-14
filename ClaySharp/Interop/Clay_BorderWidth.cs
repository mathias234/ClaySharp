namespace ClaySharp.Interop;

public partial struct Clay_BorderWidth
{
    [NativeTypeName("uint16_t")]
    public ushort left;

    [NativeTypeName("uint16_t")]
    public ushort right;

    [NativeTypeName("uint16_t")]
    public ushort top;

    [NativeTypeName("uint16_t")]
    public ushort bottom;

    [NativeTypeName("uint16_t")]
    public ushort betweenChildren;
}
