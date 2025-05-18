using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class InfinitePlatformSpawner : PlatformSpawner
{
    private Transform playerTransform;
    private List<GameObject> spawnedPlatforms = new();

    private void Start()
    {
        playerTransform = FindObjectOfType<PlayerMover>().transform;
        GeneratePlatforms();
        Debug.Log("Spawned platforms: " + spawnedPlatforms.Count);
    }

    protected override void SpawnPlatform(Platform spawnPlatform)
    {
        GameObject newPlatform = Instantiate(spawnPlatform,
            transform.forward * spawnCoordinate,
            transform.rotation).gameObject;
        spawnedPlatforms.Add(newPlatform);
        spawnCoordinate += platformLength;
    }

    private void RemovePlatform()
    {
        GameObject lost = spawnedPlatforms[0];
        spawnedPlatforms.RemoveAt(0);
        Destroy(lost);
    }

    private void Update()
    {
        if (playerTransform.position.z > spawnCoordinate - 
            (maxPlatfromCount * platformLength))
        {
            SpawnPlatform(GetRandomPlatform());
            RemovePlatform();
        }
    }

}
