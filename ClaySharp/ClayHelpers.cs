using System.Runtime.InteropServices;
using ClaySharp.Interop;

namespace ClaySharp;

public static partial class Clay
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate Clay_Dimensions MeasureTextFunction(Clay_String* str, Clay_TextElementConfig* config);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnHoverFunction(Clay_ElementId elementId, Clay_PointerData pointerData, IntPtr userData);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void ErrorHandlerFunction(Clay_ErrorData errorData);


    
    public static Clay_SizingAxis SizingFit(Clay_SizingMinMax? minMax = null)
    {
        return new Clay_SizingAxis()
        {
            size = new Clay_SizingAxis._size_e__Union() { minMax = minMax ?? default },
            type = Clay__SizingType.CLAY__SIZING_TYPE_FIT
        };
    }
    
    public static Clay_SizingAxis SizingGrow(Clay_SizingMinMax? minMax = null)
    {
        return new Clay_SizingAxis()
        {
            size = new Clay_SizingAxis._size_e__Union() { minMax = minMax ?? default },
            type = Clay__SizingType.CLAY__SIZING_TYPE_GROW
        };
    }

    public static Clay_SizingAxis SizingFixed(uint size)
    {
        return new Clay_SizingAxis()
        {
            size = new Clay_SizingAxis._size_e__Union() { minMax = new Clay_SizingMinMax() { max = size, min = size } },
            type = Clay__SizingType.CLAY__SIZING_TYPE_FIXED
        };
    }
    
    public static Clay_ElementId GetElementId(string str)
    {
        var clayStr = CreateClayString(str);

        return Interop.ClaySharp.GetElementId(clayStr);
    }

    public static unsafe void Initialize(Clay_Arena arena, Clay_Dimensions layoutDimensions, ErrorHandlerFunction errorHandlerFunction)
    {
        var functionPointer =
            (delegate* unmanaged[Cdecl]<Clay_ErrorData, void>)
            Marshal.GetFunctionPointerForDelegate(errorHandlerFunction);
        
        Interop.ClaySharp.Initialize(arena, layoutDimensions, new Clay_ErrorHandler() { errorHandlerFunction = functionPointer});
    }

    
    public static unsafe void SetMeasureTextFunction(MeasureTextFunction measureTextFunction)
    {
        var functionPointer =
            (delegate* unmanaged[Cdecl]<Clay_String*, Clay_TextElementConfig*, Clay_Dimensions>)
            Marshal.GetFunctionPointerForDelegate(measureTextFunction);

        Interop.ClaySharp.SetMeasureTextFunction(functionPointer);
    }

    
    public static unsafe void OnHover(OnHoverFunction onHover, IntPtr? userData)
    {
        var functionPointer =
            (delegate* unmanaged[Cdecl]<Clay_ElementId, Clay_PointerData, nint, void>)
            Marshal.GetFunctionPointerForDelegate(onHover);

        Interop.ClaySharp.OnHover(functionPointer, userData ?? IntPtr.Zero);
    }
    
    public static Clay_ScrollContainerData GetScrollContainerData(Clay_ElementId elementId)
    {
        // Pass the pointer to the unmanaged function
        return Interop.ClaySharp.GetScrollContainerData(elementId);
    }

    public static unsafe Clay_String CreateClayString(string input)
    {
        // Convert string to UTF-8 byte array
        byte[] utf8Bytes = System.Text.Encoding.UTF8.GetBytes(input);

        // Allocate unmanaged memory for the string and copy bytes
        IntPtr unmanagedPointer = Marshal.AllocHGlobal(utf8Bytes.Length + 1); // +1 for null terminator
        Marshal.Copy(utf8Bytes, 0, unmanagedPointer, utf8Bytes.Length);
        Marshal.WriteByte(unmanagedPointer + utf8Bytes.Length, 0); // Null terminator

        // Fill the Clay_String struct
        return new Clay_String
        {
            length = utf8Bytes.Length,
            chars = (sbyte*)unmanagedPointer
        };
    }

    public static unsafe string CreateCSString(Clay_String clayString)
    {
        if (clayString.chars == null)
        {
            return string.Empty;
        }

        // Use Marshal.PtrToStringUTF8 to convert the null-terminated string
        return Marshal.PtrToStringUTF8((IntPtr)clayString.chars, (int)clayString.length);
    }
}