using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    Color[] colors = { Color.red, Color.blue, Color.green, Color.black};

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        // Debug.Log($"you hit an object!: {gameObject.name}");
        // get the gameobject renderer and change its matrial color
        MeshRenderer rend = gameObject.GetComponent<MeshRenderer>();
        rend.material.color = colors[Random.Range(0, colors.Length)];
    }

}
