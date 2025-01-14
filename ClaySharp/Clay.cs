using System.Runtime.InteropServices;
using ClayUI.Interop;

namespace ClayUI;

public static partial class Clay
{
    private static void ClayElementInternal(Action[] configurations, Action block)
    {
        try
        {
            Interop.ClayUI._OpenElement();
            foreach (var configuration in configurations)
            {
                configuration.Invoke();
            }
            Interop.ClayUI._ElementPostConfiguration(); 

            block.Invoke();
        }
        finally
        {
            Interop.ClayUI._CloseElement();
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
        var textElementConfig = Interop.ClayUI._StoreTextElementConfig(config);
        Interop.ClayUI._OpenTextElement(CreateClayString(text), textElementConfig);
    }
}