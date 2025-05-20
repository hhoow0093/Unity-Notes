using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Flyto : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform player;
    [SerializeField] float FlySpeed = 100f;
    Vector3 playerPosition;
    void Start()
    {
        playerPosition = player.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        moveToplayer();
        if (playerPosition == gameObject.transform.position)
        {
            destroyWhenArrived();
        }

    }

    void destroyWhenArrived()
    {
        Destroy(gameObject);
    }

    void moveToplayer()
    {
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, playerPosition, FlySpeed * Time.deltaTime);
    }
}
