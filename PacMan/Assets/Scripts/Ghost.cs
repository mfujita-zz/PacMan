using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour 
{
    public Transform[] destino;
    int i=0;
    public float speed = 0.3f;

    void FixedUpdate () 
    {
        if (transform.position != destino[i].position)
        {
            Vector2 p = Vector2.MoveTowards(transform.position, destino[i].position, speed);
            GetComponent<Rigidbody2D>().MovePosition(p);                
        }
        else
        {
            i = (i + 1) % destino.Length;
        }       

        Vector2 dir = destino[i].position - transform.position;
        GetComponent<Animator>().SetFloat("dirX", dir.x);
        GetComponent<Animator>().SetFloat("dirY", dir.y);
	}

    void OnCollisionEnter2D(Collision2D co)
    {
        if (co.gameObject.name == "pacman")
        {
            Destroy(co.gameObject);
            Destroy(GetComponent<Ghost>());
        }
    }
}
