using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnDelay = 2.5f;
    public float minSpawnHeight = -2f;
    public float maxSpawnHeight = 2f;


    void Start()
    {
        InvokeRepeating("SpawnPipe", 0f, spawnDelay);
    }



    void SpawnPipe()
    {
        float randomHeight = Random.Range(minSpawnHeight, maxSpawnHeight);          //设置随机高度的限制

        Vector2 spwanPosition = new Vector2(transform.position.x, randomHeight);    //创建一个随机高度

        Instantiate(pipePrefab, spwanPosition, Quaternion.identity);                //在创建的高度生成新水管
    } 
}
