namespace ClaySharp.Interop;

public unsafe partial struct Clay_StringSlice
{
    [NativeTypeName("int32_t")]
    public int length;

    [NativeTypeName("const char *")]
    public sbyte* chars;

    [NativeTypeName("const char *")]
    public sbyte* baseChars;
}
