using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.AR;


public class ARSelectionCanvasToggle : MonoBehaviour
{
    [Header("References")]
    public GameObject targetCanvas;  // The UI canvas to show/hide
    private ARSelectionInteractable selectionInteractable;

    void Awake()
    {
        selectionInteractable = GetComponent<ARSelectionInteractable>();

        if (selectionInteractable == null)
        {
            Debug.LogError("ARSelectionInteractable not found on " + gameObject.name);
        }

        if (targetCanvas != null)
        {
            targetCanvas.SetActive(false); // hide at start
        }
    }

    void OnEnable()
    {
        if (selectionInteractable != null)
        {
            selectionInteractable.selectEntered.AddListener(OnSelected);
            selectionInteractable.selectExited.AddListener(OnDeselected);
        }
    }

    void OnDisable()
    {
        if (selectionInteractable != null)
        {
            selectionInteractable.selectEntered.RemoveListener(OnSelected);
            selectionInteractable.selectExited.RemoveListener(OnDeselected);
        }
    }

    void OnSelected(SelectEnterEventArgs args)
    {
        if (targetCanvas != null)
        {
            targetCanvas.SetActive(true);
        }
    }

    void OnDeselected(SelectExitEventArgs args)
    {
        if (targetCanvas != null)
        {
            targetCanvas.SetActive(false);
        }
    }
}

