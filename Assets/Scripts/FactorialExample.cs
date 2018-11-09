using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactorialExample : MonoBehaviour {

    public int startingValue = 4, result = 1;

    public int FactorialFunction_NonRecursive(int value) {

        int result = 1;
        for (int i = value; i > 0; i--)
            result *= i;
        return result;
    }

    public void Start() {
        FactorialFunction_Recursive(ref startingValue, ref result);

    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="value">the starting value to factorize</param>
    /// <param name="result">set to 1 when calling</param>
    public static void FactorialFunction_Recursive(ref int value, ref int result) {
        result *= value;
        value--;

        if (value > 0)
            FactorialFunction_Recursive(ref value, ref result);

        else
            Debug.Log("result = " + result);
    }



}
