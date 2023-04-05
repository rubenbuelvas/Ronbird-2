using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleGenerator : MonoBehaviour
{

    public GameObject bottleObstacle;
    public float spawnInterval = 10f;
    public float spawnHeight = 1f;
    public float obstacleVelocity = -100f;
    private float timeSinceLastSpawn = 0f;

    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;
        if (timeSinceLastSpawn >= spawnInterval)
        {
            timeSinceLastSpawn = 0f;
            SpawnBottleObstacle();
        }
    }

    void SpawnBottleObstacle()
    {
        Vector2 spawnPosition = transform.position;
        GameObject spawned = Instantiate(bottleObstacle, spawnPosition, Quaternion.identity);
        spawned.GetComponent<Rigidbody2D>().velocity = new Vector2(obstacleVelocity, 0f);
    }
}
