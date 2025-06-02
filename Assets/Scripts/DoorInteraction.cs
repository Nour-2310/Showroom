using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteraction : MonoBehaviour
{
    public Animator doorAnimator;
    private bool isOpen = false;

    void OnMouseDown()
    {
        if (doorAnimator != null)
        {
            isOpen = !isOpen;
            doorAnimator.SetBool("Open", isOpen);
        }
    }
}

