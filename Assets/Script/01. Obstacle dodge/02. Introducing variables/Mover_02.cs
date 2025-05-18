using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Mover_02 : MonoBehaviour
{
    float rotateY = 0.1f;
    float moveZ = 0.001f;
    float moveUp = 0.001f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, moveUp, moveZ);
        transform.Rotate(0f, rotateY, 0f);

    }
}
