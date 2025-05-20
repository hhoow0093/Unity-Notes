using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float spinSpeedY = 0f;
    [SerializeField] float spinSpeedZ = 0f;
    [SerializeField] float spinSpeedX = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            gameObject.transform.Rotate(spinSpeedX * Time.deltaTime, spinSpeedY * Time.deltaTime, spinSpeedZ * Time.deltaTime);
    }
}
