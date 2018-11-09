using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(CubeStats))]
public class CubeStatsDrawer: PropertyDrawer {

    public bool initialized = false;

    //float currentWidth, currentHeight;
    Rect varALabel, varARect;

    public void OnEnable() {
        //We would put initialization code here
        initialized = true;
    }

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
        if (!initialized) 
            OnEnable();

        if (GUI.Button((RectEditor.GetRect(new Vector2(0, 0), new Vector2(3, 1), position)), "Sort")) {



        }

        SerializedProperty SP = property.FindPropertyRelative("a");


        EditorGUI.LabelField((RectEditor.GetRect(new Vector2(0, 1), new Vector2(2, 1), position)), "z");
        EditorGUI.FloatField((RectEditor.GetRect(new Vector2(2, 1), new Vector2(3, 1), position)), 0);

        EditorGUI.LabelField((RectEditor.GetRect(new Vector2(0, 2), new Vector2(8, 1), position)), "b");
        EditorGUI.FloatField((RectEditor.GetRect(new Vector2(2, 2), new Vector2(6, 1), position)), 0);
    }

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label) {
        if (!initialized)
            OnEnable();

        return 100;
    }
}
