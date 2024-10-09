using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    //enemy prefabs
    public GameObject redEnemy;
    public GameObject blueEnemy;
    public GameObject greenEnemy;

    //enemy range
    private float spawnRange = 9;

    //enemy config
    public int enemyCount;
    public int enemySpawn = 1;

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemies(enemySpawn);
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;

        if (enemyCount == 0)
        {
            
        }enemySpawn++;
        SpawnEnemies(enemySpawn);
    }

    void SpawnEnemies(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            int enemyType = Random.Range(1, 4);

            GameObject enemyPrefab;

            switch (enemyType)
            {
                case 1:
                    enemyPrefab = redEnemy;
                    break;

                case 2:
                    enemyPrefab = blueEnemy;
                    break;

                case 3:
                    enemyPrefab = greenEnemy;
                    break;

                default:
                    enemyPrefab = redEnemy;
                    break;
            }

            Instantiate(enemyPrefab, GenerateSpawnPoint(), enemyPrefab.transform.rotation);
        }
    }


    private Vector3 GenerateSpawnPoint()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);

        return randomPos;
    }
}
