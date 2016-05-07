using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(SetRandomRotationandScale))]
[CanEditMultipleObjects]
public class SetRandomRotationandScaleEditor : Editor {

    float MinScale = 1f, MaxScale = 2f;

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        SetRandomRotationandScale myScript = (SetRandomRotationandScale)target;
        if (GUILayout.Button("Set Random Rotation"))
        {
            myScript.Randomrotation();
        }
        EditorGUILayout.MinMaxSlider(ref MinScale, ref MaxScale, 1,3);
        if (GUILayout.Button("Set Random Scale"))
        {
            myScript.RandomScale(MinScale,MaxScale);
        }
    }
}
