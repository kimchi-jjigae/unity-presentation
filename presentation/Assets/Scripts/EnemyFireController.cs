using UnityEngine;
using System.Collections;

public class EnemyFireController : MonoBehaviour {

    public GameObject prefabToSpawn;
    GameObject aimTowards;
	// Use this for initialization
	void Start () {
	    aimTowards = FindObjectsOfType(typeof(PlayerController))[0] as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void fire()
    {
        float yOffset = 0.3f;

        GameObject bullet1 = Instantiate(prefabToSpawn, new Vector3(transform.position.x - 1.0f, transform.position.y + yOffset, transform.position.z), transform.rotation) as GameObject;
        GameObject bullet2 = Instantiate(prefabToSpawn, new Vector3(transform.position.x - 1.0f, transform.position.y - yOffset, transform.position.z), transform.rotation) as GameObject;

        Vector3 aimDirection = aimTowards.transform.position - transform.position;
        aimDirection.Normalize();

        bullet1.GetComponent<BulletController>().direction = aimDirection;
        bullet2.GetComponent<BulletController>().direction = aimDirection;
    }
}
