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
        this.roadPrefab.SetActive(false);

        this.roadPlayerOrder = (int) this.roadPrefab.transform.position.z;
        this.Spawn(this.roadPrefab.transform.position);
    } 

    private void FixedUpdate()
    {
        this.UpdateRoad();
    }

    protected virtual void UpdateRoad()
    {
        if (this.roadCurrent == null) return;

        this.distance = Vector2.Distance(PlayerCtrl.instance.transform.position, this.roadCurrent.transform.position);
        if (this.distance > 5f && PlayerCtrl.instance.transform.position.y - this.roadCurrent.transform.position.y > 5f) this.Spawn();
    }

    protected virtual void Spawn()
    {
        Vector3 pos = this.roadSpawnPos.transform.position;
        pos.x = 0;
        pos.z = this.roadPlayerOrder;

        this.Spawn(pos);
    }

    protected virtual void Spawn(Vector3 position)
    {
        this.roadCurrent = Instantiate(this.roadPrefab, position, this.roadPrefab.transform.rotation);
        this.roadCurrent.transform.parent = transform;
        this.roadCurrent.SetActive(true);
    }
}
