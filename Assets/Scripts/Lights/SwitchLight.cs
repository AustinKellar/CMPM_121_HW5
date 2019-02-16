using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLight : MonoBehaviour
{
    [SerializeField]
    private LightController _controller;

    [SerializeField]
    private Light _light;

    private void OnTriggerEnter(Collider other)
    {
        _controller.SetActive(_light);
    }
}
