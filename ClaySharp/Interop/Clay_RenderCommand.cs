namespace ClaySharp.Interop;

public unsafe partial struct Clay_RenderCommand
{
    public Clay_BoundingBox boundingBox;

    public Clay_RenderData renderData;

    public void* userData;

    [NativeTypeName("uint32_t")]
    public uint id;

    [NativeTypeName("int16_t")]
    public short zIndex;

    public Clay_RenderCommandType commandType;
}
