using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    private GameManager gameManager;
    private PlayerController playerController;
    private AudioSource playerAudio;
    public AudioClip collectSound;
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

        if (other.CompareTag("YellowKey"))
        {
            playerAudio.clip = collectSound;
            playerAudio.PlayOneShot(collectSound, 0.6f);
            gameManager.UpdateScoreYellow(true);
            Destroy(other.gameObject);
            
            gameManager.WinCheck();
        }
        if (other.CompareTag("BlueKey"))
        {
           playerAudio.clip = collectSound;
           playerAudio.PlayOneShot(collectSound, 0.6f);
            gameManager.UpdateScoreBlue(true);
            Destroy(other.gameObject);
            
            gameManager.WinCheck();
        }
        if (other.CompareTag("RedKey"))
        {
           playerAudio.clip = collectSound;
           playerAudio.PlayOneShot(collectSound, 0.6f);
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
