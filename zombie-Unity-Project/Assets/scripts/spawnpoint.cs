using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnpoint : MonoBehaviour
{

    public GameObject[] enemy;

    public float time = 1;
    public float trySpawnrate = 2;

    public Transform RangeLeftX;
    public Transform RangeRightX;


    public Transform RangeUpY;
    public Transform RangeDownY;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", time,trySpawnrate);
    }
    public void SpawnEnemy()
    {
        Vector3 spawnPosition = new Vector3(0, 0, 0);
        spawnPosition = new Vector3(Random.Range(RangeLeftX.position.x, RangeRightX.position.x), Random.Range(RangeDownY.position.y, RangeUpY.position.y),0);
        GameObject enemi = Instantiate(enemy[Random.Range(0,enemy.Length)],spawnPosition,gameObject.transform.rotation);
    }
   
}
