namespace ClaySharp.Interop;

[NativeTypeName("uint8_t")]
public enum Clay_FloatingAttachToElement : byte
{
    CLAY_ATTACH_TO_NONE,
    CLAY_ATTACH_TO_PARENT,
    CLAY_ATTACH_TO_ELEMENT_WITH_ID,
    CLAY_ATTACH_TO_ROOT,
}
