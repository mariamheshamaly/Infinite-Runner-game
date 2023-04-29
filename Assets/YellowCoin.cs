using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowCoin : MonoBehaviour
{
    float turnspeed = 90f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, turnspeed * Time.deltaTime);
    }
}
