using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform player;
    protected float speed = 5f;
    protected float disLimit = 0.5f;
    void Start()
    {
        
    }

    void Update()
    {
        Follow();
    }

    void Follow()
    {
        Vector3 distance = this.player.position - this.transform.position;
        if(distance.magnitude >= this.disLimit)
        {
            Vector3 targetPoint = this.player.position - distance.normalized * this.disLimit;
            gameObject.transform.position = Vector3.MoveTowards(this.transform.position, targetPoint, this.speed * Time.deltaTime);
        }
    }
}