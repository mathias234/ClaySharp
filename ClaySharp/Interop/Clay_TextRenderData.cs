namespace ClaySharp.Interop;

public partial struct Clay_TextRenderData
{
    public Clay_StringSlice stringContents;

    public Clay_Color textColor;

    [NativeTypeName("uint16_t")]
    public ushort fontId;

    [NativeTypeName("uint16_t")]
    public ushort fontSize;

    [NativeTypeName("uint16_t")]
    public ushort letterSpacing;

    [NativeTypeName("uint16_t")]
    public ushort lineHeight;
}
