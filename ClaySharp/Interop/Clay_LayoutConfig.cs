namespace ClaySharp.Interop;

public partial struct Clay_LayoutConfig
{
    public Clay_Sizing sizing;

    public Clay_Padding padding;

    [NativeTypeName("uint16_t")]
    public ushort childGap;

    public Clay_ChildAlignment childAlignment;

    public Clay_LayoutDirection layoutDirection;
}
