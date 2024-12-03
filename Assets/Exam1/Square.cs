using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape
{
    private void Start()
    {
        Init("Square");
        side = 2;
        Draw();
        Resize();
        CalculateArea();
    }

    int side;

    public override float CalculateArea()
    {
        Debug.Log($"{shapeName} side: {side}");
        side = side * side;
        Debug.Log($"Squarear: {side}");
        return side;


    }

    public override void Resize()
    {
        base.Resize();

        Debug.Log($"{shapeName} is reiszed");
    }
}
