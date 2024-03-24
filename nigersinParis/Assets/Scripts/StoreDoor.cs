using UnityEngine;
using UnityEngine.SceneManagement;

public class StoreDoor : MonoBehaviour
{
    private void OnTriggerEnter()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
