using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Base class for all shapes
public abstract class Shape : MonoBehaviour
{
    // Reference to the UI Text component
    public TextMeshProUGUI displayTextUI;

    // Encapsulated properties
    private string shapeName;
    private Color shapeColor;

    // Properties with getters and setters
    public string ShapeName
    {
        get { return shapeName; }
        set { shapeName = value; }
    }

    public Color ShapeColor
    {
        get { return GetComponent<Renderer>().material.color; } // Get the actual color of the material
        set { shapeColor = value; }
    }

    // Abstract method to be overridden by derived classes
    public abstract void DisplayText();

    // Common OnMouseDown method for all shapes
    void OnMouseDown()
    {
        DisplayText();
    }

    // Method to update the UI Text component
    protected void UpdateDisplayText(string message)
    {
        if (displayTextUI != null)
        {
            displayTextUI.text = message;
        }
        else
        {
            Debug.LogWarning("Display Text UI component not set.");
        }
    }
}

