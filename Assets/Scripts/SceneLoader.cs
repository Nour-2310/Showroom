using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Call this from the "Marker-less Experience" button
    public void LoadMarkerlessScene()
    {
        SceneManager.LoadScene("MarkerLessScene"); // Replace with your actual scene name
    }

    // Call this from the "Marker-based Experience" button
    public void LoadMarkerbasedScene()
    {
        SceneManager.LoadScene("MarkerBasedScene"); // Replace with your actual scene name
    }
}

