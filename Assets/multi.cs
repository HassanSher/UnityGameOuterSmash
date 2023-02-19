using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class multi : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject banana;
    public Color red = Color.red;
    public Camera cam;
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            Destroy(gameObject);
            Vector2 position = new Vector2(Random.Range(-17.0f, 21f), Random.Range(3f, -47f));
            Instantiate(banana, position, Quaternion.identity);
            cam.backgroundColor = red;
        }


    }
}
