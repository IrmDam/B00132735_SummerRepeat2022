using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private float turnSpeed = 150.0f;
    public float turnDuration = 5f;
    public float enemySpeed = .003f;
    public bool moveEnemy = true;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(enemyPattern());
    }

    // Update is called once per frame
    void Update()
    {
        

        //transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);



    }

    IEnumerator enemyPattern()
    {
        Debug.Log("workin");

            enemy.transform.Translate(0, 0, .003f);
            yield return new WaitForSecondsRealtime(7.0f);
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
            yield return new WaitForSecondsRealtime(2.0f);
        
    }
}
