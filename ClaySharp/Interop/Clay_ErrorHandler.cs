namespace ClaySharp.Interop;

public unsafe partial struct Clay_ErrorHandler
{
    [NativeTypeName("void (*)(Clay_ErrorData)")]
    public delegate* unmanaged[Cdecl]<Clay_ErrorData, void> errorHandlerFunction;

    public void* userData;
}
