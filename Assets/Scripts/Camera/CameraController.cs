using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private IEnumerable<Camera> cameras;

    private void Start()
    {
        cameras = Camera.allCameras;
        SetActive("Camera 1");
    }

    public void SetActive(string cameraName)
    {
        foreach(Camera camera in cameras)
        {
            if (camera.gameObject.name == cameraName)
            {
                camera.enabled = true;
            }
            else
            {
                camera.enabled = false;
            }
        }
    }
}
