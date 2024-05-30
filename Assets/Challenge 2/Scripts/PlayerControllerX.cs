using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float cooldownTime = 1.5f;
    private float lastDogSpawnTime = -Mathf.Infinity; // Initialize last dog spawn time to negative infinity

    // Update is called once per frame
    void Update()
    {
        // Check if the cooldown time has passed and if the spacebar is pressed
        if (Time.time - lastDogSpawnTime >= cooldownTime && Input.GetKeyDown(KeyCode.Space))
        {
            SpawnDog();
        }
    }

    void SpawnDog()
    {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

        // Update the last dog spawn time to the current time
        lastDogSpawnTime = Time.time;
    }
}
