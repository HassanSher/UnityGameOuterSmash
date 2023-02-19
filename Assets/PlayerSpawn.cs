using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    void Start()
    {
        transform.position = new Vector2(Random.Range(-17.0f, 21f), Random.Range(3f, -47f));

    }
}
