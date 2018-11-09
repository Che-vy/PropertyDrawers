using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public enum WidthType { ConstWidth, PercWidth }

public class RectEditor {

    public static float maxWidth = 15, maxHeight = 15;

    public static Rect GetRect(Vector2 position, Vector2 size, Rect offset) {

        Vector2 finalPos = new Vector2(offset.x + (position.x * (maxWidth * size.x)), offset.y + (position.y * (maxHeight * size.y)));
        size.x *= maxWidth;
        size.y *= maxHeight;

        return new Rect(finalPos, size);
    }

    public static Rect GetRect(float x, float y, float width, float height, Rect offset, WidthType type)
    {

        Vector2 finalPos = new Vector2(offset.x + (x * (maxWidth * width)), offset.y + (y * (maxHeight * height)));
        x *= maxWidth;
        y *= maxHeight;

        return new Rect(finalPos, new Vector2(width, height));
    }
}
