using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    // Color[] colors = { Color.red, Color.blue, Color.green, Color.black};

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision other)
    {
        // Debug.Log($"you hit an object!: {gameObject.name}");
        // get the gameobject renderer and change its matrial color

        // do not change color unless object hit is player
        if (other.gameObject.tag == "Player")
        {
            MeshRenderer rend = gameObject.GetComponent<MeshRenderer>();
            rend.material.color = Color.black;


        }
    }

}
