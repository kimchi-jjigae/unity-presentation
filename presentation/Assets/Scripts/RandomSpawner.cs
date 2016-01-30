using UnityEngine;
using System.Collections;

public class RandomSpawner : MonoBehaviour {

    public GameObject prefabToSpawn;
    float lastSpawnTime;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(Random.value < 0.01f && Time.time - 1.0 > lastSpawnTime)
        {
            GameObject spawned = Instantiate(prefabToSpawn, transform.position, transform.rotation) as GameObject;

            EnemyController enemyController = spawned.GetComponent<EnemyController>();

            enemyController.speed = Random.value * 10 + 2;

            lastSpawnTime = Time.time;
        }
	}
}
