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

    public virtual void Dead()
    {
        Debug.Log("Dead");
    }
}
