
/// <summary>
/// Put the attribute [Button] above one of your MonoBehaviour method and it will draw
/// a button in the inspector automatically.
///
/// NOTE: the method must not have any params and can not be static.

[System.AttributeUsage( System.AttributeTargets.Method )]
public class ButtonAttribute : System.Attribute
{
}
