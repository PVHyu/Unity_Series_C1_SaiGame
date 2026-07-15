using UnityEngine;

public class If : MonoBehaviour
{
    void Start() 
    {
        int playerLocation = 20;
        int spawnLocation = 10;
        if(playerLocation == spawnLocation) this.Spawn();
        else this.NotSpawn();
    }

    void Spawn()
    {
        Debug.Log("Player has spawned at the spawn location.");
    }

    void NotSpawn()
    {
        Debug.Log("Player has not spawned at the spawn location.");
    }
}
