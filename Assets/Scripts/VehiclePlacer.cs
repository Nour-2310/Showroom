using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class VehiclePlacer : MonoBehaviour
{
    [Header("AR Setup")]
    public ARRaycastManager raycastManager;

    [Header("Vehicle")]
    public GameObject carPrefab;

    private GameObject placedCar;
    private static List<ARRaycastHit> hits = new List<ARRaycastHit>();

    void Update()
    {
        // Only respond to one-finger touch
        if (Input.touchCount == 0 || raycastManager == null || carPrefab == null)
            return;

        Touch touch = Input.GetTouch(0);

        // Only respond when touch begins
        if (touch.phase == TouchPhase.Began)
        {
            if (raycastManager.Raycast(touch.position, hits, TrackableType.PlaneWithinPolygon))
            {
                Pose hitPose = hits[0].pose;

                if (placedCar == null)
                {
                    placedCar = Instantiate(carPrefab, hitPose.position, hitPose.rotation);
                }
                else
                {
                    placedCar.transform.position = hitPose.position;
                }
            }
        }
    }
}
