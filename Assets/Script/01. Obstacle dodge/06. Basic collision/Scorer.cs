using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score = 0;
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
        // assigning othe gameObject to hit if player hasnt hit the item (tags)
        if (other.gameObject.tag == "hit")
        {
            return;
        }
        else
        {
            other.gameObject.tag = "hit";
            Debug.Log($"Score: {score}");
            score++;
        }
        
    }
}
