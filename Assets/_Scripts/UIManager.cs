using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject bnGameOver;
    static private UIManager instance;

    private void Awake()
    {
        UIManager.instance = this;
        this.bnGameOver = GameObject.Find("bnGameOver");
        this.bnGameOver.SetActive(false);
    }

    public static UIManager GetInstance()
    {
        return instance;
    }
}
