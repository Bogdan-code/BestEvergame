using UnityEngine;
using UnityEngine.UI;

public class UITrigger : MonoBehaviour
{
    public Collider2D Player;
    public Collider2D Skrivbord;
    public GameObject Kamera1;
    
    void GetLocator()
    {
        if (Player.IsTouching(Skrivbord))
        {
            Kamera1.gameObject.SetActive(true);
        }
        else
        {
            Kamera1.gameObject.SetActive(false);
        }
    }
}
