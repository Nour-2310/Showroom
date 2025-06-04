using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ColorChanging : MonoBehaviour
{
    [Header("Car Body Mesh Renderers")]
    [SerializeField] private MeshRenderer[] targetRenderers;

    private Material[] carMaterials;

    private void Awake()
    {
        // Create unique material instances to avoid changing shared materials
        carMaterials = new Material[targetRenderers.Length];

        for (int i = 0; i < targetRenderers.Length; i++)
        {
            if (targetRenderers[i] != null)
            {
                carMaterials[i] = targetRenderers[i].material;
            }
        }
    }

    
    /// <param name="color">The color to apply</param>
    public void ApplyColor(Color color)
    {
        foreach (var mat in carMaterials)
        {
            if (mat != null)
            {
                mat.SetColor("_BaseColor", color); // Use "_Color" if using Standard Shader
            }
        }
    }

    public void OnColorPickerChanged(Color selectedColor)
    {
        ApplyColor(selectedColor);
    }

    
    public void ApplyRandomColor()
    {
        Color randomColor = Random.ColorHSV(0f, 1f, 0.4f, 1f, 0.5f, 1f);
        ApplyColor(randomColor);
    }
}

