using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{

    public Text scoreText;

    void Start()
    {
        
    }

    void Update()
    {
        scoreText.text = CharacterScript.puntos.ToString();
    }
}
