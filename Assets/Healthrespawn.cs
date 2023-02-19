using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthrespawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Vector2 position = new Vector2(Random.Range(-17.0f, 21f),Random.Range(3f, -47f));
            Instantiate(prefab, position, Quaternion.identity);
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "HP")
        {
            Vector2 position = new Vector2(Random.Range(-17.0f, 21f), Random.Range(3f, -47f));
            Instantiate(prefab, position, Quaternion.identity);
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Enemy")
        {
            Vector2 position = new Vector2(Random.Range(-17.0f, 21f), Random.Range(3f, -47f));
            Instantiate(prefab, position, Quaternion.identity);
            Destroy(gameObject);
        }


        if (collision.gameObject.tag == "Points")
        {
            Vector2 position = new Vector2(Random.Range(-17.0f, 21f), Random.Range(3f, -47f));
            Instantiate(prefab, position, Quaternion.identity);
            Destroy(gameObject);
        }

    }
}
