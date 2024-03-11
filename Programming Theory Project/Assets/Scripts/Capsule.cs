using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Derived class for another shape
public class Capsule : Shape
{
    void Start()
    {
        // Initialize properties
        ShapeName = "Capsule";
    }

    public override void DisplayText()
    {
        // Update the UI Text instead of using Debug.Log
        UpdateDisplayText($"This is a {ShapeColor} {ShapeName}.");
    }

}
