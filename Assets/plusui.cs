using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plusui : MonoBehaviour
{

    public GameObject sparkle;


    
    void Start()
    {
       

        sparkle.SetActive(false);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "HP")
        {
           
            sparkle.SetActive(true);
            
        }
        StartCoroutine(waiter());
    }




        IEnumerator waiter()
        {



            //Wait for 2 seconds
            yield return new WaitForSeconds(0.3f);



        sparkle.SetActive(false);
        

        }
}