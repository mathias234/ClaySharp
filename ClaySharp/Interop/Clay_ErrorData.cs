namespace ClaySharp.Interop;

public partial struct Clay_ErrorData
{
    public Clay_ErrorType errorType;

    public Clay_String errorText;

    [NativeTypeName("uintptr_t")]
    public nuint userData;
}
