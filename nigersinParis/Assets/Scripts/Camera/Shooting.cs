using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class Shooting : MonoBehaviour
{
    private Camera mainCam;
    private Vector3 mousePos;
    public GameObject bullet;
    public Transform bulletTransform;
    private GameObject currentBullet;
    private Transform aimTransform;
    public bool isFiring;
    public float firingDuration = 5f;

    // Start is called before the first frame update
    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
       // movement
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 rotation = mousePos - transform.position;
        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotZ);

        Vector3 aimlocalScale = Vector3.one;
        if (rotZ > 90 || rotZ < -90)
        {
            aimlocalScale.y = -1f;
        }
        else
        {
            aimlocalScale.y = +1f;
        }
        aimTransform.localScale = aimlocalScale;

        // skjutning
        if (Input.GetMouseButtonDown(0))
        {
            StartFiring();
        }

        if (Input.GetMouseButtonUp(0))
        {
            StopFiring();
        }
    }

    void StartFiring()
    {
        if (!isFiring)
        {
            isFiring = true;
            currentBullet = Instantiate(bullet, bulletTransform.position, Quaternion.identity);
        }
    }

    void StopFiring()
    {
        if (isFiring)
        {
            isFiring = false;
            Destroy(currentBullet, firingDuration);
        }
    }
}