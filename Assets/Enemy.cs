using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float spawnRate = 1f;

    private float nextTimeToSpawn = 0f;

    public List<GameObject> Enemies;




    // Update is called once per frame
    void Update()
    {
        Enemies[Random.Range(0, 8)].transform.localScale = new Vector3(Random.Range(50f, 100f), Random.Range(50f, 100f), Random.Range(50f, 100f));
        Vector3 position = new Vector3(Random.Range(-8f, 8f), -20, Random.Range(-4f, 5f));
        if (Time.time >= nextTimeToSpawn)
        {
            Instantiate(Enemies[Random.Range(0, 8)], position, Quaternion.identity);
            nextTimeToSpawn = Time.time + 1f / spawnRate;
        }
        
    }
}
