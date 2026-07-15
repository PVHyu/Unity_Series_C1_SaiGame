using System;
using UnityEngine;

public class DamageReceiver : MonoBehaviour
{
    [SerializeField] private int hp = 12;

    public virtual bool IsDead()
    {
        return this.hp <= 0;
    }

    public virtual void Receiver(int damage)
    {
        this.hp -= damage;
    }

}
