using ClayUI.Interop;

namespace ClayUI;

public static partial class Clay
{
    public static Action Id(string id)
    {
        Clay_String clayString = CreateClayString(id);
        var elementId = Interop.ClayUI._HashString(clayString, 0, 0);
        return () => { Interop.ClayUI._AttachId(elementId); };
    }

    public static unsafe Action Layout(
        (Clay_SizingAxis width, Clay_SizingAxis height) sizing = default,
        (ushort left, ushort right, ushort top, ushort bottom) padding = default,
        ushort childGap = 0,
        (Clay_LayoutAlignmentX x, Clay_LayoutAlignmentY y) childAlignment = default,
        Clay_LayoutDirection direction = default)
    {
        var claySizing = new Clay_Sizing() { width = sizing.width, height = sizing.height };

        var clayPadding = new Clay_Padding() { left = padding.left, right = padding.right, top = padding.top, bottom = padding.bottom };

        var clayChildAlignment = new Clay_ChildAlignment() { x = childAlignment.x, y = childAlignment.y };

        var layoutConfig = new Clay_LayoutConfig()
        {
            sizing = claySizing,
            padding = clayPadding,
            childGap = childGap,
            childAlignment = clayChildAlignment,
            layoutDirection = direction
        };

        return () => { Interop.ClayUI._AttachLayoutConfig(Interop.ClayUI._StoreLayoutConfig(layoutConfig)); };
    }

    public static unsafe Action Rectangle((float r, float g, float b, float a) color = default,
        (float topLeft, float topRight, float bottomLeft, float bottomRight) cornerRadius = default)
    {
        var clayColor = new Clay_Color() { r = color.r, g = color.g, b = color.b, a = color.a };

        var clayCornerRadius = new Clay_CornerRadius() {
            topLeft = cornerRadius.topLeft, 
            topRight = cornerRadius.topRight, 
            bottomLeft = cornerRadius.bottomLeft, 
            bottomRight = cornerRadius.bottomRight
        };

        var config = new Clay_RectangleElementConfig
        {
            color = clayColor,
            cornerRadius = clayCornerRadius
        };

        return () =>
        {
            var storedConfig = Interop.ClayUI._StoreRectangleElementConfig(config);
            var union = new Clay_ElementConfigUnion()
            {
                rectangleElementConfig = storedConfig
            };

            Interop.ClayUI._AttachElementConfig(union, Clay__ElementConfigType.CLAY__ELEMENT_CONFIG_TYPE_RECTANGLE);
        };
    }
    
    
    public static unsafe Action Border(
        uint topWidth = 1,
        uint bottomWidth = 1,
        uint rightWidth = 1,
        uint leftWidth = 1,
        (float r, float g, float b, float a) topColor = default,
        (float r, float g, float b, float a) bottomColor = default,
        (float r, float g, float b, float a) rightColor = default,
        (float r, float g, float b, float a) leftColor = default,
        (float topLeft, float topRight, float bottomLeft, float bottomRight) cornerRadius = default)
    {
        var clayTopColor = new Clay_Color() { r = topColor.r, g = topColor.g, b = topColor.b, a = topColor.a };
        var clayBottomColor = new Clay_Color() { r = bottomColor.r, g = bottomColor.g, b = bottomColor.b, a = bottomColor.a };
        var clayRightColor = new Clay_Color() { r = rightColor.r, g = rightColor.g, b = rightColor.b, a = rightColor.a };
        var clayLeftColor = new Clay_Color() { r = leftColor.r, g = leftColor.g, b = leftColor.b, a = leftColor.a };

        var clayCornerRadius = new Clay_CornerRadius() {
            topLeft = cornerRadius.topLeft, 
            topRight = cornerRadius.topRight, 
            bottomLeft = cornerRadius.bottomLeft, 
            bottomRight = cornerRadius.bottomRight
        };

        var config = new Clay_BorderElementConfig()
        {
            top = new Clay_Border()
            {
                color = clayTopColor,
                width = topWidth
            },
            bottom = new Clay_Border()
            {
                color = clayBottomColor,
                width = bottomWidth
            },
            right = new Clay_Border()
            {
                color = clayRightColor,
                width = rightWidth
            },
            left = new Clay_Border()
            {
                color = clayLeftColor,
                width = leftWidth
            },
            cornerRadius = clayCornerRadius
        };

        return () =>
        {
            var storedConfig = Interop.ClayUI._StoreBorderElementConfig(config);
            var union = new Clay_ElementConfigUnion()
            {
                borderElementConfig = storedConfig
            };

            Interop.ClayUI._AttachElementConfig(union, Clay__ElementConfigType.CLAY__ELEMENT_CONFIG_TYPE_BORDER_CONTAINER);
        };
    }

    public static Action Border(
        uint width = 1,
        (float r, float g, float b, float a) color = default,
        (float topLeft, float topRight, float bottomLeft, float bottomRight) cornerRadius = default)
    {
        return Border(width, width, width, width, color, color, color, color, cornerRadius);
    }

    public static unsafe Action Scroll(bool horizontal = false, bool vertical = false)
    {
        var config = new Clay_ScrollElementConfig
        {
            horizontal = horizontal,
            vertical = vertical
        };

        return () =>
        {
            var storedConfig = Interop.ClayUI._StoreScrollElementConfig(config);
            var union = new Clay_ElementConfigUnion()
            {
                scrollElementConfig = storedConfig
            };

            Interop.ClayUI._AttachElementConfig(union, Clay__ElementConfigType.CLAY__ELEMENT_CONFIG_TYPE_SCROLL_CONTAINER);
        };
    }
    
    public static unsafe Action Floating(
        uint parentId = 0,
        ushort zIndex = 0, 
        (float width, float height) expand = default, 
        (float x, float y) offset = default, 
        Clay_FloatingAttachPointType parentAttachment = Clay_FloatingAttachPointType.CLAY_ATTACH_POINT_LEFT_TOP, 
        Clay_FloatingAttachPointType elementAttachment = Clay_FloatingAttachPointType.CLAY_ATTACH_POINT_LEFT_TOP,
        Clay_PointerCaptureMode captureMode = Clay_PointerCaptureMode.CLAY_POINTER_CAPTURE_MODE_CAPTURE)
    {
        var config = new Clay_FloatingElementConfig()
        {
            offset = new Clay_Vector2() {x = offset.x, y = offset.y},
            expand = new Clay_Dimensions() {width = expand.width, height = expand.height},
            pointerCaptureMode = captureMode,
            parentId = parentId,
            zIndex = zIndex,
            attachment = new Clay_FloatingAttachPoints()
            {
                parent = parentAttachment,
                element = elementAttachment
            }
        };

        return () =>
        {
            var storedConfig = Interop.ClayUI._StoreFloatingElementConfig(config);
            var union = new Clay_ElementConfigUnion()
            {
                floatingElementConfig = storedConfig
            };

            Interop.ClayUI._AttachElementConfig(union, Clay__ElementConfigType.CLAY__ELEMENT_CONFIG_TYPE_FLOATING_CONTAINER);
        };
    }
}
