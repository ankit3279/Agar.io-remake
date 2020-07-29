using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 10f;

    private Vector2 target; //Mouse Position

    private void Update()
    {
        Movement();
    }

    void Movement()
    {
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime / transform.localScale.x);
    }

}
