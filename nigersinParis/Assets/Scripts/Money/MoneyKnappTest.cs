using UnityEngine;

public class MoneyKnappTest : MonoBehaviour
{
    [SerializeField]
    private float costOfItem;

    PengarTotal pengarTotal =  new PengarTotal();

    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.tag == "Player")
        {
            pengarTotal.removeMoney(costOfItem);
        }
    }
}
