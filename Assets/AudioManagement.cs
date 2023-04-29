using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagement : MonoBehaviour
{
    private bool isMuted;
    
    void Start()
    {
        isMuted = false;
    }

   
    void Update()
    {
        
    }
    public void MuteAll()
    {
        isMuted = !isMuted;
        AudioListener.pause = isMuted;
    }
}
