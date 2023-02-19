using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hidetrail : MonoBehaviour
{
    public GameObject Trail;
    // Start is called before the first frame update
    void Start()
    {
        Trail.GetComponent<Renderer>().enabled = false;
        Trail.GetComponent<Renderer>().enabled = true;
    }

    // Update is called once per frame

}
