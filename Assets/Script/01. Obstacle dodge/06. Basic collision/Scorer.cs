using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Scorer : MonoBehaviour
{
    [SerializeField] TMP_Text myScorer;
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
        if (other.gameObject.tag == "hit")
        {
            return;
        }
        else if (other.gameObject.tag == "hazard")
        {
            other.gameObject.tag = "hit";
            score--;
            myScorer.text = string.Format("{0:0}", score);
            return;
        }
        else if (other.gameObject.tag == "coin")
        {
            score++;
            other.gameObject.SetActive(false);
            myScorer.text = string.Format("{0:0}", score);
            return;
        }
        
    }
}
