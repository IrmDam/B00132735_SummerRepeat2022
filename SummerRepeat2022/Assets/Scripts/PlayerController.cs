using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public KeyCollide keyCollide;
    public AudioClip collectSound;
    new public AudioSource playerAudio;
    public float horizontalInput;
    public float verticalInput;
    private float turnSpeed = 150.0f;
    private float speed = 6.0f;
    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);


        
    }
     public void playCollectSound()
        {
            playerAudio.PlayOneShot(collectSound, 0.32f);
        }
}
