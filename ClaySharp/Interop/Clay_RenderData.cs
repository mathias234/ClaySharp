using System.Runtime.InteropServices;

namespace ClaySharp.Interop;

[StructLayout(LayoutKind.Explicit)]
public partial struct Clay_RenderData
{
    [FieldOffset(0)]
    public Clay_RectangleRenderData rectangle;

    [FieldOffset(0)]
    public Clay_TextRenderData text;

    [FieldOffset(0)]
    public Clay_ImageRenderData image;

    [FieldOffset(0)]
    public Clay_CustomRenderData custom;

    [FieldOffset(0)]
    public Clay_BorderRenderData border;

    [FieldOffset(0)]
    public Clay_ScrollRenderData scroll;
}
