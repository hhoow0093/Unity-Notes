using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;


public class Mover_03 : MonoBehaviour
{
    [SerializeField] float moveZ = 0f;
    [SerializeField] float moveY = 0f;
    [SerializeField] float moveX = 1.5f;
    float Maxtimer = 3f;
    float currentTimer = 0f;

    void Start()
    {

    }

    void Update()
    {
        // memanfaatkan Time.deltatime untuk pergeeakkan dalam timer
         
        transform.Translate(moveX * Time.deltaTime, moveY, moveZ);

        currentTimer += Time.deltaTime;
        
        if (currentTimer >= Maxtimer)
        {
            moveX *= -1f;
            currentTimer = 0f;
        }

    }
}
