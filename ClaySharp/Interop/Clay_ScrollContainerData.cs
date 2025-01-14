namespace ClayUI.Interop;

public unsafe partial struct Clay_ScrollContainerData
{
    public Clay_Vector2* scrollPosition;

    public Clay_Dimensions scrollContainerDimensions;

    public Clay_Dimensions contentDimensions;

    public Clay_ScrollElementConfig config;

    public bool found;
}
