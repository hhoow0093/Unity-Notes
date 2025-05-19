using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;

// to add cinemachine, window -> package manager -> Packages: Unit Regsitry -> seach cinemachine
public class Mover_05 : MonoBehaviour
{
    [SerializeField] float speed = 10f;

    void Start()
    {

    }

    void Update()
    {
        float moveZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float moveY = 0f;
        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(moveX, moveY, moveZ);

    }
}
