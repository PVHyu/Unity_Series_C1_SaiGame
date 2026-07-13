using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    [SerializeField] private List<GameObject> bombs = new();  
    [SerializeField] private GameObject bombPrefab;
    [SerializeField] private bool isSpawned = false;
    protected float spawnTimer = 0f;
    protected float spawnDelay = 1f;

    private void Start()
    {
        
    }

    void Update()
    {
        this.Spawn();

        CheckMinionDead();
    }

    void Spawn()
    {
        this.spawnTimer += Time.deltaTime;
        if(this.spawnTimer <this.spawnDelay) return; 
        this.spawnTimer = 0f;

        int randomCount = Random.Range(3, 10);

        for (int index = 0; index <= randomCount && bombs.Count < 10; index++)
        {
            GameObject bomb = Instantiate(this.bombPrefab);
            bomb.name = "BombPrefab #" + index;
            bomb.transform.position = this.transform.position;
            bomb.gameObject.SetActive(true);

            this.bombs.Add(bomb);
        }
        
        isSpawned = true; 
        Debug.Log("Player has spawned at the spawn location.");
    }

    void CheckMinionDead() 
    {
        int removedCount = this.bombs.RemoveAll(bomb => bomb == null); 
        if (this.bombs.Count == 0 && isSpawned)
        {
            isSpawned = false; 
        }
    }

}
