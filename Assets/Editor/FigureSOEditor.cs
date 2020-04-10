
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(FigureSettingsSO))]
public class FigureSOEditor : Editor
{

    public override void OnInspectorGUI()// Rect position, SerializedProperty property, GUIContent label)
    {
        base.OnInspectorGUI();

        FigureSettingsSO script = target as FigureSettingsSO;
        if (script.colorizationType == FigureSettingsSO.ColorisationType.OneClickNewColor)
            script.ClicksReference = null;

            
    }
}

