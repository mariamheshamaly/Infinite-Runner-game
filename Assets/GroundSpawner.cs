using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject GroundTile;
    Vector3 nextSpawnPoint;
    public PlayerController playerController;

    
    
    public void SpawnTile()
    {
        GameObject temp = Instantiate(GroundTile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }
    void Awake()
    {
        //Invoke("SpawnTile", 2);
        SpawnTile();
        //SpawnTile();
        //SpawnTile();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
