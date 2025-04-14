namespace ClaySharp.Interop;

public unsafe partial struct Clay_ElementDeclaration
{
    public Clay_ElementId id;

    public Clay_LayoutConfig layout;

    public Clay_Color backgroundColor;

    public Clay_CornerRadius cornerRadius;

    public Clay_ImageElementConfig image;

    public Clay_FloatingElementConfig floating;

    public Clay_CustomElementConfig custom;

    public Clay_ScrollElementConfig scroll;

    public Clay_BorderElementConfig border;

    public void* userData;
}
