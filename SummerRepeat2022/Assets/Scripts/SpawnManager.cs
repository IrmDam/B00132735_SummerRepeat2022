using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] keyPrefab;
    public Vector3[] spawnPoints;

public static void spawnPosition()
{
    Vector3[] spawnPoints = new Vector3[6];
    
    Vector3 spawnPos = new Vector3(12, -3f, 21.3f);
    Vector3 spawnPos1 = new Vector3(-10.6f, -3f, 19.16f);
    Vector3 spawnPos2 = new Vector3(15f, -3f, -.8f);
    Vector3 spawnPos3 = new Vector3(-4f, -3f, 25.5f);
    Vector3 spawnPos4 = new Vector3(-10f, -3f, 12.45f);
    Vector3 spawnPos5 = new Vector3(.3f, -3f, 2.55f);
    
    spawnPoints[0] = spawnPos;
    spawnPoints[1] = spawnPos1;
    spawnPoints[2] = spawnPos2;
    spawnPoints[3] = spawnPos3;
    spawnPoints[4] = spawnPos4;
    spawnPoints[5] = spawnPos5;
    


}



    // Start is called before the first frame update
    void Start()
    {
        spawnPosition();

        Instantiate(keyPrefab[0], spawnPoints[Random.Range(0, 6)], Quaternion.identity);
        Instantiate(keyPrefab[1], spawnPoints[Random.Range(0, 6)], Quaternion.identity);
        Instantiate(keyPrefab[2], spawnPoints[Random.Range(0, 6)], Quaternion.identity);
        
         if(keyPrefab[1].transform.position == keyPrefab[0].transform.position || keyPrefab[1].transform.position == keyPrefab[2].transform.position)
        {
           Destroy(keyPrefab[1]);
           Instantiate(keyPrefab[1], spawnPoints[Random.Range(0, 6)], Quaternion.identity);
        }

        if(keyPrefab[2].transform.position == keyPrefab[0].transform.position ||keyPrefab[2].transform.position == keyPrefab[1].transform.position )
        {
           Destroy(keyPrefab[2]);
           Instantiate(keyPrefab[2], spawnPoints[Random.Range(0, 6)], Quaternion.identity);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
