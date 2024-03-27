using UnityEngine;
using UnityEngine.SceneManagement;

public class StoreDoorUt : MonoBehaviour
{

    public Animator animator;

    private int levelToLoad;

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            FadeToLevel(1);
        }
    }

    public void FadeToNextLevel()
    {
        FadeToLevel(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void FadeToLevel(int levelIndex)
    {
        levelToLoad = levelIndex;
        animator.SetTrigger("Fade Out");
    }

    public void OnFadecomplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }


}
