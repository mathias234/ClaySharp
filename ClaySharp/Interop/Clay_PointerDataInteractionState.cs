namespace ClayUI.Interop;

[NativeTypeName("unsigned int")]
public enum Clay_PointerDataInteractionState : uint
{
    CLAY_POINTER_DATA_PRESSED_THIS_FRAME,
    CLAY_POINTER_DATA_PRESSED,
    CLAY_POINTER_DATA_RELEASED_THIS_FRAME,
    CLAY_POINTER_DATA_RELEASED,
}
