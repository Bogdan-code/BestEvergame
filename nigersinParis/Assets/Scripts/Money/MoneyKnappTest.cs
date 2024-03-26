using UnityEngine;

public class MoneyKnappTest : MonoBehaviour
{

    
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "Player")
        {
            
        }
    }
}
