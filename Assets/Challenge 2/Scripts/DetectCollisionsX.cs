using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    // destroy balls when they enter range of dog
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
