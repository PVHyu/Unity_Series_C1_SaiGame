using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Spawner")]
    public GameObject objPrefab;

    public GameObject spawnPos;
    public List<GameObject> objects = new();
    public float spawnTimer = 0f;
    public float spawnDelay = 1f;
    public int maxObj = 1;
    public bool isSpawned = false;
    public string spawnPosName = "";
    public string prefabName = "";

    private void Awake()
    {
        this.objects = new List<GameObject>();
        this.spawnPos = GameObject.Find(this.spawnPosName);
        this.objPrefab = GameObject.Find(this.prefabName);
        this.objPrefab.SetActive(false);
    }

    private void Update()
    {
        this.Spawn();
        this.CheckDead();
    }

    protected virtual void Spawn()
    {
         if(this.objects.Count >= this.maxObj) return;
        this.spawnTimer += Time.deltaTime;
        if(this.spawnTimer < this.spawnDelay) return;
        this.spawnTimer = 0;

        GameObject enemy = Instantiate(this.objPrefab);
        enemy.transform.position = this.spawnPos.transform.position;
        enemy.transform.parent = transform;
        enemy.SetActive(true);

        this.objects.Add(enemy);

        isSpawned = true; 
    }
    
    protected virtual void CheckDead() 
    {
        int removedCount = this.objects.RemoveAll(bomb => bomb == null); 
        if (this.objects.Count == 0 && isSpawned)
        {
            isSpawned = false; 
        }
    }
}