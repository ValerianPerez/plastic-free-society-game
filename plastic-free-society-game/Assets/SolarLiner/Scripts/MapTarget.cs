using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class MapTarget : MonoBehaviour
{
    public GameObject targetCamera;

    public void Activate()
    {
        targetCamera.GetComponent<CinemachineVirtualCamera>().Follow = GetComponent<Transform>();
        targetCamera.SetActive(true);
    }

    public void Deactivate()
    {
        targetCamera.SetActive(false);
        targetCamera.GetComponent<CinemachineVirtualCamera>().Follow = null;
    }

    private void OnMouseUpAsButton()
    {
        Activate();
    }
}
