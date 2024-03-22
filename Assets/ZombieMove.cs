using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ZombieMove : MonoBehaviour
{
    float Rdmx = 0;
    float Rdmy = 0;
    float Rdmz = 0;
    int seed = DateTime.Now.Millisecond;
    
    // Start is called before the first frame update
    void Start()
    {
        System.Random rnd = new System.Random(seed);

        float rdmX = (float)rnd.Next(-8, 5);
        Rdmx = rdmX;
        float rdmZ = (float)rnd.Next(-15, -12);
        Rdmz = rdmZ;

        float y = transform.position.y;

        transform.position = new Vector3(Rdmx, y, Rdmz);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 0.01f);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("BIM");
        GameObject.Destroy(this.gameObject);
    }
}
