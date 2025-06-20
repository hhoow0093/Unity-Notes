using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerObjectFall : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject myDropper;

    void Awake()
    {
        myDropper.SetActive(false);
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            myDropper.SetActive(true);

        }
        if (other.gameObject == myDropper)
        {
            MeshRenderer myDropperRenderer = myDropper.GetComponent<MeshRenderer>();
            Rigidbody mydropperRB = myDropper.GetComponent<Rigidbody>();
            BoxCollider mydropperCollider = myDropper.GetComponent<BoxCollider>();
            Destroy(mydropperRB);
            Destroy(mydropperCollider);
            myDropperRenderer.enabled = false;
            myDropper.SetActive(false);
            
        }
    }
}
