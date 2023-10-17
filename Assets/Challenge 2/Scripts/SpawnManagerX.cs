using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs; // Array of balls to spawn

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    public float spawnInterval = 1.0f; // delay before balls start spawning

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnRandomBall", spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random spawn position within bounds
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate random ball at random spawn location
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);

        // randomise time until next ball spawns
        spawnInterval = Random.Range(3, 5);
        // recursive method using newly generated spawn interval
        Invoke("SpawnRandomBall", spawnInterval);
    }
}
