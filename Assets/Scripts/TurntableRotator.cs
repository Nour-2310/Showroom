using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurntableRotator : MonoBehaviour
{
    [Header("Rotation Speed in Degrees/Second")]
    public float rotationSpeed = 30f;

    void Update()
    {
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}

