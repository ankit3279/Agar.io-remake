using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEats : MonoBehaviour
{
    [SerializeField]
    private float increseSize = 0.05f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Food")
        {
            transform.localScale += new Vector3(increseSize, increseSize, 0);
            Destroy(collision.gameObject);
        }
        if (collision.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }


}
