using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpawner groundSpawner;
    public GameObject Obstacle1;
    public GameObject Obstacle2;
    public GameObject Obstacle3;
    public GameObject CollectableYellow;
    public GameObject CollectableRed;
    public GameObject wall1;
    public GameObject wall2;
    PlayerController player;
    int random;

   
    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
        player = GameObject.FindObjectOfType<PlayerController>();

        StartCoroutine( SpawnObstacle());
        SpawnCollectable();
       
        Transform spawnpoint = transform.GetChild(14).transform;
        Transform spawnpoint2 = transform.GetChild(15).transform;

        Instantiate(wall1, spawnpoint.position, Quaternion.identity, transform);

        Instantiate(wall2, spawnpoint2.position, Quaternion.identity, transform);
    }
    private void OnTriggerExit(Collider other)
    {
        groundSpawner.SpawnTile();

        Transform spawnpoint = transform.GetChild(14).transform;
        Transform spawnpoint2 = transform.GetChild(15).transform;


        Instantiate(wall1, spawnpoint.position, Quaternion.identity, transform); 

        Instantiate(wall2, spawnpoint2.position, Quaternion.identity, transform);


        Destroy(gameObject, 7);
    }

      IEnumerator SpawnObstacle()
    {
        yield return new WaitForSeconds(3);

        GameObject[] arr1 = new GameObject[3];
        arr1[0] = Obstacle1;
        arr1[1] = Obstacle2;
        arr1[2] = Obstacle3;
        int random= Random.Range(0, 3);
        GameObject m = arr1[random];
        int index;
        if (m == Obstacle2)
        {
            index = Random.Range(19,21);
        }
        else if (m == Obstacle3)
        {
            index = 21;

        } 
        else 
        {
             index = Random.Range(16, 19);
        } 

         Transform spawnpoint = transform.GetChild(index).transform;
        if (spawnpoint.position.z - player.transform.position.z > 60)
        {

            Instantiate(m, spawnpoint.position, Quaternion.identity, transform);
        }
    }
    void SpawnCollectable()
    {
            int index = Random.Range(8, 14);
            Transform spawnpoint = transform.GetChild(index).transform;
           Instantiate(CollectableYellow, spawnpoint.position, Quaternion.identity, transform);

        float x;
            float y;
            float z;

            float x2;
            float y2;
            float z2;

            Vector3 v;
            Vector3 v2;
            random = Random.Range(0,10);


        if (spawnpoint.position.x == -27)
        {
            switch (random)
            {
                case 0:
                    x = spawnpoint.position.x + 29;
                    y = spawnpoint.position.y;
                    z = spawnpoint.position.z;
                    v = new Vector3(x, y, z);

                    Instantiate(CollectableYellow, v, Quaternion.identity, transform);
                    break;

                case 1:
                    x = spawnpoint.position.x + 29 + 29;
                    y = spawnpoint.position.y;
                    z = spawnpoint.position.z;
                    v = new Vector3(x, y, z);

                    Instantiate(CollectableYellow, v, Quaternion.identity, transform);
                    break;
                case 3:
                    x = spawnpoint.position.x + 29;
                    y = spawnpoint.position.y;
                    z = spawnpoint.position.z;
                    v = new Vector3(x, y, z);

                    Instantiate(CollectableRed, v, Quaternion.identity, transform);

                    break;

                case 4:
                    x = spawnpoint.position.x + 29 + 29;
                    y = spawnpoint.position.y;
                    z = spawnpoint.position.z;
                    v = new Vector3(x, y, z);

                    Instantiate(CollectableRed, v, Quaternion.identity, transform);
                    break;
                case 5:
                    x = spawnpoint.position.x + 29;
                    y = spawnpoint.position.y;
                    z = spawnpoint.position.z;
                    v = new Vector3(x, y, z);

                    x2 = spawnpoint.position.x + 29 + 29;
                    y2 = spawnpoint.position.y;
                    z2 = spawnpoint.position.z;
                    v2 = new Vector3(x2, y2, z2);

                    Instantiate(CollectableRed, v, Quaternion.identity, transform);
                    Instantiate(CollectableRed, v2, Quaternion.identity, transform);
                    break;
                case 6:
                    x = spawnpoint.position.x + 29;
                    y = spawnpoint.position.y;
                    z = spawnpoint.position.z;
                    v = new Vector3(x, y, z);

                    x2 = spawnpoint.position.x + 29 + 29;
                    y2 = spawnpoint.position.y;
                    z2 = spawnpoint.position.z;
                    v2 = new Vector3(x2, y2, z2);

                    Instantiate(CollectableYellow, v, Quaternion.identity, transform);
                    Instantiate(CollectableYellow, v2, Quaternion.identity, transform);
                    break;
                case 7:
                    x = spawnpoint.position.x + 29;
                    y = spawnpoint.position.y;
                    z = spawnpoint.position.z;
                    v = new Vector3(x, y, z);

                    x2 = spawnpoint.position.x + 29 + 29;
                    y2 = spawnpoint.position.y;
                    z2 = spawnpoint.position.z;
                    v2 = new Vector3(x2, y2, z2);

                    Instantiate(CollectableYellow, v, Quaternion.identity, transform);
                    Instantiate(CollectableRed, v2, Quaternion.identity, transform);
                    break;
                case 8:
                    x = spawnpoint.position.x + 29;
                    y = spawnpoint.position.y;
                    z = spawnpoint.position.z;
                    v = new Vector3(x, y, z);

                    x2 = spawnpoint.position.x + 29 + 29;
                    y2 = spawnpoint.position.y;
                    z2 = spawnpoint.position.z;
                    v2 = new Vector3(x2, y2, z2);

                    Instantiate(CollectableRed, v, Quaternion.identity, transform);
                    Instantiate(CollectableYellow, v2, Quaternion.identity, transform);
                    break;

                case 9:

                    Instantiate(CollectableYellow, spawnpoint.position, Quaternion.identity, transform);
                    break;

                

            }
            if (spawnpoint.position.x == 2)
            {
                
                switch (random) {
                    case 0:
                        x = spawnpoint.position.x + 29;
                        y = spawnpoint.position.y;
                        z = spawnpoint.position.z;
                        v = new Vector3(x, y, z);

                        Instantiate(CollectableYellow, v, Quaternion.identity, transform);
                        break;

                    case 1:
                        x = spawnpoint.position.x -29;
                        y = spawnpoint.position.y;
                        z = spawnpoint.position.z;
                        v = new Vector3(x, y, z);

                        Instantiate(CollectableYellow, v, Quaternion.identity, transform);
                        break;
                    case 3:
                        x = spawnpoint.position.x + 29;
                        y = spawnpoint.position.y;
                        z = spawnpoint.position.z;
                        v = new Vector3(x, y, z);

                        Instantiate(CollectableRed, v, Quaternion.identity, transform);

                        break;

                    case 4:
                        x = spawnpoint.position.x - 29;
                        y = spawnpoint.position.y;
                        z = spawnpoint.position.z;
                        v = new Vector3(x, y, z);

                        Instantiate(CollectableRed, v, Quaternion.identity, transform);
                        break;
                    case 5:
                        x = spawnpoint.position.x + 29;
                        y = spawnpoint.position.y;
                        z = spawnpoint.position.z;
                        v = new Vector3(x, y, z);

                        x2 = spawnpoint.position.x - 29 ;
                        y2 = spawnpoint.position.y;
                        z2 = spawnpoint.position.z;
                        v2 = new Vector3(x2, y2, z2);

                        Instantiate(CollectableRed, v, Quaternion.identity, transform);
                        Instantiate(CollectableRed, v2, Quaternion.identity, transform);
                        break;
                    case 6:
                        x = spawnpoint.position.x + 29;
                        y = spawnpoint.position.y;
                        z = spawnpoint.position.z;
                        v = new Vector3(x, y, z);

                        x2 = spawnpoint.position.x -29;
                        y2 = spawnpoint.position.y;
                        z2 = spawnpoint.position.z;
                        v2 = new Vector3(x2, y2, z2);

                        Instantiate(CollectableYellow, v, Quaternion.identity, transform);
                        Instantiate(CollectableYellow, v2, Quaternion.identity, transform);
                        break;
                    case 7:
                        x = spawnpoint.position.x + 29;
                        y = spawnpoint.position.y;
                        z = spawnpoint.position.z;
                        v = new Vector3(x, y, z);

                        x2 = spawnpoint.position.x -29;
                        y2 = spawnpoint.position.y;
                        z2 = spawnpoint.position.z;
                        v2 = new Vector3(x2, y2, z2);

                        Instantiate(CollectableYellow, v, Quaternion.identity, transform);
                        Instantiate(CollectableRed, v2, Quaternion.identity, transform);
                        break;
                    case 8:
                        x = spawnpoint.position.x + 29;
                        y = spawnpoint.position.y;
                        z = spawnpoint.position.z;
                        v = new Vector3(x, y, z);

                        x2 = spawnpoint.position.x -29;
                        y2 = spawnpoint.position.y;
                        z2 = spawnpoint.position.z;
                        v2 = new Vector3(x2, y2, z2);

                        Instantiate(CollectableRed, v, Quaternion.identity, transform);
                        Instantiate(CollectableYellow, v2, Quaternion.identity, transform);
                        break;

                    case 9:

                        Instantiate(CollectableYellow, spawnpoint.position, Quaternion.identity, transform);
                        break;
                   

                }
            }
            if (spawnpoint.position.x == 31)
            {
                switch (random)
                {
                    case 0:
                        x = spawnpoint.position.x - 29 - 29;
                        y = spawnpoint.position.y;
                        z = spawnpoint.position.z;
                        v = new Vector3(x, y, z);

                        Instantiate(CollectableYellow, v, Quaternion.identity, transform);
                        break;

                    case 1:
                        x = spawnpoint.position.x - 29;
                        y = spawnpoint.position.y;
                        z = spawnpoint.position.z;
                        v = new Vector3(x, y, z);

                        Instantiate(CollectableYellow, v, Quaternion.identity, transform);
                        break;
                    case 3:
                        x = spawnpoint.position.x - 29;
                        y = spawnpoint.position.y;
                        z = spawnpoint.position.z;
                        v = new Vector3(x, y, z);

                        Instantiate(CollectableRed, v, Quaternion.identity, transform);

                        break;

                    case 4:
                        x = spawnpoint.position.x - 29 - 29;
                        y = spawnpoint.position.y;
                        z = spawnpoint.position.z;
                        v = new Vector3(x, y, z);

                        Instantiate(CollectableRed, v, Quaternion.identity, transform);
                        break;
                    case 5:
                        x = spawnpoint.position.x - 29;
                        y = spawnpoint.position.y;
                        z = spawnpoint.position.z;
                        v = new Vector3(x, y, z);

                        x2 = spawnpoint.position.x - 29 - 29;
                        y2 = spawnpoint.position.y;
                        z2 = spawnpoint.position.z;
                        v2 = new Vector3(x2, y2, z2);

                        Instantiate(CollectableRed, v, Quaternion.identity, transform);
                        Instantiate(CollectableRed, v2, Quaternion.identity, transform);
                        break;
                    case 6:
                        x = spawnpoint.position.x - 29;
                        y = spawnpoint.position.y;
                        z = spawnpoint.position.z;
                        v = new Vector3(x, y, z);

                        x2 = spawnpoint.position.x - 29 -29;
                        y2 = spawnpoint.position.y;
                        z2 = spawnpoint.position.z;
                        v2 = new Vector3(x2, y2, z2);

                        Instantiate(CollectableYellow, v, Quaternion.identity, transform);
                        Instantiate(CollectableYellow, v2, Quaternion.identity, transform);
                        break;
                    case 7:
                        x = spawnpoint.position.x - 29;
                        y = spawnpoint.position.y;
                        z = spawnpoint.position.z;
                        v = new Vector3(x, y, z);

                        x2 = spawnpoint.position.x - 29 - 29;
                        y2 = spawnpoint.position.y;
                        z2 = spawnpoint.position.z;
                        v2 = new Vector3(x2, y2, z2);

                        Instantiate(CollectableYellow, v, Quaternion.identity, transform);
                        Instantiate(CollectableRed, v2, Quaternion.identity, transform);
                        break;
                    case 8:
                        x = spawnpoint.position.x - 29;
                        y = spawnpoint.position.y;
                        z = spawnpoint.position.z;
                        v = new Vector3(x, y, z);

                        x2 = spawnpoint.position.x - 29 -29;
                        y2 = spawnpoint.position.y;
                        z2 = spawnpoint.position.z;
                        v2 = new Vector3(x2, y2, z2);

                        Instantiate(CollectableRed, v, Quaternion.identity, transform);
                        Instantiate(CollectableYellow, v2, Quaternion.identity, transform);
                        break;

                    case 9:

                        Instantiate(CollectableYellow, spawnpoint.position, Quaternion.identity, transform);
                        break;


                }
            }
        }
        


           int index2 = Random.Range(8, 14);
            Transform spawnpoint2 = transform.GetChild(index2).transform;
            Instantiate(CollectableRed, spawnpoint2.position, Quaternion.identity, transform); 
        
    }
    
}