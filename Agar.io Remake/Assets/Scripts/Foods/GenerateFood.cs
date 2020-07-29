using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateFood : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Foods;
    [SerializeField]
    private float spawnRate = 2f;

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    private Vector2 spawnPoint;

    private void Start()
    {
        InvokeRepeating("Generate", 0.5f, spawnRate);
    }


    void Generate()
    {
        int i = Random.Range(0, Foods.Length);
        spawnPoint = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        Instantiate(Foods[i], spawnPoint, Quaternion.identity);
    }


    /* int x = Random.Range(0, Camera.main.pixelWidth);
        int y = Random.Range(0, Camera.main.pixelHeight);
        Vector2 spawnPoint = Camera.main.ScreenToWorldPoint(new Vector3(x, y, 0));
        Generate random on Screen Point*/
}
