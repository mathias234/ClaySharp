namespace ClayUI.Interop;

public unsafe partial struct Clay_ErrorHandler
{
    [NativeTypeName("void (*)(Clay_ErrorData)")]
    public delegate* unmanaged[Cdecl]<Clay_ErrorData, void> errorHandlerFunction;

    [NativeTypeName("uintptr_t")]
    public nuint userData;
}
