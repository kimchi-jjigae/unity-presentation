using UnityEngine;
using System.Collections;

public class RandomSpawner : MonoBehaviour {

    public GameObject prefabToSpawn;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Random.value < 0.01)
            Instantiate(prefabToSpawn, transform.position, transform.rotation);
	}
}
