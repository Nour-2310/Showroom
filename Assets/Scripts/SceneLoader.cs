using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;
using UnityEngine.SceneManagement; // ← THIS LINE IS MISSING

public class SceneLoader : MonoBehaviour
{
    public void LoadMarkerless()
    {
        SceneManager.LoadScene("MarkerLessScene");
    }

    public void LoadMarkerbased()
    {
        SceneManager.LoadScene("MarkerBasedScene");
    }
}
