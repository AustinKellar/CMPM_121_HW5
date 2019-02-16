﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrounded : MonoBehaviour
{
    [SerializeField]
    private float _raycastDistance;

    private RaycastHit _hit;

    public bool IsGrounded { get; private set; }

    private void Update()
    {
        IsGrounded = Physics.Raycast(transform.position, Vector3.down, out _hit, _raycastDistance, LayerMask.GetMask("Default"));
    }
}
