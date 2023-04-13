using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float zEnemySpawn = 12.0f;
    public float xEnemySpawnRange = 16.0f;
    public float zPowerUpSpawnRange = 5.0f;
    public float ySpawn = 0.75f;
    public float startDelay = 1.0f;
    public float enemySpawnRate = 3.0f;
    public float powerUpSpawnRate = 5.0f;

    public GameObject[] enemy;
    public GameObject powerUp;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("EnemyRandomSpawn", startDelay, enemySpawnRate);
        InvokeRepeating("PowerUpSpawn", startDelay, powerUpSpawnRate);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void EnemyRandomSpawn()
    {
        float posX = Random.Range(-xEnemySpawnRange, xEnemySpawnRange);
        Vector3 randomPos = new Vector3(posX, ySpawn, zEnemySpawn);

        int randomIndex = Random.Range(0, enemy.Length);
        Instantiate(enemy[randomIndex], randomPos, enemy[randomIndex].transform.rotation);
    }

    void PowerUpSpawn()
    {
        float posX = Random.Range(-xEnemySpawnRange, xEnemySpawnRange);
        float posZ = Random.Range(-zPowerUpSpawnRange, zPowerUpSpawnRange);
        Vector3 randomPos = new Vector3(posX, ySpawn, posZ);
        Instantiate(powerUp, randomPos, powerUp.transform.rotation);
    }
}
