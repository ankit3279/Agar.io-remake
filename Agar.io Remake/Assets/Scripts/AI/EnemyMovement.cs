using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 6f;

    private float waitTime;
    public float startWaitTime;

    [SerializeField]
    private Transform moveSpot;

    [SerializeField]
    private float minX = -32f, maxX = 32f, minY = -32f, maxY = 32f;

    private void Start()
    {
        waitTime = startWaitTime;

        moveSpot.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
    }

    private void Update()
    {
        Movement();
    }

    void Movement()
    {
        transform.position = Vector2.MoveTowards(transform.position, moveSpot.position, speed * Time.deltaTime / transform.localScale.x);
        if (Vector2.Distance(transform.position, moveSpot.position) < 0.3f)
        {
            moveSpot.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
            waitTime = startWaitTime;
        }
        else
        {
            waitTime -= Time.deltaTime;
        }
    }

   
}
