namespace ClaySharp.Interop;

public unsafe partial struct Clay_ErrorData
{
    public Clay_ErrorType errorType;

    public Clay_String errorText;

    public void* userData;
}
