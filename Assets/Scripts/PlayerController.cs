using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private TileLogic tiles;
    private GameObject Player;
    private PolygonCollider2D collider;
    private SpriteRenderer spriteRenderer;
    public Sprite spriteUnselected;
    public Sprite spriteSelected;
    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && Vector2.Distance(Player.transform.position, gameObject.transform.position) < 1.5f)
        {
            Debug.Log(111);
            transform.position = gameObject.transform.position;
        }
    }


}
