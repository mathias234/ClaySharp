using System.Runtime.InteropServices;

namespace ClayUI.Interop;

public partial struct Clay_SizingAxis
{
    [NativeTypeName("__AnonymousRecord_clay_L281_C5")]
    public _size_e__Union size;

    public Clay__SizingType type;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _size_e__Union
    {
        [FieldOffset(0)]
        public Clay_SizingMinMax minMax;

        [FieldOffset(0)]
        public float percent;
    }
}
