using UnityEngine;
using System.Collections.Generic;

public class EnemySpawner : Spawner
{
//    [Header("Enmy")]

    private void Reset()
    {
        this.spawnPosName = "EnemySpawnPos";
        this.prefabName = "EnemyPrefab";
    }

    protected override void CheckDead() 
    {
        int removedCount = this.objects.RemoveAll(obj => obj == null); 
        if (this.objects.Count == 0 && isSpawned)
        {
            isSpawned = false; 
        }
    }
}
