using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    [SerializeField]
    private Light _room1Light;

    [SerializeField]
    private Light _room2Light;

    private List<Light> _lights;

    private void Start()
    {
        _lights = new List<Light> { _room1Light, _room2Light };
        SetActive(_room1Light);
    }

    public void SetActive(Light light)
    {
        foreach(var l in _lights)
        {
            if (l == light)
            {
                l.gameObject.SetActive(true);
            }
            else
            {
                l.gameObject.SetActive(false);
            }
        }
    }
}
