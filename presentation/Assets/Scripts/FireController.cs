using UnityEngine;
using System.Collections;

public class FireController : MonoBehaviour {

    public GameObject prefabToSpawn;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void fire()
    {
        float yOffset = 0.3f;
        Instantiate(prefabToSpawn, new Vector3(transform.position.x - 1.0f, transform.position.y + yOffset, transform.position.z), transform.rotation);
        Instantiate(prefabToSpawn, new Vector3(transform.position.x - 1.0f, transform.position.y - yOffset, transform.position.z), transform.rotation);
    }
}
