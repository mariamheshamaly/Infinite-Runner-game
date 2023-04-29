using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool gamepaused = false;
    public GameObject PauseMenuUI;
    public GameObject gameplay;

    PlayerController player;
    public GameObject playerController;

    public void Start()
    {
        player = playerController.GetComponent<PlayerController>();
    }





    public void  Resume()
    {
        PauseMenuUI.SetActive(false);
        gameplay.SetActive(true);
        Time.timeScale = 1f;
       


    }

     public void Pause(bool ispaused)
    {
        if (ispaused == true)
        {
            PauseMenuUI.SetActive(true);

            gameplay.SetActive(false);

            Time.timeScale = 0f;
        }

        else
        {
            Time.timeScale = 0f;
        }
    }
    public void MainMenu()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        //gamepaused = true;
    }
    public void ResumeBackGround()
    {
        player.PauseMenuSoundEffect.Pause();
        player.BackgroundSoundEffect.Play();
    }
}
