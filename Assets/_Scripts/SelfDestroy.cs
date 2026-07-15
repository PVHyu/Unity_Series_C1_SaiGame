using UnityEngine;

public class SelfDestroy : MonoBehaviour
{
    void Start() 
    {
        Invoke("Destroy", 3f);
    }
    
    void Destroy()
    {
        Destroy(this.gameObject);
    }
}