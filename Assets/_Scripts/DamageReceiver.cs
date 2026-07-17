using System;
using UnityEngine;

public class DamageReceiver : MonoBehaviour
{
    [Header("DamageReceiver")]
    [SerializeField] public int hp = 1;

    public virtual bool IsDead()
    {
        return this.hp <= 0;
    }

    public virtual void Receiver(int damage)
    {
        this.hp -= damage;
    }

}
