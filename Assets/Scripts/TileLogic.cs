using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileLogic : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public PolygonCollider2D collider;
    public Vector2 tilePosition;
    private Sprite tileUnselected;
    public Sprite tileSelected;

    // Start is called before the first frame update
    void Start()
    {
        collider = gameObject.GetComponent<PolygonCollider2D>();
        tilePosition = gameObject.transform.position;
        spriteRenderer = GetComponent<SpriteRenderer>();
        tileUnselected = GetComponent<SpriteRenderer>().sprite;
    }

    private void OnMouseOver()
    {
            spriteRenderer.sprite = tileSelected;
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log(tilePosition);
            }
    }

    private void OnMouseExit()
    {
        spriteRenderer.sprite = tileUnselected;
    }
}
