using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    // when player arrives at the box collder, then projectile is set to be active
    [SerializeField] GameObject[] projectiles;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            for (int i = 0; i < projectiles.Length; i++)
            {
                projectiles[i].SetActive(true);
            }

        }

        Destroy(gameObject);
        
    }
}
