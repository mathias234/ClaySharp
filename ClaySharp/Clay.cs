using System.Runtime.InteropServices;
using ClaySharp.Interop;

namespace ClaySharp;

public static partial class Clay
{
    private static void ClayElementInternal(Action[] configurations, Action block)
    {
        try
        {
            Interop.ClaySharp._OpenElement();
            foreach (var configuration in configurations)
            {
                configuration.Invoke();
            }
            Interop.ClaySharp._ElementPostConfiguration(); 

            block.Invoke();
        }
        finally
        {
            Interop.ClaySharp._CloseElement();
        }
    }
    
    public static void Begin(Action block)
    {
        ClayElementInternal([], block);
    }

    public static void Begin(Action[] configuration, Action block)
    {
        ClayElementInternal(configuration, block);
    }
    
    public static unsafe void Text(string text, Clay_TextElementConfig config)
    {
        var textElementConfig = Interop.ClaySharp._StoreTextElementConfig(config);
        Interop.ClaySharp._OpenTextElement(CreateClayString(text), textElementConfig);
    }
}