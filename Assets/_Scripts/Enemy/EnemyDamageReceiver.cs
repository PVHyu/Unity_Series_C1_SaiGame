using Unity.VisualScripting;
using UnityEngine;

public class EnemyDamageReceiver : DamageReceiver
{
    [Header("Enemy")]
    protected EnemyCtrl enemyCtrl;

    private void Awake()
    {
        this.enemyCtrl = GetComponent<EnemyCtrl>();
    }

    private void Reset()
    {
        this.hp = 3;
    }

    public override void Receiver(int damage)
    {
        Debug.Log("Receive bomb");
        base.Receiver(damage);
        if(this.IsDead()) 
        {
            EffectManager.GetInstance().SpawnVFX("Explosion_B", transform.position, transform.rotation);
            this.enemyCtrl.despawner.Despawn();
        }
    }
}