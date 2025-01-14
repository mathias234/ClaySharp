namespace ClaySharp.Interop;

public partial struct Clay_RenderCommand
{
    public Clay_BoundingBox boundingBox;

    public Clay_ElementConfigUnion config;

    public Clay_String text;

    [NativeTypeName("uint32_t")]
    public uint id;

    public Clay_RenderCommandType commandType;
}
