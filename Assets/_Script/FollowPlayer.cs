using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform player;
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
        if(distance.magnitude >= 3)
        {
            Vector3 targetPoint = this.player.position - distance.normalized * 3;
            gameObject.transform.position = Vector3.MoveTowards(this.transform.position, targetPoint, 5 * Time.deltaTime);
        }
    }
}