using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public GameObject TemplateMissile;
    public GameObject TemplateZombie;

    public List<GameObject> Zombies = new List<GameObject>();
    public List<GameObject> Missiles = new List<GameObject>();
    bool envoyer = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, 1f);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -1f);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-1f, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(1f, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var go = GameObject.Instantiate(TemplateMissile);
            Missiles.Add(go);

            var script = go.GetComponent<Boulet>();
            script.moveCamera = this;
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            var go = GameObject.Instantiate(TemplateZombie);
            Zombies.Add(go);
            go.SetActive(true);
            //var script = go.GetComponent<ZombieMove>();
        }
    }
}

