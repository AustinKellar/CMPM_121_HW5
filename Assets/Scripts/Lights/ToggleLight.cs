using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLight : MonoBehaviour
{
    private bool _isOn = true;
    private Light _light;

    private void Awake()
    {
        _light = GetComponent<Light>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            _isOn = !_isOn;
            _light.enabled = _isOn;
        }
    }
}
