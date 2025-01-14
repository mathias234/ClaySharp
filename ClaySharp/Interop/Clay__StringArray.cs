namespace ClaySharp.Interop;

public unsafe partial struct Clay__StringArray
{
    [NativeTypeName("int32_t")]
    public int capacity;

    [NativeTypeName("int32_t")]
    public int length;

    public Clay_String* internalArray;
}
