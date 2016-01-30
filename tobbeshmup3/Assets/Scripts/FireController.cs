using UnityEngine;
using System.Collections;

public class FireController : MonoBehaviour {

    public GameObject bulletPrefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void fire()
    {
        float yOffset = 0.3f;
        Instantiate(bulletPrefab, new Vector3(transform.position.x, transform.position.y + yOffset, transform.position.z), transform.rotation);
        Instantiate(bulletPrefab, new Vector3(transform.position.x, transform.position.y - yOffset, transform.position.z), transform.rotation);
    }
}
