using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private float turnSpeed = 150.0f;
    public float turnDuration = 5f;
    public float enemySpeed = .003f;
   // public bool moveEnemy = true;
    public Transform[] pathPoints;
    public Rigidbody enemyBody;
    int currentPoint;
    //public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        currentPoint = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(enemyBody.transform.position != pathPoints[currentPoint].position)
        {
            enemyBody.transform.position = Vector3.MoveTowards(enemyBody.transform.position, pathPoints[currentPoint].position, enemySpeed * Time.deltaTime);
        }
        else
        {
            currentPoint = (currentPoint + 1) % pathPoints.Length;
        }
        //transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);



    }

}
