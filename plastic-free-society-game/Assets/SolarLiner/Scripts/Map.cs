using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class Map : MonoBehaviour
{
    public GameObject targetCamera;

    private void OnMouseUpAsButton()
    {
        targetCamera.GetComponent<CinemachineVirtualCamera>()
            ?.Follow?.gameObject.GetComponent<MapTarget>()
            ?.Deactivate();
    }
}
