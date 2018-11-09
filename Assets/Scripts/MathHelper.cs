using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathHelper {

    public static Vector2 RadianToVector2(float radian)
    {
        return new Vector2(Mathf.Cos(radian), Mathf.Sin(radian));
    }

    public static Vector2 DegreeToVector2(float degree)
    {
        return RadianToVector2(degree * Mathf.Deg2Rad);
    }

    public static float DegreeToRadian(float degree) {

        return (degree * Mathf.PI) / 180;
    }

    public static float RadianToDegree(float radian)
    {
        return (radian * 180) / Mathf.PI;
    }

    public static int Factorial(int i)
    {
        if (i <= 1)
            return 1;
        return Factorial(i - 1) * i;
    }
}
