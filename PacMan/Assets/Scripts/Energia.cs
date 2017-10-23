using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energia : MonoBehaviour 
{    	
	void Start () {
		
	}
		
	void Update () 
    {
		
	}

    void OnTriggerEnter2D(Collider2D coisa)
    {
        if (coisa.name == "pacman")
        {
            Destroy(gameObject);
        }
    }
}
