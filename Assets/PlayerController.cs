using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    float xInput;
   
    public int score = 0;
    int health = 5;
    int ability = 10;
    public TMP_Text myAbility;
    public TMP_Text myHealth;
    public TMP_Text myScore;
    public bool onGround;
    float speedforward= 60;
    float speed = 200;
    float UpForce = 3000;
    string s; 


    PauseMenu pause;
    public GameObject pauseMenu;

    public bool ispaused;

    GameOverScript gameover;
    public GameObject Gameover;


    public AudioSource JumpSoundEffect;
    public  AudioSource CollectablesSoundEffect;
    public  AudioSource ObstaclesSoundEffect;
    public  AudioSource BackgroundSoundEffect;
    public AudioSource PauseMenuSoundEffect;
    public AudioSource GameOverSoundEffect;

    bool isLPressed= false;
    bool EscapePressed = false;
    bool isGameOver = false;

    void Start()
    {
        onGround = true;
        rb = GetComponent<Rigidbody>();
        pause =  pauseMenu.GetComponent<PauseMenu>();
        gameover = Gameover.GetComponent<GameOverScript>();



    }
    void FixedUpdate()
    {
        xInput = Input.GetAxis("Horizontal");

        rb.AddForce(xInput * speed , 0, 0);
        // transform.Translate(new Vector3(xInput, 0, 0) * speedturn * Time.deltaTime);
        //rb.AddForce(Vector3.forward * 15);
        transform.Translate(new Vector3(0, 0, 1) * speedforward * Time.deltaTime);
    }

  
    void Update()
    {
        if (health == 0)
        {
            ispaused = false;

            pause.Pause(ispaused);

            gameover.GameOver(score);
        }
        
        if (onGround)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (ability > 0)
                {
                    rb.AddForce(Vector3.up * UpForce );
                    JumpSoundEffect.Play();
                    //transform.Translate(new Vector3(0, 1, 0) * 2000 * Time.deltaTime);
                    onGround = false;
                }

            }
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (ability >= 5)
            {
                foreach (GameObject g in GameObject.FindGameObjectsWithTag("1Lane"))
                {
                    g.SetActive(false);
                }
                foreach (GameObject g in GameObject.FindGameObjectsWithTag("2Lane"))
                {
                    g.SetActive(false);
                }
                foreach (GameObject g in GameObject.FindGameObjectsWithTag("3Lane"))
                {
                    g.SetActive(false);
                }
                ability = ability - 5;
                myAbility.text = "Ability: " + ability;

            }
        }
       

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isGameOver)
            {
                if (!EscapePressed)
                {
                    pauseBackGroundandPlayPauseMenu();
                    ispaused = true;
                    pause.Pause(ispaused);
                    EscapePressed = true;
                }
                else
                {
                    PauseMenuSoundEffect.Stop();
                    BackgroundSoundEffect.Play();
                    ispaused = false;
                    pause.Resume();
                    EscapePressed = false;

                }
            }
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            if(health<5)
            health = health + 1;
            myHealth.text = "Health: " + health;

        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            if(health>0)
            health = health  - 1;
            myHealth.text = "Health: " + health;

        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            if(ability<10)
            ability = ability + 1;
            myAbility.text = "Ability: " + ability;

        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            if(ability >0)
            ability = ability - 1;
            myAbility.text = "Ability: " + ability;

        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            isLPressed = true;

        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            isLPressed = false;

        }




    }
    private void OnCollisionEnter(Collision collision)
    {
        s = collision.gameObject.tag;
        if (collision.gameObject.CompareTag("Ground"))
        {
            onGround = true;

        }

        if (collision.gameObject.CompareTag("RedCollectables"))
        {
            CollectablesSoundEffect.Play();
            if (health < 5)
            {
                health = health + 1;

            }
            myHealth.text = "Health: " + health;
            Destroy(collision.gameObject);




        }
        if (collision.gameObject.CompareTag("1Lane"))
        {
            if (!isLPressed)
            {

               ObstaclesSoundEffect.Play();
            if (health <= 3)
            {
                    BackgroundSoundEffect.Stop();
                    GameOverSoundEffect.Play();

                ispaused = false;

                isGameOver = true;

                pause.Pause(ispaused);

                gameover.GameOver(score);

            }
            else
            {
               
                    health = health - 3;
                    myHealth.text = "Health: " + health;
                    Destroy(collision.gameObject);
                }


            }

        }
        if (collision.gameObject.CompareTag("2Lane"))
        {
            if (!isLPressed)
            {
                ObstaclesSoundEffect.Play();

                if (health <= 2)
                {
                    BackgroundSoundEffect.Stop();
                    GameOverSoundEffect.Play();
                    ispaused = false;
                    isGameOver = true;
                    pause.Pause(ispaused);
                    gameover.GameOver(score);


                }
                else
                {
                    health = health - 2;
                    myHealth.text = "Health: " + health;
                    Destroy(collision.gameObject);

                }
            }

        }
        if (collision.gameObject.CompareTag("3Lane"))
        {
            if (!isLPressed)
            {
                ObstaclesSoundEffect.Play();
                if (health <= 1)
                {
                    BackgroundSoundEffect.Stop();
                    GameOverSoundEffect.Play();
                    ispaused = false;
                    isGameOver = true;
                    pause.Pause(ispaused);
                    gameover.GameOver(score);
                }
                else
                {
                    health = health - 1;
                    myHealth.text = "Health: " + health;
                    Destroy(collision.gameObject);
                }
            }

        }
        if (collision.gameObject.CompareTag("YellowCollectables"))
        {
            CollectablesSoundEffect.Play();
            if (ability < 10)
            {
                ability = ability + 1;

            }
            myAbility.text = "Ability: " + ability;
            Destroy(collision.gameObject);


        }


    }

    
    private void OnTriggerExit(Collider e)
    {

        if (e.gameObject.CompareTag("1Lane"))
        {
            if (s != "1Lane")
            {


                score = score + 3;
                myScore.text = "Score: " + score;
                ability = ability - 1;
                myAbility.text = "Ability: " + ability;
                Destroy(e.transform.parent.gameObject);


            }
        }
        if (e.gameObject.CompareTag("2Lane"))
        {
            if (s != "2Lane")
            {
                score = score + 2;
                myScore.text = "Score: " + score;
                ability = ability - 1;
                myAbility.text = "Ability: " + ability;
                Destroy(e.transform.parent.gameObject);
            }
        }
        if (e.gameObject.CompareTag("3Lane"))
        {
            if (s != "3Lane")
            {
                score = score + 1;
                myScore.text = "Score: " + score;
                ability = ability - 1;
                myAbility.text = "Ability: " + ability;
                Destroy(e.transform.parent.gameObject);
            }
        }
    }
   
    public void pauseBackGroundandPlayPauseMenu()
    {
        BackgroundSoundEffect.Pause();
        PauseMenuSoundEffect.Play();
    }

}
   




