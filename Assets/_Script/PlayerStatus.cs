using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    protected PlayerCtrl playerCtrl;

    protected void Awake()
    {
        this.playerCtrl = GetComponent<PlayerCtrl>();
    }

    private void Update()
    {
       
    }

    protected virtual void CheckDead()
    {
        if(this.playerCtrl.damageReceiver.IsDead()) this.Dead();
    }

    public virtual void Dead()
    {
        Debug.Log("Dead");
    }
}
