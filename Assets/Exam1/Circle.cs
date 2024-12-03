using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : Shape
{
    private void Start()
    {
        Init("Circle");
        raidus = 2f;
        Draw();
        Resize();
        
    }

    float raidus;

    public override float CalculateArea()
    {
        Debug.Log($"{shapeName} raiduis: {raidus}");

        raidus = 2f * raidus * raidus;
        Debug.Log($"Circlearea: {raidus}");
        return raidus;
    }

    public override void Resize()
    {
        base.Resize();

        Debug.Log($" Resizing {shapeName} is {shapeName} class");

    }
}
