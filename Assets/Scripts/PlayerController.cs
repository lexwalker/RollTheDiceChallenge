using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    private void OnMouseOver(PolygonCollider2D collider)
    { 
            if (collider.tag == "Ground")
            {

                collider.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 155);
            }
    }
    

}
