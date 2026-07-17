using UnityEngine;

public class DamageSender : MonoBehaviour
{
    [Header("DamageSender")]
    public int damage = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.ColliderSendDamage(collision);
    }

    protected virtual void ColliderSendDamage(Collider2D collision)
    {
        if(!collision.CompareTag("Player")) return; 

        DamageReceiver damageReceiver = collision.GetComponent<PlayerDamageReceiver>();    
        damageReceiver.Receiver(this.damage); // Assuming 1 is the damage amount
    }
}
