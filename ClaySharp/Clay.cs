using System.Runtime.InteropServices;
using ClaySharp.Interop;

namespace ClaySharp;

public static partial class Clay
{
    private static void ClayElementInternal(Clay_ElementDeclaration config, Action block)
    {
        try
        {
            Interop.ClaySharp._OpenElement();
            Interop.ClaySharp._ConfigureOpenElement(config);
            block.Invoke();
        }
        finally
        {
            Interop.ClaySharp._CloseElement();
        }
    }
    
    public static void Begin(Action block)
    {
        ClayElementInternal(new Clay_ElementDeclaration(), block);
    }

    public static void Begin(Clay_ElementDeclaration config, Action block)
    {
        ClayElementInternal(config, block);
    }
    
    public static unsafe void Text(string text, Clay_TextElementConfig config)
    {
        var textElementConfig = Interop.ClaySharp._StoreTextElementConfig(config);
        Interop.ClaySharp._OpenTextElement(CreateClayString(text), textElementConfig);
    }
}