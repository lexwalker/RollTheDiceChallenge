using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    [SerializeField] GameObject Player;
    private Vector3 SpawnPoint;
    // Start is called before the first frame update
    private void Start()
    {
        SpawnPlayer();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnPlayer()
    {
        SpawnPoint = GameObject.FindGameObjectWithTag("SpawnPoint").transform.position;
        Player.transform.position = SpawnPoint;
    }
}
