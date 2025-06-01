using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using System.Collections.Generic;

public class ImageTrackedSpawner : MonoBehaviour
{
    public GameObject carAPrefab;
    public GameObject carBPrefab;
    public ARTrackedImageManager manager;

    void OnEnable() => manager.trackedImagesChanged += OnImageChanged;
    void OnDisable() => manager.trackedImagesChanged -= OnImageChanged;

    void OnImageChanged(ARTrackedImagesChangedEventArgs args)
    {
        foreach (var img in args.added)
        {
            GameObject obj = null;
            if (img.referenceImage.name == "CarA") obj = carAPrefab;
            else if (img.referenceImage.name == "CarB") obj = carBPrefab;

            if (obj != null)
                Instantiate(obj, img.transform.position, img.transform.rotation);
        }
    }
}
