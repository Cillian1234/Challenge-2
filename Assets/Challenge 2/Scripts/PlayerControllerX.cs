﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private bool spawnDisabled = false;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && spawnDisabled == false)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            // disables spawning of dogs and re-enables it after 1 second
            Invoke("DisableSpawn", 0);
            Invoke("EnableSpawn", 1);
        }
    }

    void DisableSpawn() {
        spawnDisabled = true;
    }
    void EnableSpawn() {
        spawnDisabled = false;
    }
}
