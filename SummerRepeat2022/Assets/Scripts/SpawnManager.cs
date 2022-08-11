using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] keyPrefab;
    private Vector3 Min;
    private Vector3 Max;
    private float _xAxis;
    private float _zAxis;
    private Vector3 _randomPosition;
    private float _xAxis1;
    private float _zAxis1;
    private Vector3 _randomPosition1;
    public bool _canInstantiate;

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


    //public Vector3 spawnPoints[] = (new Vector3(12, -3f, 21.3f), new Vector3(-10.6f, -3f, 19.16f));
   //public Vector3 spawnPos2 = new Vector3(-10.6f, -3f, 19.16f);

    

 /* Transform GetSpawnPoint()
    {
        int locationIndex = 
        return spawnPoints[locationIndex];
    }*/

    // Start is called before the first frame update
    void Start()
    {
        spawnPosition();
        
        /*SetRanges();
         _xAxis = UnityEngine.Random.Range(Min.x, Max.x);
         _zAxis = UnityEngine.Random.Range(Min.z, Max.z);
         _xAxis1 = UnityEngine.Random.Range(Min.x, Max.x);
         _zAxis1 = UnityEngine.Random.Range(Min.z, Max.z);
        _randomPosition = new Vector3(_xAxis, -3f, _zAxis );
        _randomPosition1 = new Vector3(_xAxis1, -3f, _zAxis1);
        */
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

    private void SetRanges()
     {
         Min = new Vector3(14, -2, 0); 
         Max = new Vector3(-15.5f, -2, 30);
     }

    // Update is called once per frame
    void Update()
    {
        //GetSpawnPoint();
    }
}
