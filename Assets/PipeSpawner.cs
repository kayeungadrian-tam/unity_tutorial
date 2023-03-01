using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    public GameObject pipe;
    public float spawnRate = 2;
    public float heightOffset = 10;

    private float timer = 0;
    private float dynamicSpawnCount = 1;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(dynamicSpawnCount);
        if (timer < spawnRate){
            timer += dynamicSpawnCount * Time.deltaTime;
        } else {
            spawnPipe();
            timer = 0;
            dynamicSpawnCount += 0;
        }
    }

    void spawnPipe(){
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }

    

}
