using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCollect : MonoBehaviour
{

    void Start()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("1Lane") || collision.gameObject.CompareTag("2Lane") || collision.gameObject.CompareTag("3Lane"))
        {
            Destroy(gameObject);
        }
    }
}
