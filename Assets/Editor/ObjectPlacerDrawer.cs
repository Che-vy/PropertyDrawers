using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Linq;

public class ObjectPlacerDrawer : EditorWindow
{
    bool initialized;

    //Popup vars
    string[] enumAsString;
    public string[] prefabAsString;
    int selectedPopupIndex;
    int i = 0;
    string buttonName;
    Texture texture;
    GameObject gO;

    [MenuItem("Personal Tools/Object Tool")]
    public static void f()
    {
        Debug.Log("passed through menuitem part");
        // Get existing open window or if none, make a new one:
        ObjectPlacerDrawer window = (ObjectPlacerDrawer)EditorWindow.GetWindow(typeof(ObjectPlacerDrawer));
        window.Show();


    }

    public void OnEnable()
    {
        // List<TestEnum> enums = System.Enum.GetValues(typeof(TestEnum)).Cast<TestEnum>().ToList<TestEnum>();
        // enumAsString = System.Enum.GetNames(typeof(TestEnum)).ToArray();

        // selectedPopupIndex = property.FindPropertyRelative("testEnum").enumValueIndex;

        prefabAsString = System.IO.Directory.GetFiles(Application.dataPath + "/Resources/Prefabs/Mobs", "*.prefab");
        // System.IO.Path.GetFileNameWithoutExtension

        foreach (string stg in prefabAsString)
        {
            prefabAsString[i] = System.IO.Path.GetFileNameWithoutExtension(stg);
            i++;
        }


        //we put initialized code here
        Debug.Log("OnEnable");


        initialized = true;
        texture = Resources.Load<Texture>("Textures/txture");

    }

    public void OnGUI()
    {
        if (!initialized)
        {
            OnEnable();
        }
        // SerializedProperty enumTest = property.FindPropertyRelative("testEnum");
        //if (Event.current.type == EventType.Repaint)
        //{
        //   EditorGUI.DrawTextureTransparent(position, texture);
        //}

        //EditorGUI.PropertyField(CreateRect.GetRect(0, 0, 10, 1, position), array4Drawer);

        //GUI.Label(RectEditor.GetRect(new Vector2(0, 0), new Vector2(10, 1), position), "Object tool");
        EditorGUILayout.LabelField("Object tool");

        //Rect elementOne = RectEditor.GetRect(new Vector2(0, 1), new Vector2(10, 1), position);

        //selectedPopupIndex = EditorGUI.Popup(elementOne, selectedPopupIndex, prefabAsString);
        selectedPopupIndex = EditorGUILayout.Popup(selectedPopupIndex, prefabAsString);

        if (Selection.activeObject != null)
        {
            buttonName = "Swap";
            //Debug.Log(prefabAsString[i]);
        }
        else
        {
            buttonName = "Create";
        }

        //bool btn = GUI.Button(RectEditor.GetRect(new Vector2(0, 2),new Vector2(10, 1), position), buttonName);
        bool btn = GUILayout.Button(buttonName);
        

        if (btn == true && buttonName == "Swap")
        {
            gO = Resources.Load<GameObject>("Prefabs/Mobs/" + prefabAsString[selectedPopupIndex]);
            GameObject.DestroyImmediate(Selection.activeObject);
            Selection.activeGameObject = GameObject.Instantiate(gO);
            //SceneView.currentDrawingSceneView.camera.transform.position = gO.transform.position;

        }
        else if (btn == true && buttonName == "Create")
        {
            gO = Resources.Load<GameObject>("Prefabs/Mobs/" + prefabAsString[selectedPopupIndex]);
            GameObject.Instantiate(gO);
            //SceneView.currentDrawingSceneView.camera.ViewportToWorldPoint(gO.transform.position);
        }

        
    }
}
