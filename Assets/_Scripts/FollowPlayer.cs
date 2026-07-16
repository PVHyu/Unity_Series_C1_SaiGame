using Unity.Collections;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] protected float speed = 20f;
    protected float disLimit = 3f;
    public float randPos = 0;

    private void Awake()
    {
        this.FindPlayer();
        this.randPos = Random.Range(-6, 6);
    }

    private void FixedUpdate()
    {
        if (this.player == null)
        {
            return;
        }

        Follow();
    }

    private void FindPlayer()
    {
        if (PlayerCtrl.instance != null)
        {
            this.player = PlayerCtrl.instance.transform;
        }
        else
        {
            this.player = GameObject.FindWithTag("Player")?.transform;
        }
    }

    void Follow()
    {
        Vector3 pos = this.player.position;
        pos.x = this.randPos;
        

        Vector3 distance = pos - this.transform.position;
        if(distance.magnitude >= this.disLimit)
        {
            Vector3 targetPoint = pos - distance.normalized * this.disLimit;
            transform.position = Vector3.MoveTowards(transform.position, targetPoint, this.speed * Time.fixedDeltaTime);
        }
    }
}