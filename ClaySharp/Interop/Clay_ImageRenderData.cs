namespace ClaySharp.Interop;

public unsafe partial struct Clay_ImageRenderData
{
    public Clay_Color backgroundColor;

    public Clay_CornerRadius cornerRadius;

    public Clay_Dimensions sourceDimensions;

    public void* imageData;
}
