using UnityEngine;

public class OnEntryDisable : MonoBehaviour
{
    public GameObject Kamera1;
    public GameObject Kamera1Synfält;
    static public bool OwnCam1 = false;

    void Update ()
    {
        if (OwnCam1 == false)
        {
            Kamera1.gameObject.SetActive(false);
            Kamera1Synfält.gameObject.SetActive(false);
        }
        else
        {
            Kamera1.gameObject.SetActive(true);
            Kamera1Synfält.gameObject.SetActive(true);
        }
            
    }


}
