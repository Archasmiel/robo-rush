using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelPlatformSpawner : PlatformSpawner
{
    [SerializeField] private Platform finalPlatform;

    protected override void GeneratePlatforms()
    {
        base.GeneratePlatforms();
        SpawnPlatform(finalPlatform);
    }

    private void Start()
    {
        GeneratePlatforms();
    }

}
