﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
  

    // Update is called once per frame
   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Restart");
        }


    }
}
