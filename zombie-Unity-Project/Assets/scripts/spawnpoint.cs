using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnpoint : MonoBehaviour
{
    public GameObject[] haerts;
    public int life;
    public GameObject[] enemy;

    public float time = 1;
    public float trySpawnrate = 2;

    public Transform RangeLeftX;
    public Transform RangeRightX;


    public Transform RangeUpY;
    public Transform RangeDownY;

    public float hard = 0;



    
    void Start()
    {
        StartCoroutine("EnemyHard");
    }
    public void Update()
    {
        hard += Time.deltaTime;

        if(hard > 10 && hard < 15)
        {
            trySpawnrate = 1.5f;
        }
        if(hard > 15 && hard < 20)
        {
            trySpawnrate = 1.25f;
        }
        if(hard > 20 && hard < 25)
        {
            trySpawnrate = 1;
        }
        if(hard > 30)
        {
            trySpawnrate = 0.75f;
        }
    }
    IEnumerator EnemyHard()
    {
        yield return new WaitForSeconds(trySpawnrate);
        SpawnEnemy();
        StartCoroutine("EnemyHard");
    }
    
    public void SpawnEnemy()
    {
        Vector3 spawnPosition = new Vector3(0, 0, 0);
        spawnPosition = new Vector3(Random.Range(RangeLeftX.position.x, RangeRightX.position.x), Random.Range(RangeDownY.position.y, RangeUpY.position.y),0);
        GameObject enemi = Instantiate(enemy[Random.Range(0,enemy.Length)],spawnPosition,gameObject.transform.rotation);
    }

}
