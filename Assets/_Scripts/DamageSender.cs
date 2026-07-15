using UnityEngine;

public class DamageSender : MonoBehaviour
{
    protected EnemyCtrl enemyCtrl;

    private void Awake()
    {
        this.enemyCtrl = GetComponent<EnemyCtrl>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!collision.CompareTag("Player")) return; 

        DamageReceiver damageReceiver = collision.GetComponent<PlayerDamageReceiver>();    
        damageReceiver.Receiver(1); // Assuming 1 is the damage amount

        this.enemyCtrl.despawner.Despawn();
    }
}
