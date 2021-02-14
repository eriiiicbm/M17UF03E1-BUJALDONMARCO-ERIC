using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterScript : MonoBehaviour
{
    public static int puntos;
    // Start is called before the first frame update
    void Start()
    {
        puntos = 0;
    }

    // Update is called once per frame
    void Update()
    {
 

        if (puntos == 4)
        {
            SceneManager.LoadScene("Victory");
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Score"))
        {
            puntos++;
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("Death"))
        {
            SceneManager.LoadScene("Death");
        }
    }


}
