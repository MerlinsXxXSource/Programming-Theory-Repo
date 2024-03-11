using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Derived class for a different shape
public class Cube : Shape
{
    void Start()
    {
        // Initialize properties
        ShapeName = "Cube";
    }

    // Override the DisplayText method
    public override void DisplayText()
    {
        // Update the UI Text instead of using Debug.Log
        UpdateDisplayText($"This is a {ShapeColor} {ShapeName}.");
    }
}
