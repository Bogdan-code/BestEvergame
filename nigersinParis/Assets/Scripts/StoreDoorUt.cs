using UnityEngine;
using UnityEngine.SceneManagement;

public class StoreDoorUt : MonoBehaviour
{

    GameObject Player;
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.name == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}
