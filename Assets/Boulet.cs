using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Boulet : MonoBehaviour
{
    public MoveCamera moveCamera = null;
    // Start is called before the first frame update
    void Start()
    {
        var Camera = GameObject.Find("Main Camera");
        transform.position = Camera.transform.position;
    }

    // Update is called once per frame
    void Update()
    {                
        transform.Translate(0, 0, -0.1f);            
    }
}
