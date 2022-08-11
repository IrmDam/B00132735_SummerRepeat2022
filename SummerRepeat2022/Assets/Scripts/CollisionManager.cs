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

        if (other.CompareTag("KeyDoor"))
        {
            playerAudio.clip = deniedSound;
            playerAudio.PlayOneShot(deniedSound, 1);
            gameManager.DoorBump();
        }
 

    }
}
