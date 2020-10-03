using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    private int animalIndex;
    private float spwanRangeX = 22f;
    private float spawnPosZ;
    [SerializeField,Range(1,5)]
    private float startDelay = 1.5f;
    [SerializeField,Range(0.3f,2f)]
    private float spawnInterval = 0.5f;
    private void Start()
    {
        spawnPosZ = transform.position.z;
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }
    void Update()
    {
            //Se genera la posición de donde aparecera el nuevo enemigo
            
            
        
        
    }
    private void SpawnRandomAnimal()
    {
        //Se genera la posición de donde aparecera el nuevo enemigo
        float xRand = Random.Range(-spwanRangeX, spwanRangeX);
        animalIndex = Random.Range(0, enemies.Length);
        Vector3 spawnPos = new Vector3(xRand, 0, spawnPosZ);
        Instantiate(enemies[animalIndex], spawnPos, enemies[animalIndex].transform.rotation);
        
    }

   
}
