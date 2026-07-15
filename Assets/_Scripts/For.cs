using UnityEngine;

public class For : MonoBehaviour
{
    void Start() 
    {
        int maxMinion = 7;
        for(int i = 0; i <= maxMinion;i++)
        {
            this.Spawn(i);
        }
    }

    void Spawn(int index)
    {
        Debug.Log("Spawn: " + index);
    }
}
