using UnityEngine;
using UnityEngine.UI;

public class UITrigger : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D OpenUI)
    {
        if (OpenUI.collider.name == "Player")
        {
            
        }
    }
}
