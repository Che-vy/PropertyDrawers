using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector5 {

    public delegate bool del(float i);
    public float v, w, x, y;
    public float z;
    private float o;
    public List<GameObject> goList;

    public Vector5()
    {
    }

    public Vector5(float v, float w, float x, float y, float z)
    {
        this.v = v;
        this.w = w;
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public bool Exists(System.Func<float, bool> d) {
        return d.Invoke(v) || d.Invoke(w) || d.Invoke(x) || d.Invoke(y) || d.Invoke(z);
    }

    public void Test(System.Func<float,bool> func) {


    }

    //ShallowClone() will clone primitive types
    public Vector5 ShallowClone() {
        return (Vector5)this.MemberwiseClone();
    }

    //Deep cloning usually requires recursion, uses ShallowClone() recursively
    //public Vector5 DeepClone() {
    //    Vector5 toRet = ShallowClone();
    //    toRet.goList = new List<GameObject>();
    //    foreach (GameObject go in goList) {

    //    }
    //}

    #region Operator Overloads
    public static Vector5 operator +(Vector5 b, Vector5 c) {
        return new Vector5
            (b.v + c.v, 
            b.w + c.w, 
            b.x + c.x,
            b.y + c.y,
            b.z + c.z);
    }

    public static Vector5 operator *(Vector5 b, float v)
    {
        return new Vector5
            (b.v * v,
            b.w * v,
            b.x * v,
            b.y * v,
            b.z * v);
    }

    public static bool operator ==(Vector5 b, Vector5 c)
    {
       return
            Mathf.Approximately(b.v, c.v) &&
            Mathf.Approximately(b.w, c.w) &&
            Mathf.Approximately(b.x, c.x) &&
            Mathf.Approximately(b.y, c.y) &&
            Mathf.Approximately(b.z, c.z);
    }

    public static bool operator !=(Vector5 b, Vector5 c)
    {
        return !(b == c);
    }

    public float this[int i] {
        get {
            switch (i) {
                case 0:
                    return v;
                case 1:
                    return w;
                case 2:
                    return x;
                case 3:
                    return y;
                case 4:
                    return z;
                default:
                    throw new System.IndexOutOfRangeException("Vector5 exception, max index 5 exceeded by index: " + i.ToString());
            }
        }

        set {
            switch (i)
            {
                case 0:
                    v = value;
                    break;
                case 1:
                    w = value;
                    break;
                case 2:
                    x = value;
                    break;
                case 3:
                    y = value;
                    break;
                case 4:
                    z = value;
                    break;
                default:
                    throw new System.IndexOutOfRangeException("Vector5 exception, max index 5 exceeded by index: " + i.ToString());
            }
        }
    }

    public override string ToString()
    {
        return string.Format("Vector5({0},{1},{2},{3},{4})", this.v, this.w, this.x, this.y, this.z);
    }
    #endregion
}
