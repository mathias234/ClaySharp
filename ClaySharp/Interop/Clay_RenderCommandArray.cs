namespace ClaySharp.Interop;

public unsafe partial struct Clay_RenderCommandArray
{
    [NativeTypeName("int32_t")]
    public int capacity;

    [NativeTypeName("int32_t")]
    public int length;

    public Clay_RenderCommand* internalArray;
}
