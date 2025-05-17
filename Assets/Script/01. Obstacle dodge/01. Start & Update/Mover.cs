using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// dalam unity, jika kita assign sebuah script ke dalam game object, 
// kita dapat memanipulasi seluruh attribute dalam game object tersebut

// untuk mengubah main camera dalam unity secara cepat, 
// click game object tersebut,
// lalu click GameObject tab -> align with view

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // misalnya dalam kasus ini, 
        // saya mengubah property transform dari game object tersebut 
        // dengan menambahkan koordinat 1 dari z index original position
        // transform.Translate(0f, 0f, 1f);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, 0f, 0.001f);
        transform.Rotate(0f, 0.1f, 0f);

    }
}
