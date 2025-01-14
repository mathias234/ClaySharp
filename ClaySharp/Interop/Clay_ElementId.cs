namespace ClayUI.Interop;

public partial struct Clay_ElementId
{
    [NativeTypeName("uint32_t")]
    public uint id;

    [NativeTypeName("uint32_t")]
    public uint offset;

    [NativeTypeName("uint32_t")]
    public uint baseId;

    public Clay_String stringId;
}
