using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform m_transform;

    public float moveSpeed;
    float speedX, speedY;
    Rigidbody2D rb;

    void Start()
    {
        m_transform = this.transform;
        rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        speedX = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;
        speedY = Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime;

        rb.velocity = new Vector2(speedX, speedY);

    }
}
