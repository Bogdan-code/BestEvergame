using UnityEngine;

public class OnEntryDisable : MonoBehaviour
{
    static public GameObject Kamera1;
    static public GameObject Kamera1Synf�lt;
    static public bool OwnCam1 = false;

    static void Update ()
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
