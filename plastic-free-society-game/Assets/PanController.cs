using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanController : MonoBehaviour
{
    public float speed = 10f;

    private Vector2? lastMousePos;
    
    void Update()
    {
        var mousePos = (Vector2)Input.mousePosition;
        if (lastMousePos.HasValue) // We have been panning around
        {
            if (Input.GetMouseButton(0)) // We continue panning
            {
                var delta = mousePos - lastMousePos.Value;
                transform.localPosition -= new Vector3(delta.x, 0, delta.y) * speed;
                lastMousePos = mousePos;
            }
            else // We're done panning
            {
                lastMousePos = null;
            }
        }
        else // We weren't panning around
        {
            if (Input.GetMouseButton(0)) // We begin panning
            {
                lastMousePos = Input.mousePosition;
            }
            // Else we're still not panning around
        }
    }
}