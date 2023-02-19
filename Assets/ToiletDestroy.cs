using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToiletDestroy : MonoBehaviour


{
  
  


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlatformManager.Instance.StartCoroutine("SpawnPlatform",
                       new Vector2(transform.position.x, transform.position.y));
            Destroy(gameObject,0f);



        }

      
    }


}
