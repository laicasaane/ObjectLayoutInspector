using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ObjectLayoutInspector;


TypeLayout.PrintLayout<AnimationState>();
//TypeLayout.PrintLayout<AnimationStateBuffer>();


[Serializable, StructLayout(LayoutKind.Sequential)]
public struct Overridable<T>
{
    public T value;
    public bool isOverridden;
}

[Serializable, StructLayout(LayoutKind.Sequential)]
public partial struct AnimationState
{
    public Overridable<Vector2> pivot;
    public Overridable<float> frameRate;
    public StringId name;
}

[InlineArray(10)]
public struct AnimationStateBuffer
{
    private AnimationState _element0;
}

public struct StringId
{
    public int value;
}