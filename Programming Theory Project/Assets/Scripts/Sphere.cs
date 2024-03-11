using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Derived class for a specific shape
public class Sphere : Shape
{
    void Start()
    {
        // Initialize properties
        ShapeName = "Sphere";
    }

    // Override the DisplayText method
    public override void DisplayText()
    {
        // Update the UI Text instead of using Debug.Log
        UpdateDisplayText($"This is a {ShapeColor} {ShapeName}.");
    }
}
