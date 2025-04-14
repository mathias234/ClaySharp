namespace ClaySharp.Interop;

[NativeTypeName("uint8_t")]
public enum Clay_PointerDataInteractionState : byte
{
    CLAY_POINTER_DATA_PRESSED_THIS_FRAME,
    CLAY_POINTER_DATA_PRESSED,
    CLAY_POINTER_DATA_RELEASED_THIS_FRAME,
    CLAY_POINTER_DATA_RELEASED,
}
