using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    private GameManager gameManager;
    private PlayerController playerController;
    private AudioSource playerAudio;
    public AudioClip collectSound;
    public AudioClip deniedSound;
    public int playerHealth = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager")
            .GetComponent<GameManager>();
        playerAudio = GameObject.Find("Player").GetComponent<AudioSource>();
        playerAudio.clip = collectSound;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        void OnTriggerEnter(Collider other)
    {
        //If players collide with a key, pick up sound is played and the key is destroyed. Updates key to collected. When all 3 keys are collected, WinCheck unlocks the door by destroyed the outside barrier.
        if (other.CompareTag("YellowKey"))
        {
            playerAudio.clip = collectSound;
            playerAudio.PlayOneShot(collectSound, 1);
            gameManager.UpdateScoreYellow(true);
            Destroy(other.gameObject);
            
            gameManager.WinCheck();
        }
        if (other.CompareTag("BlueKey"))
        {
           playerAudio.clip = collectSound;
           playerAudio.PlayOneShot(collectSound, 1);
            gameManager.UpdateScoreBlue(true);
            Destroy(other.gameObject);
            
            gameManager.WinCheck();
        }
        if (other.CompareTag("RedKey"))
        {
           playerAudio.clip = collectSound;
           playerAudio.PlayOneShot(collectSound, 1);
            gameManager.UpdateScoreRed(true);
            Destroy(other.gameObject);
            
            gameManager.WinCheck();
        }

        //If Player hits the door, access denied sound is played, executes method that displays a message that disappears after 4 seconds

        if (other.CompareTag("KeyDoor"))
        {
            playerAudio.clip = deniedSound;
            playerAudio.PlayOneShot(deniedSound, 1);
            gameManager.DoorBump();
        }
           //If player leaves the first level, level 2 immdetiately starts.
        if(other.CompareTag("Exit"))
        {
            gameManager.StartLevel2();
        }
        //Player leaving second level wins the game.
        if(other.CompareTag("ExitLvl2"))
        {
            gameManager.WinScreen();
        }

        //Every time you collide with the enemy, lose a life.
        //Every time you lose a life, destroy a heart icon from the UI
        //When health goes to 0, lose the game.

        if(other.CompareTag("Enemy"))
        {
            playerHealth = playerHealth- 1;

            if(playerHealth == 2)
            {
                Destroy(GameObject.FindWithTag("Health1"));
            }

            if (playerHealth == 1)
            {
                Destroy(GameObject.FindWithTag("Health2"));
            }

            if (playerHealth == 0)
            {
                Destroy(GameObject.FindWithTag("Health3"));
                gameManager.GameOver(); 
            }
            
        }
    }
}
