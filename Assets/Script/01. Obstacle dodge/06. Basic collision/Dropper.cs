using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{

    float timer = 0f;
    [SerializeField] float timeToWait = 3f;
    MeshRenderer myRenderer;
    Rigidbody myRigidBody;

    void Start()
    {
        myRenderer = gameObject.GetComponent<MeshRenderer>();
        myRigidBody = gameObject.GetComponent<Rigidbody>();

        myRenderer.enabled = false;
        myRigidBody.useGravity = false;

    }

    void Update()
    {
        timer = Time.time;
        if (timer >= timeToWait)
        {
            dropItems();
        }

    }

    void dropItems()
    {
        if (myRenderer.enabled == true && myRigidBody.useGravity == true)
        {
            return;
        }
        else
        {
            myRenderer.enabled = true;
            myRigidBody.useGravity = true;
        }
    }


    
}

// float timer = 0f;
// [SerializeField] float maxtimer = 3f;

// void dropItems()
// {
//     if (gameObject.GetComponent<Rigidbody>() != null)
//     {
//         return;
//     }
//     gameObject.AddComponent<Rigidbody>();
// }

// void Update()
// {
//     timer = Time.time;
//     if (timer <= maxtimer)
//     {
//         Debug.Log($"time elapsed: {Time.time}");
        
//     }

//     if (timer >= maxtimer)
//     {
//         dropItems();
//     }
// }