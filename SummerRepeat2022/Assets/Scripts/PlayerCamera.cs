using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerCamera : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset; //= new Vector3(-3.5f,2.5f,.05f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //Camera follows player
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
