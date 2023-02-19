using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Joystick joystick;

    public Rigidbody2D rb;

    Vector2 movement;

    public float speed = 5f; //speed of player
                             // Update is called once per frame

    void Start()
    {



    }

    void Update()
    {
        //JOYSTICK INPUT
        movement.x = joystick.Horizontal;
        movement.y = joystick.Vertical;

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Points")
            speed = 8f;

        StartCoroutine(wait());
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(10f);
        speed = 5f;
    }
}

