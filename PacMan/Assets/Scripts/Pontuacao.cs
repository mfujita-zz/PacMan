using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Pontuacao : MonoBehaviour 
{
    public Text pontos;
    public static int points = 0;
     
    void Start () 
    {
        pontos.text = "0";	
	}
	
	// Update is called once per frame
	void Update () 
    {
        pontos.text = points.ToString();
        if (Convert.ToInt32(points) == 97)
        {
            SceneManager.LoadScene("Demolidor");
        }
	}
}
