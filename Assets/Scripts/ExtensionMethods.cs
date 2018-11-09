using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public delegate void ComplianceDel();


public static class ExtensionMethods
{
    public static int Factorial(this int i)
    {
        return MathHelper.Factorial(i);
    }

    public static Vector2 AngToV2(this float v)
    {
        return MathHelper.DegreeToVector2(v);
    }

    public static string ArrToString<T>(this T[] arr)
    {
        string toRet = "[";
        for (int i = 0; i < arr.Length; ++i)
        {
            toRet += arr[i].ToString();
            if (i != arr.Length - 1)
                toRet += ",";
        }
        return toRet + "]";
    }

    public static Wrapper<T> Wrap<T>(this T toWrap) where T : struct
    {
        return new Wrapper<T>() { value = toWrap };
    }

    public static T[] GetArrOfEnums<T>(this T toArr) where T : struct, System.IConvertible
    {
        return System.Enum.GetValues(typeof(T)).Cast<T>().ToArray<T>();
    }

    #region ExtensionMethods Homework

    public static void IgnoreColiTimed(this Collider2D thisCollider, Collider2D other, bool ignore)
    {
        IgnoreColiHelper.Instance.AddIgnore(thisCollider, other, ignore);
    }

    public static void MoveForward(this Transform t, float speed, float dt)
    {
        Rigidbody rb = t.GetComponent<Rigidbody>();
        rb.velocity = t.forward * speed;
    }

    public static float V2toAngle(this Vector2 v)
    {
        return MathHelper.RadianToDegree(Mathf.Asin(v.normalized.y / v.magnitude));
    }

    public static bool Complies<T>(this T[] arr, System.Func<T, bool> func)
    {

        foreach (T element in arr)
        {
            if(!func.Invoke(element))
               return false;
        }
        return true;
    }
    #endregion
}
