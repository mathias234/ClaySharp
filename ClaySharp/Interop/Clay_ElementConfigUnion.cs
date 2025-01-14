using System.Runtime.InteropServices;

namespace ClayUI.Interop;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct Clay_ElementConfigUnion
{
    [FieldOffset(0)]
    public Clay_RectangleElementConfig* rectangleElementConfig;

    [FieldOffset(0)]
    public Clay_TextElementConfig* textElementConfig;

    [FieldOffset(0)]
    public Clay_ImageElementConfig* imageElementConfig;

    [FieldOffset(0)]
    public Clay_FloatingElementConfig* floatingElementConfig;

    [FieldOffset(0)]
    public Clay_CustomElementConfig* customElementConfig;

    [FieldOffset(0)]
    public Clay_ScrollElementConfig* scrollElementConfig;

    [FieldOffset(0)]
    public Clay_BorderElementConfig* borderElementConfig;
}
