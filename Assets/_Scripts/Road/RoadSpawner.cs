using UnityEngine;

public class RoadSpawner : MonoBehaviour
{
    protected GameObject roadPrefab;
    protected GameObject roadSpawnPos;
    protected float distance = 0;
    protected GameObject roadCurrent;
    protected int roadPlayerOrder = 0;

    private void Awake()
    {
        this.roadPrefab = GameObject.Find("RoadPrefab");
        this.roadSpawnPos = GameObject.Find("RoadSpawnPos");

        this.roadCurrent = this.roadPrefab;
        this.roadPlayerOrder = (int) this.roadPrefab.transform.position.z;
    } 

    private void FixedUpdate()
    {
        this.UpdateRoad();
    }

    protected virtual void UpdateRoad()
    {
        this.distance = Vector2.Distance(PlayerCtrl.instance.transform.position, this.roadCurrent.transform.position);
        if(this.distance > 5) this.Spawn();
    }

    protected virtual void Spawn()
    {
        Vector3 pos = this.roadSpawnPos.transform.position;
        pos.x = 0;
        pos.z = this.roadPlayerOrder;

        this.roadCurrent = Instantiate(this.roadPrefab, pos, this.roadPrefab.transform.rotation);
    }
}
