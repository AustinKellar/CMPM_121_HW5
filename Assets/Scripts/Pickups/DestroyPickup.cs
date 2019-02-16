using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPickup : MonoBehaviour
{
    private ParticleSystem _particleSystem;
    private MeshRenderer _renderer;
    private DoorController _doorController;

    private void Awake()
    {
        _particleSystem = GetComponent<ParticleSystem>();
        _renderer = GetComponent<MeshRenderer>();
        _doorController = FindObjectOfType<DoorController>();
        _particleSystem.Stop();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _particleSystem.Play();
            _renderer.enabled = false;
            Invoke("DestroyGameObject", 0.5f);
        }
    }

    private void DestroyGameObject()
    {
        _doorController.PickupsCollected++;
        Destroy(gameObject);
    }
}
