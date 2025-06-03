using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteraction : MonoBehaviour
{
    public Animator doorAnimator;
    private bool isOpen = false;

    public void ToggleDoor()
    {
        if (doorAnimator != null)
        {
            isOpen = !isOpen;
            doorAnimator.SetBool("isOpen", isOpen);
        }
    }
}

