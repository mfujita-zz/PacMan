using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacmanMove : MonoBehaviour 
{
    public float speed = 0.01f;
    Vector2 dest = Vector2.zero;
    public Animator animator;
    	
	void Start () 
    {        
        animator = GetComponent<Animator>();
	}	
	
	void FixedUpdate () 
    {
        float posX = Input.GetAxisRaw("Horizontal");
        float posY = Input.GetAxisRaw("Vertical");

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * speed);
            GetComponent<Animator>().SetFloat("dirY", posY);
            GetComponent<Animator>().SetFloat("dirX", 0);
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * speed);
            GetComponent<Animator>().SetFloat("dirY", posY);
            GetComponent<Animator>().SetFloat("dirX", 0);
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed);
            GetComponent<Animator>().SetFloat("dirX", posX);
            GetComponent<Animator>().SetFloat("dirY", 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed);
            GetComponent<Animator>().SetFloat("dirX", posX);
            GetComponent<Animator>().SetFloat("dirY", 0);
        }
	}
}
