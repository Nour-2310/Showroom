using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class VehiclePlacer : MonoBehaviour
{
    public ARRaycastManager raycastManager;
    public GameObject carPrefab;

    private GameObject placedCar;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                List<ARRaycastHit> hits = new List<ARRaycastHit>();
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
}
