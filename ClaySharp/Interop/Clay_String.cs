namespace ClaySharp.Interop;

public unsafe partial struct Clay_String
{
    [NativeTypeName("int32_t")]
    public int length;

    [NativeTypeName("const char *")]
    public sbyte* chars;
}
