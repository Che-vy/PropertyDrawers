using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public enum TestEnum { ARA, JAJ, POP };


[System.Serializable]
public class SampleClass : MonoBehaviour {

    public ObjectPlacer objectPlacer;

    public void Start() {

        #region Extension Methods 1
        float and = 45;
        Vector2 resultVector2 = and.AngToV2();

        int j = 5;
        j.Factorial();

        int[] jArr = new int[] { 2, 5, 6};

        string s = jArr.ArrToString();
        //Debug.Log(s);

        TestEnum te = TestEnum.ARA;
        //TestEnum[] ss = ExtensionMethods.GetArrOfEnums<TestEnum>();
        TestEnum[] ss = te.GetArrOfEnums();

        foreach (TestEnum t in ss) {
            //Debug.Log(t);
        }
        #endregion

        #region Extension Methods 2
        Vector5[] arrTest = new Vector5[] { new Vector5(5, 6, 7, 8, 9), new Vector5(111, 222, 333, 444, 555) };
        Vector5 v5Placeholder = new Vector5(111, 222, 333, 444, 555);

        int[] arr2d2 = new int[] {1, 2, 3, 4, 5}; //INLINE CONSTRUCTOR

        Debug.Log("Complies: " + arr2d2.Complies((int i ) => { return i > 3; }));
        //arrTest.Complies(v5Placeholder.Exists(), v5Placeholder);
        #endregion


        #region LINQ expressions
        int[] arr = new int[] {1, 2, 3, 4, 5}; //INLINE CONSTRUCTOR

        Vector5 v5 = new Vector5() { x = 5, z = 10 };

        Vector5.del d = (float i) => { return i > 3; };
        // Debug.Log("exists in v5: " + v5.Exists(d));

        Debug.Log("is at least one even in v5: " + v5.Exists((float i) => { return i % 2 == 0; }));

        //Debug.Log("arr.Count: " + arr.Count((i) => { return i > 3; }));

        arr = arr.Where((i) => { return i > 3; }).ToArray();

        foreach (int i in arr) {
           // Debug.Log(i.ToString());
        }

        #endregion

        #region V5 stuff
        //Vector5 a5 = new Vector5(0, 1, 2, 3, 4), b5 = new Vector5(0, 11, 22, 33, 44);
        //Vector5 c5 = a5 + b5;
        //Vector5 d5 = new Vector5(0, 1, 2, 3, 4);

        //Vector3 v3 = new Vector3(1, 2, 3);
        //Vector5 clonedA5 = a5.ShallowClone();

        //float x = v3[2];

        //Debug.Log(clonedA5.ToString());
        #endregion
    }

}
