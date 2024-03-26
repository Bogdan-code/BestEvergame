using UnityEngine;
using UnityEngine.UI;

public class PengarTotal : MonoBehaviour
{
    
    public float Money;

    public Text MoneyCount;

    void Update()
    {
        MoneyCount.text = "$" + Money.ToString();
    }
}
