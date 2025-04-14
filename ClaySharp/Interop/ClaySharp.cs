using System.Runtime.InteropServices;

namespace ClaySharp.Interop;

public static unsafe partial class ClaySharp
{
    [DllImport("clay", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Clay_MinMemorySize", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint MinMemorySize();

    [DllImport("clay", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Clay_CreateArenaWithCapacityAndMemory", ExactSpelling = true)]
    public static extern Clay_Arena CreateArenaWithCapacityAndMemory([NativeTypeName("size_t")] nuint capacity, void* memory);

    [DllImport("clay", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Clay_SetPointerState", ExactSpelling = true)]
    public static extern void SetPointerState(Clay_Vector2 position, bool pointerDown);

    [DllImport("clay", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Clay_Initialize", ExactSpelling = true)]
    [return: NativeTypeName("Clay_Context *")]
    public static extern void* Initialize(Clay_Arena arena, Clay_Dimensions layoutDimensions, Clay_ErrorHandler errorHandler);

    [DllImport("clay", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Clay_GetCurrentContext", ExactSpelling = true)]
    [return: NativeTypeName("Clay_Context *")]
    public static extern void* GetCurrentContext();

    [DllImport("clay", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Clay_SetCurrentContext", ExactSpelling = true)]
    public static extern void SetCurrentContext([NativeTypeName("Clay_Context *")] void* context);

    [DllImport("clay", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Clay_UpdateScrollContainers", ExactSpelling = true)]
    public static extern void UpdateScrollContainers(bool enableDragScrolling, Clay_Vector2 scrollDelta, float deltaTime);

    [DllImport("clay", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Clay_SetLayoutDimensions", ExactSpelling = true)]
    public static extern void SetLayoutDimensions(Clay_Dimensions dimensions);

    [DllImport("clay", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Clay_BeginLayout", ExactSpelling = true)]
    public static extern void BeginLayout();

    [DllImport("clay", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Clay_EndLayout", ExactSpelling = true)]
    public static extern Clay_RenderCommandArray EndLayout();

    [DllImport("clay", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Clay_GetElementId", ExactSpelling = true)]
    public static extern Clay_ElementId GetElementId(Clay_String idString);

    [DllImport("clay", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Clay_GetElementIdWithIndex", ExactSpelling = true)]
    public static extern Clay_ElementId GetElementIdWithIndex(Clay_String idString, [NativeTypeName("uint32_t")] uint index);

    [DllImport("clay", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Clay_GetElementData", ExactSpelling = true)]
    public static extern Clay_ElementData GetElementData(Clay_ElementId id);

    [DllImport("clay", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Clay_Hovered", ExactSpelling = true)]
    public static extern bool Hovered();

    [DllImport("clay", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Clay_OnHover", ExactSpelling = true)]
    public static extern void OnHover([NativeTypeName("void (*)(Clay_ElementId, Clay_PointerData, intptr_t)")] delegate* unmanaged[Cdecl]<Clay_ElementId, Clay_PointerData, nint, void> onHoverFunction, [NativeTypeName("intptr_t")] nint userData);

    [DllImport("clay", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Clay_PointerOver", ExactSpelling = true)]
    public static extern bool PointerOver(Clay_ElementId elementId);

    [DllImport("clay", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Clay_GetScrollContainerData", ExactSpelling = true)]
    public static extern Clay_ScrollContainerData GetScrollContainerData(Clay_ElementId id);

    [DllImport("clay", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Clay_SetMeasureTextFunction", ExactSpelling = true)]
    public static extern void SetMeasureTextFunction([NativeTypeName("Clay_Dimensions (*)(Clay_StringSlice, Clay_TextElementConfig *, void *)")] delegate* unmanaged[Cdecl]<Clay_StringSlice, Clay_TextElementConfig*, void*, Clay_Dimensions> measureTextFunction, void* userData);

    [DllImport("clay", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Clay_SetQueryScrollOffsetFunction", ExactSpelling = true)]
    public static extern void SetQueryScrollOffsetFunction([NativeTypeName("Clay_Vector2 (*)(uint32_t, void *)")] delegate* unmanaged[Cdecl]<uint, void*, Clay_Vector2> queryScrollOffsetFunction, void* userData);

    [DllImport("clay", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Clay_RenderCommandArray_Get", ExactSpelling = true)]
    public static extern Clay_RenderCommand* RenderCommandArray_Get(Clay_RenderCommandArray* array, [NativeTypeName("int32_t")] int index);

    [DllImport("clay", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Clay_SetDebugModeEnabled", ExactSpelling = true)]
    public static extern void SetDebugModeEnabled(bool enabled);

    [DllImport("clay", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Clay_IsDebugModeEnabled", ExactSpelling = true)]
    public static extern bool IsDebugModeEnabled();

    [DllImport("clay", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Clay_SetCullingEnabled", ExactSpelling = true)]
    public static extern void SetCullingEnabled(bool enabled);

    [DllImport("clay", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Clay_GetMaxElementCount", ExactSpelling = true)]
    [return: NativeTypeName("int32_t")]
    public static extern int GetMaxElementCount();

    [DllImport("clay", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Clay_SetMaxElementCount", ExactSpelling = true)]
    public static extern void SetMaxElementCount([NativeTypeName("int32_t")] int maxElementCount);

    [DllImport("clay", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Clay_GetMaxMeasureTextCacheWordCount", ExactSpelling = true)]
    [return: NativeTypeName("int32_t")]
    public static extern int GetMaxMeasureTextCacheWordCount();

    [DllImport("clay", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Clay_SetMaxMeasureTextCacheWordCount", ExactSpelling = true)]
    public static extern void SetMaxMeasureTextCacheWordCount([NativeTypeName("int32_t")] int maxMeasureTextCacheWordCount);

    [DllImport("clay", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Clay_ResetMeasureTextCache", ExactSpelling = true)]
    public static extern void ResetMeasureTextCache();

    [DllImport("clay", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Clay__OpenElement", ExactSpelling = true)]
    public static extern void _OpenElement();

    [DllImport("clay", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Clay__ConfigureOpenElement", ExactSpelling = true)]
    public static extern void _ConfigureOpenElement([NativeTypeName("const Clay_ElementDeclaration")] Clay_ElementDeclaration config);

    [DllImport("clay", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Clay__ConfigureOpenElementPtr", ExactSpelling = true)]
    public static extern void _ConfigureOpenElementPtr([NativeTypeName("const Clay_ElementDeclaration *")] Clay_ElementDeclaration* config);

    [DllImport("clay", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Clay__CloseElement", ExactSpelling = true)]
    public static extern void _CloseElement();

    [DllImport("clay", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Clay__HashString", ExactSpelling = true)]
    public static extern Clay_ElementId _HashString(Clay_String key, [NativeTypeName("uint32_t")] uint offset, [NativeTypeName("uint32_t")] uint seed);

    [DllImport("clay", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Clay__OpenTextElement", ExactSpelling = true)]
    public static extern void _OpenTextElement(Clay_String text, Clay_TextElementConfig* textConfig);

    [DllImport("clay", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Clay__StoreTextElementConfig", ExactSpelling = true)]
    public static extern Clay_TextElementConfig* _StoreTextElementConfig(Clay_TextElementConfig config);

    [DllImport("clay", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Clay__GetParentElementId", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint _GetParentElementId();
}
