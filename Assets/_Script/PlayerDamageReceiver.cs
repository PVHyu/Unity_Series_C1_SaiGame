using UnityEngine;

public class PlayerDamageReceiver : DamageReceiver
{
    protected PlayerCtrl playerCtrl;

    private void Awake()
    {
        this.playerCtrl = GetComponent<PlayerCtrl>();
    }

    public override void Receiver(int damage)
    {
        base.Receiver(damage);
        if(this.IsDead()) this.playerCtrl.playerStatus.Dead();
    }
}
