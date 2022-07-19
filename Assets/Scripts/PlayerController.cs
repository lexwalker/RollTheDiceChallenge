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
        tiles = GameObject.Find("Tile").GetComponent<TileLogic>();
        Player = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    private void OnMouseOver()
    {
        Debug.Log(gameObject.transform.position);
    }
    

}
