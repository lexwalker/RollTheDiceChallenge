using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileLogic : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    GameObject Player;
    public PolygonCollider2D collider;
    public Vector2 tilePosition;
    private Sprite tileUnselected;
    public Sprite tileSelected;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        collider = gameObject.GetComponent<PolygonCollider2D>();
        tilePosition = gameObject.transform.position;
        spriteRenderer = GetComponent<SpriteRenderer>();
        tileUnselected = GetComponent<SpriteRenderer>().sprite;
    }

    private void OnMouseOver()
    {
            if (Vector2.Distance(Player.transform.position, gameObject.transform.position) < 1.5f)
            {
                spriteRenderer.sprite = tileSelected;
            }    
    }

    private void OnMouseExit()
    {
        spriteRenderer.sprite = tileUnselected;
    }
}
