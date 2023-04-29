using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class GameOverScript : MonoBehaviour
{
    public TMP_Text gameover;

    public TMP_Text finalscore;

    PlayerController test;

    public GameObject playerController;

    public GameObject gameoverobject;

    public GameObject gameplay;

    void Start()
    {
        test = playerController.GetComponent<PlayerController>();

    }

    public void GameOver(int score)

    {
        gameoverobject.SetActive(true);
        gameplay.SetActive(false);
        gameover.text = "GAME OVER!";
        finalscore.text = "Your Final Score " + score;

        //Debug.Log(test.score);
    }
}
