using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacmanMove : MonoBehaviour 
{
    public float speed = 0.01f;
    Vector2 dest = Vector2.zero;
    float posX;
    float posY;
    	
	void Start () 
    {
        //dest = transform.position;

        Debug.Log("Acima " + Vector2.up);
        Debug.Log("Abaixo " + Vector2.down);
        Debug.Log("Direita " + Vector2.right);
        Debug.Log("Esquerda " + Vector2.left);
	}
	
	// Update is called once per frame
	void FixedUpdate () 
    {
//        Vector2 p = Vector2.MoveTowards(transform.position, dest, speed);
//        GetComponent<Rigidbody2D>().MovePosition(p);

        posX = transform.position.x;
        posY = transform.position.y;


//        if ((Vector2)transform.position == dest)
//        {
//            if (Input.GetKey(KeyCode.UpArrow) && Valid(Vector2.up))
//            {
//                dest = new Vector2(posX, transform.position.y);  // (Vector2)transform.position + Vector2.up;
//            }
//            if (Input.GetKey(KeyCode.RightArrow) && Valid(Vector2.right))
//            {
//                dest = new Vector2(transform.position.x, posY); // (Vector2)transform.position + Vector2.right;
//            }
//            if (Input.GetKey(KeyCode.DownArrow) && Valid(-Vector2.up))
//            {
//                dest = new Vector2(posX, -transform.position.y);  //(Vector2)transform.position - Vector2.up;
//            }
//            if (Input.GetKey(KeyCode.LeftArrow) && Valid(-Vector2.right))
//            {
//                dest = new Vector2(-transform.position.x, posY); //(Vector2)transform.position - Vector2.right;
//            }
//        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * speed);
        }

        Vector2 dir = dest - (Vector2)transform.position;
        Debug.Log("Direção == " + dir);

        GetComponent<Animator>().SetFloat("dirX", dir.x);
        GetComponent<Animator>().SetFloat("dirY", dir.y);
	}

//    bool Valid(Vector2 dir)
//    {
//        Vector2 pos = transform.position;
//        RaycastHit2D hit = Physics2D.Linecast(pos + dir, pos);
//        return (hit.collider == GetComponent<Collider2D>());
//    }
}
