namespace ClayUI.Interop;

public unsafe partial struct Clay_Arena
{
    [NativeTypeName("uintptr_t")]
    public nuint nextAllocation;

    [NativeTypeName("size_t")]
    public nuint capacity;

    [NativeTypeName("char *")]
    public sbyte* memory;
}
