using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePostion = Input.mousePosition;
        mousePostion = Camera.main.ScreenToWorldPoint(mousePostion);

        Vector2 direction = new Vector2(mousePostion.x - transform.position.x, mousePostion.y - transform.position.y);

        transform.up = direction;
    }
}
