using UnityEngine;
using System.Collections;

public class SpawnOnDie : MonoBehaviour {

    public GameObject prefabToSpawn;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void died()
    {
        Instantiate(prefabToSpawn, transform.position, transform.rotation);
    }
}
