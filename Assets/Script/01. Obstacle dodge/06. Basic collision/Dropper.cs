using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    // Start is called before the first frame update
    float timer = 0f;
    [SerializeField] float maxtimer = 3f;
    // float timerRate = 0.1f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer = Time.time;
        if (timer <= maxtimer)
        {
            Debug.Log($"time elapsed: {Time.time}");
            
        }

        if (timer >= maxtimer)
        {
            dropItems();
        }
    }

    void dropItems()
    {
        if (gameObject.GetComponent<Rigidbody>() != null)
        {
            return;
        }
        gameObject.AddComponent<Rigidbody>();
    }
    
}
