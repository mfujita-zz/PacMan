using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour 
{
    public Transform destino;
    public float speed = 0.3f;

    void FixedUpdate () 
    {
        if (transform.position != destino.position)
        {
            Vector2 p = Vector2.MoveTowards(transform.position, destino.position, speed);
            GetComponent<Rigidbody2D>().MovePosition(p);
        }

        Vector2 dir = destino.position - transform.position;
        GetComponent<Animator>().SetFloat("dirX", dir.x);
        GetComponent<Animator>().SetFloat("dirY", dir.y);
	}

    void OnTriggerEnter2d(Collider2D co)
    {
        if (co.name == "pacman")
        {
            Destroy(co.gameObject);
        }
    }
}
