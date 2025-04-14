namespace ClaySharp.Interop;

public partial struct Clay_FloatingElementConfig
{
    public Clay_Vector2 offset;

    public Clay_Dimensions expand;

    [NativeTypeName("uint32_t")]
    public uint parentId;

    [NativeTypeName("int16_t")]
    public short zIndex;

    public Clay_FloatingAttachPoints attachPoints;

    public Clay_PointerCaptureMode pointerCaptureMode;

    public Clay_FloatingAttachToElement attachTo;
}
