namespace ClaySharp.Interop;

public unsafe partial struct Clay_TextElementConfig
{
    public void* userData;

    public Clay_Color textColor;

    [NativeTypeName("uint16_t")]
    public ushort fontId;

    [NativeTypeName("uint16_t")]
    public ushort fontSize;

    [NativeTypeName("uint16_t")]
    public ushort letterSpacing;

    [NativeTypeName("uint16_t")]
    public ushort lineHeight;

    public Clay_TextElementConfigWrapMode wrapMode;

    public Clay_TextAlignment textAlignment;
}
