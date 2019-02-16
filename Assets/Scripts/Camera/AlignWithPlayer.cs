using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlignWithPlayer : MonoBehaviour
{
    [SerializeField]
    private GameObject _player;

    private void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, _player.transform.position.z);
    }
}
