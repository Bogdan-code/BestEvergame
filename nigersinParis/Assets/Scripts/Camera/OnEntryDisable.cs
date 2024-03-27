using UnityEngine;

public class OnEntryDisable : MonoBehaviour
{
    public GameObject Kamera1;
    public GameObject Kamera1Synf�lt;
    static public bool OwnCam1 = false;

    void Update ()
    {
        if (OwnCam1 == false)
        {
            Kamera1.gameObject.SetActive(false);
            Kamera1Synf�lt.gameObject.SetActive(false);
        }
        else
        {
            Kamera1.gameObject.SetActive(true);
            Kamera1Synf�lt.gameObject.SetActive(true);
        }
            
    }


}
