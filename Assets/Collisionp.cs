using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisionp : MonoBehaviour
{
    public Transform sparkle;
    public Transform red;


    void Start()
    {


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "HP")
        {
            Instantiate(sparkle, transform.position, Quaternion.identity);
        }


        if (collision.gameObject.tag == "Points")
        {
            Instantiate(red, transform.position, Quaternion.identity);
        }

    }

}
