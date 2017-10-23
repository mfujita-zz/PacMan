using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacdot : MonoBehaviour {

	
	void Start () 
    {
		
	}
	
	
	void Update () 
    {
		
	}

    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "pacman")
        {
            Destroy(gameObject);
            Pontuacao.points++;
        }
    }
}
