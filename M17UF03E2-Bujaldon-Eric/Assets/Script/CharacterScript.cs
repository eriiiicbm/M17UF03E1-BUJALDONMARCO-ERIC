using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int puntos;
    // Start is called before the first frame update
    void Start()
    {
        puntos = 0;
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    private void OnTriggerEnter2D(Collider collision)
    {
        if (collision.CompareTag("Score"))
        {
            puntos++;
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("Death"))
        {
            Application.Quit();
        }
    }


}
