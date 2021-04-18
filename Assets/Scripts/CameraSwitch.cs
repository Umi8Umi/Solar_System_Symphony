using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera playerCamera;
    public Camera overviewCamera;

    public void Start()
    {
        playerCamera.enabled = false;
        overviewCamera.enabled = true;
    }
    public void Switch()
    {
        playerCamera.enabled = !playerCamera.enabled;
        overviewCamera.enabled = !overviewCamera.enabled;
    }
}
