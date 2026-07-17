using Unity.VisualScripting;
using UnityEngine;

public class BombDamageReceiver : DamageReceiver
{
    //[Header("Enemy")]
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        EnemyDamageReceiver enemy = collision.GetComponent<EnemyDamageReceiver>();
        if (enemy == null) return;
        this.Receiver(1);
    }
    
    public override void Receiver(int damage)
    {
        Debug.Log("Bomb!!!");
        base.Receiver(damage);
        if(this.IsDead()) 
        {
            Destroy(gameObject);
            EffectManager.GetInstance().SpawnVFX("Explosion_A", transform.position, transform.rotation);
        }
    }
}