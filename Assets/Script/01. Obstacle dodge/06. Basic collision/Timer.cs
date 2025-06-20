using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    private float timeElapsed = 0f;
    private bool timeRunning = true;
    [SerializeField] TMP_Text mytext;

    // Update is called once per frame
    void Update()
    {
        if (timeRunning)
        {
            timeElapsed += Time.deltaTime;
            int minutes = Mathf.FloorToInt(timeElapsed / 60);
            int seconds = Mathf.FloorToInt(timeElapsed % 60);
            mytext.text = string.Format("{0:00} : {1:00}", minutes, seconds);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        int minutes = Mathf.FloorToInt(timeElapsed / 60);
        int seconds = Mathf.FloorToInt(timeElapsed % 60);
        if (other.gameObject.tag == "goal")
        {
            timeRunning = false;
            mytext.text = string.Format("Completed : {0:00} : {1:00}", minutes, seconds);
        }
    }
}
