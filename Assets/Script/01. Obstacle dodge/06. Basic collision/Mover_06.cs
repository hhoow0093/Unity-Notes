using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;

// rigid body component biasanya digunakan untuk interaksi pada collision dalam game object. 
// istrigger banyak digunakan untuk menentukan apakah objek player memasuki sebuah collider apa enggak.

// method. 

public class Mover_06 : MonoBehaviour
{
    [SerializeField] float speed = 10f;

    void Start()
    {
        printInstruction();

    }

    void Update()
    {
        movePlayer();
    }

    void printInstruction()
    {
        UnityEngine.Debug.Log("welcome to the game");
        UnityEngine.Debug.Log("1. press start to play");
        UnityEngine.Debug.Log("2. press close to exit");
    }

    void movePlayer()
    {
        float moveZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float moveY = 0f;
        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(moveX, moveY, moveZ);
    }
}
