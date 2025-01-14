namespace ClayUI.Interop;

public partial struct Clay_FloatingElementConfig
{
    public Clay_Vector2 offset;

    public Clay_Dimensions expand;

    [NativeTypeName("uint16_t")]
    public ushort zIndex;

    [NativeTypeName("uint32_t")]
    public uint parentId;

    public Clay_FloatingAttachPoints attachment;

    public Clay_PointerCaptureMode pointerCaptureMode;
}
