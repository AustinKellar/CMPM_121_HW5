using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    [SerializeField]
    private GameObject _player;

    private void FixedUpdate()
    {
        transform.LookAt(_player.transform);
    }
}
