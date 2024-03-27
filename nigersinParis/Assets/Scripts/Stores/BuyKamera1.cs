using UnityEngine;
using UnityEngine.UI;

public class BuyKamera1 : MonoBehaviour
{
    public OnEntryDisable onEntryDisable;
    public void Trigger()
    {
        onEntryDisable.OwnCam1 = true;
    }

}
