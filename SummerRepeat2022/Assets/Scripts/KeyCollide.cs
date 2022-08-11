using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollide : MonoBehaviour
{
    private GameManager gameManager;
    private PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager")
            .GetComponent<GameManager>();
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("YellowKey"))
        {
            //playerController.playerAudio.PlayOneShot(playerController.collectSound, .32f);
            gameManager.UpdateScoreYellow(true);
            Destroy(other.gameObject);
            
            gameManager.WinCheck();
        }
        if (other.CompareTag("BlueKey"))
        {
           //playerController.playerAudio.PlayOneShot(playerController.collectSound, .32f);
            gameManager.UpdateScoreBlue(true);
            Destroy(other.gameObject);
            
            gameManager.WinCheck();
        }
        if (other.CompareTag("RedKey"))
        {
           //playerController.playerAudio.PlayOneShot(playerController.collectSound, .32f);
            gameManager.UpdateScoreRed(true);
            Destroy(other.gameObject);
            
            gameManager.WinCheck();
        }

        if (other.CompareTag("KeyDoor"))
        {
            gameManager.DoorBump();
        }
 

    }
}
