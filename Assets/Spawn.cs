using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject o;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(Random.Range(-17.0f, 21f), Random.Range(3f, -47f));

    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Vector2 position = new Vector2(Random.Range(-17.0f, 21f), Random.Range(3f, -47f));
            Instantiate(o, position, Quaternion.identity);
            Destroy(gameObject);
        }


    }
}
