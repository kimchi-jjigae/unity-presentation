using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

    public float rate;
    public Transform enemy;

	void Start () {
	}
	
	void Update () {
        if(Random.value < rate) {
            Vector3 pos = new Vector3(9.9f, Random.value * 10.0f - 5.0f, 0.0f);
            Instantiate(enemy, pos, transform.rotation);
        }
	
	}
}
