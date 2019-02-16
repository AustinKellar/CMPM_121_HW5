using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorController : MonoBehaviour
{
    [SerializeField]
    Animation _doorOne;

    [SerializeField]
    Animation _doorTwo;

    private bool _doorOneOpen = false;
    private bool _doorTwoOpen = false;

    private void Awake()
    {
        _doorOne.Stop();
        _doorTwo.Stop();
    }

    public int PickupsCollected { get; set; }

    private void Update()
    {
        if (PickupsCollected == 1 && !_doorOneOpen)
        {
            _doorOne.Play();
            _doorOneOpen = true;
            Invoke("DestroyDoorOne", 1f);
        }
        else if (PickupsCollected == 2 && !_doorTwoOpen)
        {
            _doorTwo.Play();
            _doorTwoOpen = true;
            Invoke("DestroyDoorTwo", 1f);
        }
        else if (PickupsCollected == 3)
        {
            SceneManager.LoadScene("Super Awesome Screen");
        }
    }

    private void DestroyDoorOne()
    {
        Destroy(_doorOne.gameObject);
    }

    private void DestroyDoorTwo()
    {
        Destroy(_doorTwo.gameObject);
    }
}
