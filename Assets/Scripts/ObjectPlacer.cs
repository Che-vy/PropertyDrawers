using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EditorProperty { A, B, C }


[System.Serializable]
public class ObjectPlacer {
    public EditorProperty testProp = EditorProperty.C;

    public List<string> GOList;
}
