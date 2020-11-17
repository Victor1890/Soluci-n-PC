using OculusSampleFramework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasHerramientas : MonoBehaviour
{
    private readonly DistanceGrabbable Grab;
    public GameObject canvas;
    public void HideShowCanvas()
    {
        if (Grab.isGrabbed)
        {
            canvas.SetActive(true);
        }
        else
        {
            canvas.SetActive(false);
        }
    }
}

