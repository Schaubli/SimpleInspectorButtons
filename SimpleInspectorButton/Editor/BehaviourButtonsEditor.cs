using UnityEditor;
using UnityEngine;


/// <summary>
/// Custom editor for all MonoBehaviour scripts in order to draw buttons for all [Button] attributes.
/// </summary>
[CustomEditor( typeof( MonoBehaviour ), true, isFallback = true )]
[CanEditMultipleObjects]
public class BehaviourButtonsEditor : Editor
{
	private ButtonAttributeHelper helper = new ButtonAttributeHelper();

	public override void OnInspectorGUI()
	{
		base.OnInspectorGUI();
		helper.DrawButtons();
	}

	private void OnEnable()
	{
		helper.Init( target );
	}
}
