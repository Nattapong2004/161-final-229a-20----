using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    protected string shapeName;

    public void Init(string newName)
    {
        shapeName = newName;
    }

    public abstract float CalculateArea();

    public virtual void Resize()
    {
        Debug.Log($"Resizing {shapeName}");
    }

    public void Draw()
    {
        Debug.Log($"Drawing {shapeName}");
    }
}
