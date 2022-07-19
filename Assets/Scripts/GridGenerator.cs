using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGenerator : MonoBehaviour
{
    [SerializeField] static List<GameObject> tiles = new List<GameObject>();
    private int gridWidth = 6;
    private int gridHeight = 6;
    private int playerCount = 1;
    private int treasuresCount = 5;
    private int eventCount = 10;

    // Start is called before the first frame update

    private void Awake()
    {
        CreateTilesTable();
        GenerateGrid();  
    }

    private void GenerateGrid()
    {
        for (int x = 0; x < gridWidth; x++)
        {
            for (int y = 0; y < gridHeight; y++)
            {
                int randomValue = Random.Range(0, tiles.Count);
                GameObject currentTile = tiles[randomValue];
                tiles.Remove(tiles[randomValue]);

                float posX = 0.5f * x - 0.5f * y;
                float posY = -0.25f * x - 0.25f * y;

                GameObject newTile = Instantiate(currentTile, new Vector2(posX, posY), transform.rotation);

                newTile.name = "Tile";
            }
        }
        
    }

    private void CreateTilesTable() 
    {
        tiles.Add(Resources.Load<GameObject>("Prefabs/GridPrefabs/PlayerSpawnCell"));
        for (int treasuresCounter = 0; treasuresCounter < treasuresCount; treasuresCounter++)

        {
            tiles.Add(Resources.Load<GameObject>("Prefabs/GridPrefabs/TreasureCell"));
        }
        for (int eventCounter = 0; eventCounter < eventCount; eventCounter++)
        {
            tiles.Add(Resources.Load<GameObject>("Prefabs/GridPrefabs/EventCell"));
        }
        for (int emptyCounter = 0; emptyCounter < (gridWidth * gridHeight) - playerCount - eventCount - treasuresCount; emptyCounter++)
        {
            tiles.Add(Resources.Load<GameObject>("Prefabs/GridPrefabs/EmptyCell"));
        }
    }
}
