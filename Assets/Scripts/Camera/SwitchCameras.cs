using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCameras : MonoBehaviour
{
    [SerializeField]
    private CameraController _controller;

    [SerializeField]
    private Camera _camera;

    private void OnTriggerEnter(Collider other)
    {
        _controller.SetActive(_camera.name);
    }
}
