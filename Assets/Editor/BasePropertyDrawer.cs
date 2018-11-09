using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class BasePropertyDrawer : PropertyDrawer {

    public bool initialized = false;

    public void OnEnable(SerializedProperty sp) {



        initialized = true;
    }


    public void OnGUI() {

    }
}
